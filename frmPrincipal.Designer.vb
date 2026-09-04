<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnProbarConexion = New Button()
        btnCantLibros = New Button()
        lblCantLibros = New Label()
        btnLibros = New Button()
        btnEditoriales = New Button()
        SuspendLayout()
        ' 
        ' btnProbarConexion
        ' 
        btnProbarConexion.Location = New Point(318, 93)
        btnProbarConexion.Margin = New Padding(3, 4, 3, 4)
        btnProbarConexion.Name = "btnProbarConexion"
        btnProbarConexion.Size = New Size(187, 107)
        btnProbarConexion.TabIndex = 0
        btnProbarConexion.Text = "CONECTAR BD"
        btnProbarConexion.UseVisualStyleBackColor = True
        ' 
        ' btnCantLibros
        ' 
        btnCantLibros.Location = New Point(318, 244)
        btnCantLibros.Margin = New Padding(3, 4, 3, 4)
        btnCantLibros.Name = "btnCantLibros"
        btnCantLibros.Size = New Size(187, 107)
        btnCantLibros.TabIndex = 1
        btnCantLibros.Text = "CANTIDAD LIBROS"
        btnCantLibros.UseVisualStyleBackColor = True
        ' 
        ' lblCantLibros
        ' 
        lblCantLibros.AutoSize = True
        lblCantLibros.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCantLibros.Location = New Point(671, 244)
        lblCantLibros.Name = "lblCantLibros"
        lblCantLibros.Size = New Size(88, 32)
        lblCantLibros.TabIndex = 2
        lblCantLibros.Text = "Label1"
        ' 
        ' btnLibros
        ' 
        btnLibros.Location = New Point(318, 405)
        btnLibros.Margin = New Padding(3, 4, 3, 4)
        btnLibros.Name = "btnLibros"
        btnLibros.Size = New Size(187, 107)
        btnLibros.TabIndex = 3
        btnLibros.Text = "LIBROS"
        btnLibros.UseVisualStyleBackColor = True
        ' 
        ' btnEditoriales
        ' 
        btnEditoriales.Location = New Point(613, 93)
        btnEditoriales.Margin = New Padding(3, 4, 3, 4)
        btnEditoriales.Name = "btnEditoriales"
        btnEditoriales.Size = New Size(187, 107)
        btnEditoriales.TabIndex = 4
        btnEditoriales.Text = "EDITORIALES"
        btnEditoriales.UseVisualStyleBackColor = True
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(btnEditoriales)
        Controls.Add(btnLibros)
        Controls.Add(lblCantLibros)
        Controls.Add(btnCantLibros)
        Controls.Add(btnProbarConexion)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmPrincipal"
        Text = "Principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnProbarConexion As Button
    Friend WithEvents btnCantLibros As Button
    Friend WithEvents lblCantLibros As Label
    Friend WithEvents btnLibros As Button
    Friend WithEvents btnEditoriales As Button

End Class
