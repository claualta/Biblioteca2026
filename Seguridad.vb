'la clase Seguridad contiene funciones para encriptar y desencriptar contraseñas,
'asi como para generar un hash de una contraseña
Imports System.Security.Cryptography

Module Seguridad

    Public Function CrearSalt() As String
        ' Crea un salt aleatorio de 16 bytes y lo devuelve como una cadena Base64

        ' se genera un salt aleatorio de 16 bytes
        ' cada usuario debe tener un salt diferente
        ' la funcion randomnumbergenerator.getbytes genera un arreglo de bytes aleatorio

        Dim saltBytes() As Byte = RandomNumberGenerator.GetBytes(16)
        'convierte el arreglo de bytes a una cadena Base64 para almacenarlo en la base de datos
        Return Convert.ToBase64String(saltBytes)
    End Function

    Public Function CrearHash(clave As String, saltTexto As String) As String

        'funcion para crear el hash de una contraseña usando SHA256 y un salt   

        'recupero los bytes del salt que se guardo en la base de datos
        Dim saltBytes() As Byte = Convert.FromBase64String(saltTexto)

        Dim Resultado() As Byte = Rfc2898DeriveBytes.Pbkdf2(clave, saltBytes, 10000, HashAlgorithmName.SHA256, 32)

        'convierte el hash a una cadena Base64 para almacenarlo en la base de datos
        'resultado me devuelve un arreglo de bytes que representa el hash de la contraseña
        Return Convert.ToBase64String(Resultado)
    End Function

End Module
