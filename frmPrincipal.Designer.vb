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
        btnUsuarios = New Button()
        lblUsuario = New Label()
        btnCerrarSesion = New Button()
        btnSalir = New Button()
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
        lblCantLibros.Location = New Point(660, 279)
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
        ' btnUsuarios
        ' 
        btnUsuarios.Location = New Point(61, 93)
        btnUsuarios.Margin = New Padding(3, 4, 3, 4)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(187, 107)
        btnUsuarios.TabIndex = 5
        btnUsuarios.Text = "USUARIOS"
        btnUsuarios.UseVisualStyleBackColor = True
        btnUsuarios.Visible = False
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsuario.Location = New Point(94, 9)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(131, 32)
        lblUsuario.TabIndex = 6
        lblUsuario.Text = "lblUsuario"
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Location = New Point(675, 22)
        btnCerrarSesion.Margin = New Padding(3, 4, 3, 4)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(206, 32)
        btnCerrarSesion.TabIndex = 7
        btnCerrarSesion.Text = "CERRAR SESION"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(552, 22)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(117, 32)
        btnSalir.TabIndex = 8
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        ControlBox = False
        Controls.Add(btnSalir)
        Controls.Add(btnCerrarSesion)
        Controls.Add(lblUsuario)
        Controls.Add(btnUsuarios)
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
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnSalir As Button

End Class
