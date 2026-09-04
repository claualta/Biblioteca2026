Imports MySqlConnector

Public Class frmEditoriales

    Sub CargarEditoriales()
        'creo subrutina para cargar grilla
        Try
            'voy a conectar a la bd para cargar la grilla
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                Dim consulta As String = "SELECT * FROM editorial ORDER BY nombre;"

                Using cmd As New MySqlCommand(consulta, cn)
                    'uso datatable para guardar un select 
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    'cargar la tabla en la grilla
                    dgvEditorial.DataSource = tabla

                End Using

            End Using
        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("Error al cargar las editoriales: " & ex.Message)
        End Try
    End Sub

    Sub LimpiarFormu()
        'limpio los campos del formulario
        txtNombre.Clear()
        txtDirecion.Clear()
        txtTelefono.Clear()
    End Sub

    Private Sub frmEditoriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargo la grilla de editoriales al cargar el formulario
        CargarEditoriales()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'guardo nuevos registros

        'valido los campos obligatorio
        If txtNombre.Text.Trim = "" Then
            MessageBox.Show("Falta el Nombre")
            txtNombre.Focus()
            Exit Sub
        End If

        'conectamos a la DB para carga
        Try
            'voy a conectar a la bd para cargar la grilla
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                Dim consulta As String = "INSERT INTO editorial (nombre,direccion,telefono)" &
                                         " VALUES (@nombre,@direccion,@telefono);"

                Using cmd As New MySqlCommand(consulta, cn)

                    'cargo valores en los parametros
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim)
                    cmd.Parameters.AddWithValue("@direccion", txtDirecion.Text.Trim)
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim)

                    'llamo a ejecutar la consulta 
                    'obtengo el resultado de los registros afectados
                    Dim Resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registros agregados: " & Resultado)
                End Using
            End Using

            LimpiarFormu()
            CargarEditoriales()

        Catch ex As Exception
            'mensage de error
            MessageBox.Show("Error al guardar " & ex.Message)
        End Try


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'valido que haya seleccionado una fila en la grilla
        If dgvEditorial.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una fila para modificar")
            Exit Sub
        End If

        If txtID.Text.Trim = "" Then
            MessageBox.Show("Debe seleccionar una fila para modificar")
            Exit Sub
        End If

        'ahora modifico el registro seleccionado
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                'uso update para modificar registros, y where para indicar que registro modificar
                Dim consulta As String = "UPDATE editorial SET nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE claveeditorial=@id"
                Using cmd As New MySqlCommand(consulta, cn)
                    'uso parametros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim)
                    cmd.Parameters.AddWithValue("@direccion", txtDirecion.Text.Trim)
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim)
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim)
                    'cmd.Parameters.AddWithValue("@id", dgvEditorial.Rows(dgvEditorial.SelectedRows(0).Index).Cells("claveeditorial").Value)
                    'llamo a ejecutar la consulta
                    'usi resultado para obtener la cantidad de registros afectados
                    Dim Resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registros actualizados: " & Resultado)
                End Using
            End Using

            LimpiarFormu()
            CargarEditoriales()

        Catch ex As Exception
            MessageBox.Show("Error al modificar " & ex.Message)
        End Try

    End Sub

    Private Sub dgvEditorial_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEditorial.CellContentClick

    End Sub

    Private Sub dgvEditorial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEditorial.CellClick
        'voy a traer los datos de cada fila seleccionada a los textbox
        'si e.rowindex es mayor o igual a 0, significa que se hizo click en una fila valida
        If e.RowIndex >= 0 Then
            txtID.Text = dgvEditorial.Rows(e.RowIndex).Cells("claveeditorial").Value.ToString()
            txtNombre.Text = dgvEditorial.Rows(e.RowIndex).Cells("nombre").Value.ToString()
            txtDirecion.Text = dgvEditorial.Rows(e.RowIndex).Cells("direccion").Value.ToString()
            txtTelefono.Text = dgvEditorial.Rows(e.RowIndex).Cells("telefono").Value.ToString()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'valido que haya seleccionado una fila en la grilla
        If dgvEditorial.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar una fila para modificar")
            Exit Sub
        End If

        If txtID.Text.Trim = "" Then
            MessageBox.Show("Debe seleccionar una fila para modificar")
            Exit Sub
        End If

        'voy a eliminar el registro seleccionado
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'armo mi consulta sql
                Dim consulta As String = "DELETE FROM editorial WHERE claveeditorial=@id"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim)
                    Dim Resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registros eliminados: " & Resultado)
                End Using
            End Using

            LimpiarFormu()
            CargarEditoriales()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar " & ex.Message)
        End Try

    End Sub
End Class