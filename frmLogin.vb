Imports MySqlConnector

Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'validar ingreso de datos
        If txtUsuario.Text = "" OrElse txtClave.Text = "" Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                'traemos datos del usuario desde la base de datos
                Dim sql As String = "SELECT  usr.idusuario,usr.nombreusuario,usr.nombrecompleto,usr.clavehash,usr.salt, usr.idrol,rol.nombre as roles
FROM usuario AS usr
JOIN rol ON usr.idrol = rol.idrol
WHERE usr.nombreusuario = @usuario AND usr.activo=TRUE;"

                Using cmd As New MySqlCommand(sql, cn)
                    'traemos nombre usuario
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim())

                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        'si rd tiene filas, significa que el usuario existe
                        If Not rd.Read Then
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        ' leer el hash y el salt de la base de datos
                        Dim hashBD As String = rd("clavehash").ToString()
                        Dim saltBD As String = rd("salt").ToString()

                        'crear hash de la contraseña ingresada usando el salt de la base de datos
                        Dim hashIngresado As String = Seguridad.CrearHash(txtClave.Text.Trim(), saltBD)

                        'comparo los hashes
                        If hashIngresado <> hashBD Then
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If

                        'si los hashes coinciden, el usuario es autenticado correctamente
                        'cargo las variables de sesion
                        Sesion.idUsuario = Convert.ToInt32(rd("idusuario"))
                        Sesion.nombreUsuario = rd("nombreusuario").ToString()
                        Sesion.rolUsuario = rd("roles").ToString()
                        Sesion.NombreCompleto = rd("nombrecompleto").ToString()

                        'muestro el formulario principal
                        frmPrincipal.Show()
                        Me.Hide()
                    End Using

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al intentar iniciar sesión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class