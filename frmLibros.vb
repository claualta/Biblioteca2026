Imports MySqlConnector

Public Class frmLibros

    Sub CargarGrilla(Optional filtro As String = "")
        'creo subrutina para cargar grilla
        Try
            'conectamo a la bd
            Using cn As New MySqlConnection(CADENA)

                cn.Open()

                'armo mi consulta sql
                Dim consulta As String

                'aplico filtro
                If filtro = "" Then
                    consulta = "SELECT * FROM libro " &
                            " ORDER BY titulo;"
                Else
                    consulta = "SELECT * FROM libro " &
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

                End Using

            End Using

        Catch ex As Exception
            'muestro mensaje de error
            MessageBox.Show("ERROR: " & ex.Message)
        End Try

    End Sub

    Private Sub frmLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargo la grilla sin filtrar
        CargarGrilla()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'llamo a cargargrilla con filtro
        CargarGrilla(txtFiltro.Text.Trim)

    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        'llamo a cargargrilla con filtro
        CargarGrilla(txtFiltro.Text.Trim)
    End Sub
End Class