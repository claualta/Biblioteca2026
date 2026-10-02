Imports MySqlConnector
Public Class frmUsuarios

    Sub CargarComborRol()
        'carga el combobox de roles desde la base de datos
        Try

            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "SELECT idrol, nombre FROM rol ORDER BY nombre"

                Using cmd As New MySqlCommand(sql, cn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable
                        dt.Load(dr)
                        cmbRol.DataSource = dt
                        cmbRol.DisplayMember = "nombre"
                        cmbRol.ValueMember = "idrol"
                    End Using
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComborRol()
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        ' validar que este cargado usuario y clave
        If txtNombre.Text = "" OrElse String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse String.IsNullOrWhiteSpace(txtClave.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' validar que el usuario no exista en la base de datos
        'creo un salt eleatorio para la contraseña
        Dim salt As String = Seguridad.CrearSalt()

        'creo el hash de la contraseña usando el salt
        Dim hash As String = Seguridad.CrearHash(txtClave.Text.Trim(), salt)

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "INSERT INTO usuario (nombrecompleto, nombreusuario, clavehash, salt, idRol) " &
                                    "VALUES (@nombre, @usuario, @clave, @salt, @idRol)"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim())
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim())
                    cmd.Parameters.AddWithValue("@clave", hash)
                    cmd.Parameters.AddWithValue("@salt", salt)
                    cmd.Parameters.AddWithValue("@idRol", cmbRol.SelectedValue)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    'si rowsAffected es mayor a 0, significa que se agrego el usuario correctamente
                    'sino, significa que hubo un error al agregar el usuario
                    'If rowsAffected > 0 Then
                    '    MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    ' Limpiar los campos después de agregar el usuario
                    '    txtNombre.Clear()
                    '    txtUsuario.Clear()
                    '    txtClave.Clear()
                    '    cmbRol.SelectedIndex = -1
                    'Else
                    '    MessageBox.Show("No se pudo agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class