<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTablero
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        FormsPlot1 = New ScottPlot.WinForms.FormsPlot()
        FormsPlot2 = New ScottPlot.WinForms.FormsPlot()
        SuspendLayout()
        ' 
        ' FormsPlot1
        ' 
        FormsPlot1.Location = New Point(12, 29)
        FormsPlot1.Name = "FormsPlot1"
        FormsPlot1.Size = New Size(668, 471)
        FormsPlot1.TabIndex = 0
        ' 
        ' FormsPlot2
        ' 
        FormsPlot2.Location = New Point(686, 29)
        FormsPlot2.Name = "FormsPlot2"
        FormsPlot2.Size = New Size(668, 471)
        FormsPlot2.TabIndex = 1
        ' 
        ' FormTablero
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1386, 562)
        Controls.Add(FormsPlot2)
        Controls.Add(FormsPlot1)
        Name = "FormTablero"
        Text = "T A B L E R O"
        ResumeLayout(False)
    End Sub

    Friend WithEvents FormsPlot1 As ScottPlot.WinForms.FormsPlot
    Friend WithEvents FormsPlot2 As ScottPlot.WinForms.FormsPlot
End Class
