'importo clase MySqlConnector
Imports MySqlConnector

Public Class frmPrincipal
    Private Sub btnProbarConexion_Click(sender As Object, e As EventArgs) Handles btnProbarConexion.Click
        'boton para probar conexion a BD
        'try catch intercepta errores
        Try
            'preparo la conexion, declaro el objeto de conexion
            Using CN As New MySqlConnection(CADENA)

                'metodo Open conecta a la BD
                CN.Open()

                MessageBox.Show("CONEXION EXITOSA!!")

            End Using

        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("ERROR: " & ex.Message)
        End Try


    End Sub

    Private Sub btnCantLibros_Click(sender As Object, e As EventArgs) Handles btnCantLibros.Click
        Try
            Using CN As New MySqlConnection(CADENA)
                'conecto con la BD
                CN.Open()

                'genero consulta SQL
                Dim CONSULTA As String = "SELECT COUNT(*) FROM LIBRO;"

                'uso el comando para ejecutar la consulta en el servidor
                'debo pasar SQL + CONEXION como argumento
                Using COMANDO As New MySqlCommand(CONSULTA, CN)

                    'declaro var para obtener resultado
                    Dim CANT As Integer = COMANDO.ExecuteScalar

                    lblCantLibros.Text = CANT.ToString

                End Using

            End Using
        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLibros_Click(sender As Object, e As EventArgs) Handles btnLibros.Click
        'llamo al form libros
        frmLibros.Show()

    End Sub

    Private Sub btnEditoriales_Click(sender As Object, e As EventArgs) Handles btnEditoriales.Click
        'llamo al form editoriales
        frmEditoriales.Show()

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmUsuarios.ShowDialog()

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = Sesion.NombreCompleto + " - " + Sesion.rolUsuario

        If Sesion.rolUsuario = "ADMIN" Then
            btnUsuarios.Visible = True
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        'cierro sesion y vuelvo al login
        Sesion.CerrarSesion()
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'cierro la aplicacion
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
