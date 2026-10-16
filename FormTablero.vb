Imports MySqlConnector
Imports ScottPlot
Public Class FormTablero

    Sub GraficoBarras()
        'traemos datos de la BD
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "SELECT e.nombre, COUNT(l.clavelibro) AS cantidad " &
                    "FROM editorial e " &
                    "JOIN libro l ON e.claveeditorial = l.claveeditorial " &
                    "GROUP BY e.nombre " &
                    "ORDER BY e.nombre;"

                Using cmd As New MySqlCommand(sql, cn)
                    'creamos dos listas para cargar los datos de la BD
                    Dim cantidades As New List(Of Double)
                    Dim nombres As New List(Of String)

                    Using rd = cmd.ExecuteReader()
                        While rd.Read()
                            'cargamos los arreglos
                            nombres.Add(rd("nombre").ToString())
                            cantidades.Add(CDbl(rd("cantidad")))
                        End While
                    End Using
                    'limpiamos el grafico
                    FormsPlot1.Plot.Clear()
                    'creamos el grafico de barra
                    'debo convertir la lista a un arreglo
                    Dim barras = FormsPlot1.Plot.Add.Bars(cantidades.ToArray())

                    'definir colores para las barras
                    Dim colores() = {
                        ScottPlot.Colors.Blue,
                        ScottPlot.Colors.Green,
                        ScottPlot.Colors.Red,
                        ScottPlot.Colors.Yellow,
                        ScottPlot.Colors.Brown
                        }

                    'asignar los colores
                    For i As Integer = 0 To cantidades.Count - 1
                        Dim color As ScottPlot.Color = colores(i Mod colores.Length)
                        barras.Bars(i).FillColor = color

                        'creamos la referencia con el mismo color
                        FormsPlot1.Plot.Legend.ManualItems.Add(New ScottPlot.LegendItem With {.LabelText = nombres(i), .FillColor = color})

                    Next

                    'mostramos leyenda y definimos ubicacion
                    FormsPlot1.Plot.ShowLegend(ScottPlot.Edge.Bottom)
                    'orientacion horizontal
                    FormsPlot1.Plot.Legend.Orientation = ScottPlot.Orientation.Horizontal
                    'titulo
                    FormsPlot1.Plot.Title("Libros por Editorial")
                    'ocultamos la grilla
                    FormsPlot1.Plot.HideGrid()

                    'refresco
                    FormsPlot1.Refresh()
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try

    End Sub

    Sub GraficoTorta()
        'traemos datos de la BD
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "SELECT e.nombre, COUNT(l.clavelibro) AS cantidad " &
                    "FROM editorial e " &
                    "JOIN libro l ON e.claveeditorial = l.claveeditorial " &
                    "GROUP BY e.nombre " &
                    "ORDER BY e.nombre;"

                Using cmd As New MySqlCommand(sql, cn)
                    'conversion de la lista
                    Dim porciones As New List(Of ScottPlot.PieSlice)

                    'definimos los colores
                    'definir colores para las barras
                    Dim colores() = {
                        ScottPlot.Colors.Blue,
                        ScottPlot.Colors.Green,
                        ScottPlot.Colors.Red,
                        ScottPlot.Colors.Yellow,
                        ScottPlot.Colors.Brown
                        }

                    Dim indice As Integer = 0

                    'limpiamos
                    FormsPlot2.Plot.Clear()

                    Using rd = cmd.ExecuteReader()
                        While rd.Read()
                            'cargamos los arreglos
                            Dim nombre As String = rd("nombre").ToString
                            Dim cantidad As Double = CDbl(rd("cantidad"))

                            'evitar porciones valor cero
                            If cantidad > 0 Then
                                'creamos porcion en el grafico
                                Dim porcion As New ScottPlot.PieSlice
                                'asignamos el valor
                                porcion.Value = cantidad
                                'etiqueta
                                porcion.Label = cantidad
                                'etiqueta de la leyenda
                                porcion.LegendText = nombre
                                'negrita
                                porcion.LabelBold = True
                                'color de la etiqueta
                                porcion.FillColor = colores(indice Mod colores.Length)

                                'agregar la porcion a la lista
                                porciones.Add(porcion)

                                indice += 1
                            End If

                        End While
                    End Using

                    'creo grafico
                    Dim torta = FormsPlot2.Plot.Add.Pie(porciones)
                    'separar porciones
                    torta.ExplodeFraction = 0.1
                    'etiqueta
                    torta.SliceLabelDistance = 0.6

                    'titulo
                    FormsPlot2.Plot.Title("Libros por Editoriales")
                    'ocultamos grilla y los ejes
                    FormsPlot2.Plot.HideAxesAndGrid()
                    'refresco
                    FormsPlot2.Refresh()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub
    Sub CargarGrafico()
        'declarar una variable tipo arreglo DOUBLE
        Dim cantidades() As Double = {5, 8, 10, 12, 4, 6}

        'limpiar mi grafico
        FormsPlot1.Plot.Clear()

        ' cargo con los datos
        'grafico de barra
        'FormsPlot1.Plot.Add.Bars(cantidades)

        'grafico torta
        'FormsPlot1.Plot.Add.Pie(cantidades)

        FormsPlot1.Plot.Add.RadialGaugePlot(cantidades)
        'refresco del grafico
        FormsPlot1.Refresh()

    End Sub
    Private Sub FormTablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CargarGrafico()
        GraficoBarras()
        GraficoTorta()
    End Sub
End Class