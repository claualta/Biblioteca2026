Imports MySqlConnector
Imports System.IO   'libreria para trabajar con archivos
Imports System.Drawing.Imaging 'libreria para trabajar con imagenes

Public Class frmLibros

    'funcion para convertir una imagen en un arreglo de bytes
    Private Function ImagenaBytes(img As Image) As Byte()
        'valido si la imagen es nula no hago
        If img Is Nothing Then Return Nothing

        'memory stream es un flujo de datos en memoria
        Using memoria As New MemoryStream()
            ' guardo la imagen en el memory stream
            img.Save(memoria, ImageFormat.Jpeg)
            'retorno la imagen en bytes
            Return memoria.ToArray()
        End Using
    End Function

    Sub CargarPortada(idlibro As Integer)
        'recupero la imagen desde la BD y la pego en el picturebox
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT portada FROM libro WHERE clavelibro=@idlibro;"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@idlibro", CInt(txtIdLibro.Text))
                    Dim valor = cmd.ExecuteScalar
                    'valido que el valor no sea null
                    If valor Is Nothing OrElse valor Is DBNull.Value Then
                        picPortada.Image = Nothing
                        Exit Sub
                    End If
                    'si tiene la portada convierto y cargo al pic
                    Dim datos() As Byte = DirectCast(valor, Byte())
                    'vuelvo a usar memory stream para la conversion temporal en memoria
                    Using memoria As New MemoryStream(datos)
                        Using temporal As Image = Image.FromStream(memoria)
                            picPortada.Image = New Bitmap(temporal)
                        End Using
                    End Using
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("ERROR" + ex.Message)
        End Try
    End Sub

    Sub CargarGrilla(Optional filtro As String = "")
        'creo subrutina para cargar grilla
        Try
            'conectamo a la bd
            Using cn As New MySqlConnection(CADENA)

                cn.Open()

                'armo mi consulta sql
                Dim consulta As String

                consulta = "SELECT li.clavelibro, li.titulo, li.idioma, li.formato, li.edicion, li.claveeditorial, ed.nombre AS Editorial " &
                            "FROM libro AS li " &
                            "JOIN editorial AS ed ON li.claveeditorial = ed.claveeditorial "

                'aplico filtro
                If filtro = "" Then
                    consulta = consulta &
                            " ORDER BY titulo;"
                Else
                    consulta = consulta &
                                "WHERE titulo Like @filtro " &
                                "ORDER BY titulo;"
                End If

                Using comando As New MySqlCommand(consulta, cn)
                    'evito SQL >INjection usando parametros
                    comando.Parameters.AddWithValue("@filtro", "%" & filtro & "%")

                    'uso datatable para guardar un select 
                    Dim tabla As New DataTable

                    Using lector As MySqlDataReader = comando.ExecuteReader
                        tabla.Load(lector)
                    End Using

                    'cargar la tabla en la grilla
                    dgvLibros.DataSource = tabla

                    'oculto la columna clave editorial
                    If (dgvLibros.Columns.Contains("claveeditorial")) Then
                        dgvLibros.Columns("claveeditorial").Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("ERROR: " & ex.Message)
        End Try

    End Sub

    Private Sub CargarComboEditoriales()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String =
                        "SELECT claveeditorial, nombre FROM editorial ORDER BY nombre"
                Using cmd As New MySqlCommand(sql, cn)
                    Dim tabla As New DataTable()
                    Using lector = cmd.ExecuteReader()
                        tabla.Load(lector)
                    End Using
                    ' El usuario verá el nombre...
                    cboEditorial.DisplayMember = "nombre"
                    ' ...pero el programa guardará la clave numérica.
                    cboEditorial.ValueMember = "claveeditorial"
                    cboEditorial.DataSource = tabla
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar editoriales: " & ex.Message)
        End Try
    End Sub

    Sub LimpiarForm()
        txtFiltro.Clear()
        txtIdLibro.Clear()
        txtTitulo.Clear()
        txtIdioma.Clear()
        txtFormato.Clear()
        nudEdicion.Value = 0
        picPortada.Image = Nothing
        txtFiltro.Focus()
    End Sub

    Private Sub frmLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargo la grilla sin filtrar
        CargarGrilla()
        'cargo combo editorial
        CargarComboEditoriales()

        'inhabilito el boton eliminar si el usuario no es ADMIN
        If Sesion.rolUsuario <> "ADMIN" Then
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'llamo a cargargrilla con filtro
        CargarGrilla(txtFiltro.Text.Trim)
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'llamo a cargargrilla con filtro
        CargarGrilla(txtFiltro.Text.Trim)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtTitulo.Text.Trim() = "" Then
            MessageBox.Show("Ingrese el título.")
            txtTitulo.Focus()
            Exit Sub
        End If

        If cboEditorial.SelectedValue Is Nothing Then
            MessageBox.Show("Seleccione una editorial.")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String =
                "INSERT INTO libro(titulo, idioma, formato, edicion, claveeditorial) " &
                "VALUES(@titulo, @idioma, @formato, @edicion, @editorial)"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim())
                    cmd.Parameters.AddWithValue("@idioma", txtIdioma.Text.Trim())
                    cmd.Parameters.AddWithValue("@formato", txtFormato.Text.Trim())
                    cmd.Parameters.AddWithValue("@edicion", CInt(nudEdicion.Value))
                    ' SelectedValue contiene la claveeditorial del elemento elegido.
                    cmd.Parameters.AddWithValue("@editorial", CInt(cboEditorial.SelectedValue))
                    'capturo respuesta del servidor
                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registros guardados: " & resultado.ToString())
                End Using
            End Using
            MessageBox.Show("Libro guardado.")
            CargarGrilla()
            LimpiarForm()
        Catch ex As Exception
            MessageBox.Show("Error al guardar libro: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvLibros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellClick
        'valido que haya seleccionado algo
        If e.RowIndex < 0 Then Exit Sub
        'extraigo los datos del libro de la grilla y los cargo en los textbox
        Dim fila = dgvLibros.Rows(e.RowIndex)
        txtIdLibro.Text = fila.Cells("clavelibro").Value.ToString()
        txtTitulo.Text = fila.Cells("titulo").Value.ToString()
        txtIdioma.Text = fila.Cells("idioma").Value.ToString()
        txtFormato.Text = fila.Cells("formato").Value.ToString()
        nudEdicion.Value = fila.Cells("edicion").Value
        ' Para editar correctamente conviene que la consulta del DataGridView
        ' también incluya claveeditorial, aunque la columna se oculte.
        cboEditorial.SelectedValue = CInt(fila.Cells("claveeditorial").Value)
        'traigo imagen de la portada
        CargarPortada(CInt(txtIdLibro.Text))
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdLibro.Text = "" Then
            MessageBox.Show("Seleccione un libro.")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String =
                "UPDATE libro SET titulo=@titulo, idioma=@idioma, formato=@formato, " &
                "edicion=@edicion, claveeditorial=@editorial " &
                "WHERE clavelibro=@id"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim())
                    cmd.Parameters.AddWithValue("@idioma", txtIdioma.Text.Trim())
                    cmd.Parameters.AddWithValue("@formato", txtFormato.Text.Trim())
                    cmd.Parameters.AddWithValue("@edicion", CInt(nudEdicion.Value))
                    'guardo la clave editorial
                    cmd.Parameters.AddWithValue("@editorial", CInt(cboEditorial.SelectedValue))
                    cmd.Parameters.AddWithValue("@id", CInt(txtIdLibro.Text))
                    'capturo respuesta del servidor
                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registros modificados: " & resultado.ToString())
                End Using
            End Using
            CargarGrilla()
            LimpiarForm()
        Catch ex As Exception
            MessageBox.Show("Error al modificar libro: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAutoresTemas_Click(sender As Object, e As EventArgs) Handles btnAutoresTemas.Click
        If txtIdLibro.Text = "" Then
            MessageBox.Show("Seleccione un libro.")
            Exit Sub
        End If

        'seleccione un libro paso los valores al form
        formLibrosAutorTema.idLibroSelec = CInt(txtIdLibro.Text)
        formLibrosAutorTema.TituloLibroSelec = txtTitulo.Text.ToString

        'llamo al form
        formLibrosAutorTema.ShowDialog()

    End Sub

    Private Sub btnBuscarImagen_Click(sender As Object, e As EventArgs) Handles btnBuscarImagen.Click
        'llamamos al opendialog para buscar imagenes
        Using dlg As New OpenFileDialog()
            'limitamos la busqueda
            dlg.Filter = "Imgenes|*.jpg;*.jpeg;*.png;*.bmp"

            'creo una copia temporal de la imagen en memoria
            'luego la paso al picture box
            If dlg.ShowDialog() = DialogResult.OK Then
                Using temporal As Image = Image.FromFile(dlg.FileName)
                    picPortada.Image = New Bitmap(temporal)
                End Using
            End If
        End Using
    End Sub

    Private Sub btnGuardarImagen_Click(sender As Object, e As EventArgs) Handles btnGuardarImagen.Click
        'valido libro
        If txtIdLibro.Text = "" Then
            Exit Sub
        End If

        'conversion de la imagen usando la funcion
        Dim datos() As Byte = ImagenaBytes(picPortada.Image)

        'valido el tamaño de la imagen
        If datos.Length > 1000000 Then
            MessageBox.Show("la imagen no puede superar 1 MB")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'actualizo el registro del libro seleccionado
                Dim sql = "UPDATE libro SET portada=@portada WHERE clavelibro=@idlibro;"

                Using cmd As New MySqlCommand(sql, cn)
                    'valido la imagen
                    If datos Is Nothing Then
                        cmd.Parameters.AddWithValue("@portada", DBNull.Value)
                    Else
                        'si tengo una imagen convertida a bytes
                        cmd.Parameters.AddWithValue("@portada", MySqlDbType.LongBlob).Value = datos
                    End If
                    cmd.Parameters.AddWithValue("@idlibro", CInt(txtIdLibro.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("portada guardada")
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message)
        End Try

    End Sub

    Private Sub btnQuitarImagen_Click(sender As Object, e As EventArgs) Handles btnQuitarImagen.Click

    End Sub
End Class