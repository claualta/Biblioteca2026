<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLibrosAutorTema
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
        checklistAutores = New CheckedListBox()
        lblLibroSelec = New Label()
        Label2 = New Label()
        btnGuardarAutores = New Button()
        SuspendLayout()
        ' 
        ' checklistAutores
        ' 
        checklistAutores.FormattingEnabled = True
        checklistAutores.Location = New Point(37, 95)
        checklistAutores.Name = "checklistAutores"
        checklistAutores.Size = New Size(252, 268)
        checklistAutores.TabIndex = 0
        ' 
        ' lblLibroSelec
        ' 
        lblLibroSelec.AutoSize = True
        lblLibroSelec.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblLibroSelec.Location = New Point(37, 18)
        lblLibroSelec.Name = "lblLibroSelec"
        lblLibroSelec.Size = New Size(86, 31)
        lblLibroSelec.TabIndex = 1
        lblLibroSelec.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 2
        Label2.Text = "AUTORES"
        ' 
        ' btnGuardarAutores
        ' 
        btnGuardarAutores.Location = New Point(58, 386)
        btnGuardarAutores.Name = "btnGuardarAutores"
        btnGuardarAutores.Size = New Size(200, 45)
        btnGuardarAutores.TabIndex = 3
        btnGuardarAutores.Text = "GUARDAR AUTORES"
        btnGuardarAutores.UseVisualStyleBackColor = True
        ' 
        ' formLibrosAutorTema
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGuardarAutores)
        Controls.Add(Label2)
        Controls.Add(lblLibroSelec)
        Controls.Add(checklistAutores)
        Name = "formLibrosAutorTema"
        Text = "Libros - Autores y Temas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents checklistAutores As CheckedListBox
    Friend WithEvents lblLibroSelec As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardarAutores As Button
End Class
