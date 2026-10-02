<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Label1 = New Label()
        Label2 = New Label()
        txtUsuario = New TextBox()
        txtClave = New TextBox()
        btnIngresar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 0
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 1
        Label2.Text = "Clave"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(117, 52)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(328, 27)
        txtUsuario.TabIndex = 2
        ' 
        ' txtClave
        ' 
        txtClave.Location = New Point(117, 124)
        txtClave.Name = "txtClave"
        txtClave.Size = New Size(328, 27)
        txtClave.TabIndex = 3
        txtClave.UseSystemPasswordChar = True
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Location = New Point(117, 198)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(334, 29)
        btnIngresar.TabIndex = 4
        btnIngresar.Text = "INGRESAR"
        btnIngresar.TextAlign = ContentAlignment.TopCenter
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 255)
        Controls.Add(btnIngresar)
        Controls.Add(txtClave)
        Controls.Add(txtUsuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmLogin"
        Text = "frmLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents btnIngresar As Button
End Class
