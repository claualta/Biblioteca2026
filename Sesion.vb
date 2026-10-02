Module Sesion
    'permite identificar al usuario que esta logueado en el sistema

    'variable publica que almacena el id del usuario logueado
    Public idUsuario As Integer = 0

    'variable publica que almacena el nombre del usuario logueado
    Public nombreUsuario As String = ""

    'variable publica que almacena el rol del usuario logueado
    Public rolUsuario As String = ""

    'variable publica con nombre completo del usuario logueado
    Public NombreCompleto As String = ""

    'rutina para restear las variables de sesion al cerrar la sesion
    Public Sub CerrarSesion()
        idUsuario = 0
        nombreUsuario = ""
        rolUsuario = ""
        NombreCompleto = ""
    End Sub

End Module
