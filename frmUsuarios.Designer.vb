<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Label3 = New Label()
        Label4 = New Label()
        txtNombre = New TextBox()
        txtUsuario = New TextBox()
        txtClave = New TextBox()
        cmbRol = New ComboBox()
        btnAgregarUsuario = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 1
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 2
        Label3.Text = "Clave"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 20)
        Label4.TabIndex = 3
        Label4.Text = "Rol"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(114, 41)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(297, 27)
        txtNombre.TabIndex = 4
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(114, 106)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(297, 27)
        txtUsuario.TabIndex = 5
        ' 
        ' txtClave
        ' 
        txtClave.Location = New Point(123, 181)
        txtClave.Name = "txtClave"
        txtClave.Size = New Size(297, 27)
        txtClave.TabIndex = 6
        ' 
        ' cmbRol
        ' 
        cmbRol.FormattingEnabled = True
        cmbRol.Location = New Point(114, 258)
        cmbRol.Name = "cmbRol"
        cmbRol.Size = New Size(320, 28)
        cmbRol.TabIndex = 7
        ' 
        ' btnAgregarUsuario
        ' 
        btnAgregarUsuario.Location = New Point(508, 100)
        btnAgregarUsuario.Name = "btnAgregarUsuario"
        btnAgregarUsuario.Size = New Size(192, 29)
        btnAgregarUsuario.TabIndex = 8
        btnAgregarUsuario.Text = "AGREGAR"
        btnAgregarUsuario.UseVisualStyleBackColor = True
        ' 
        ' frmUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(749, 320)
        Controls.Add(btnAgregarUsuario)
        Controls.Add(cmbRol)
        Controls.Add(txtClave)
        Controls.Add(txtUsuario)
        Controls.Add(txtNombre)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmUsuarios"
        Text = "frmUsuarios"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Private txtNombre As TextBox
    Private txtUsuario As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents btnAgregarUsuario As Button
    Friend WithEvents TextBox4 As TextBox
End Class
