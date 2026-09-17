Imports MySqlConnector
Public Class formLibrosAutorTema

    'declaro variables publicas
    Public idLibroSelec As Integer
    Public TituloLibroSelec As String

    Sub cargarCheckListAutores()
        'cargo la lista de todos los autores de la tabla autor
        'vacio el datasource y luego limpio el checklist
        checklistAutores.DataSource = Nothing
        checklistAutores.Items.Clear()

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'traigo todos los autores}
                Dim sql As String = "SELECT * FROM autor ORDER BY nombre;"
                Using cmd As New MySqlCommand(sql, cn)

                    'declaro objeto tabla
                    Dim tabla As New DataTable
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using

                    'paso la tabla al checklist
                    checklistAutores.DataSource = tabla
                    'defino que muestro en el checklist
                    checklistAutores.DisplayMember = "nombre"
                    checklistAutores.ValueMember = "claveautor"

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("ERROR! " & ex.Message)
        End Try

    End Sub

    Sub MarcarAutores()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                'traigo los autores filtrados por libro
                Dim sql As String = "SELECT * FROM escrito_por WHERE clavelibro = @clavelibro;"

                Using cmd As New MySqlCommand(sql, cn)
                    'cargamos libro
                    cmd.Parameters.AddWithValue("@clavelibro", idLibroSelec)
                    'usamos un datareader
                    Using rd As MySqlDataReader = cmd.ExecuteReader
                        'recorro el datareader con el metodo read
                        While rd.Read()
                            Dim idAutor As Integer = CInt(rd("claveautor"))
                            'recorro el checklist con un for
                            For i As Integer = 0 To checklistAutores.Items.Count - 1
                                'debo obtener los elementos de cada fila
                                Dim fila As DataRowView = DirectCast(checklistAutores.Items(i), DataRowView)
                                'marco la fila si coincide
                                Dim clave As Integer = CInt(fila("claveautor"))
                                If clave = idAutor Then
                                    checklistAutores.SetItemChecked(i, True)
                                End If
                            Next
                        End While

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("ERROR! " & ex.Message)
        End Try
    End Sub

    Private Sub formLibrosAutorTema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'muestro libro seleccionado
        lblLibroSelec.Text = "Libro: " & TituloLibroSelec
        'cargo lista de autores
        cargarCheckListAutores()
        'marco autores
        MarcarAutores()
    End Sub

    Private Sub btnGuardarAutores_Click(sender As Object, e As EventArgs) Handles btnGuardarAutores.Click
        Try
            Using cn As New MySqlConnection(CADENA)
                'conecto la BD
                cn.Open()
                'voy a iniciar una transaccion
                Using tx = cn.BeginTransaction
                    'PASO 1: eliminar relaciones existentes en la tabla
                    Dim sqlborrar As String = "DELETE FROM escrito_por WHERE clavelibro=@clavelibro"
                    'en este command agrego el argunto de referencia a la transaccion
                    Using cmdborrar As New MySqlCommand(sqlborrar, cn, tx)
                        cmdborrar.Parameters.AddWithValue("@clavelibro", idLibroSelec)
                        cmdborrar.ExecuteNonQuery()
                    End Using

                    'PASO 2: crear las nuevas relaciones
                    'recorremos el checklist
                    For Each item As DataRowView In checklistAutores.CheckedItems
                        'obtengo la clave del autor seleccionado
                        Dim idautor As Integer = CInt(item("claveautor"))
                        'insert del autor 
                        Dim sqlinsetar As String = "INSERT INTO escrito_por (clavelibro,claveautor) " &
                            "VALUES (@clavelibro,@claveautor);"

                        Using cmdinsertar As New MySqlCommand(sqlinsetar, cn, tx)
                            'cargo parametros
                            cmdinsertar.Parameters.AddWithValue("@clavelibro", idLibroSelec)
                            cmdinsertar.Parameters.AddWithValue("@claveautor", idautor)
                            'ejecuto la consulta
                            cmdinsertar.ExecuteNonQuery()
                        End Using

                    Next
                    'si no se produjeron errores puedo cerrar la transaccion
                    tx.Commit()
                End Using
            End Using
            'mostrar mensaje de exito1
            MessageBox.Show("Fue exito capo!!")
        Catch ex As Exception
            MessageBox.Show("ERROR! " & ex.Message)
        End Try

    End Sub
End Class