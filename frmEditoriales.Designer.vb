<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditoriales
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
        txtID = New TextBox()
        Label1 = New Label()
        txtNombre = New TextBox()
        txtDirecion = New TextBox()
        txtTelefono = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dgvEditorial = New DataGridView()
        btnGuardar = New Button()
        btnModificar = New Button()
        btnEliminar = New Button()
        CType(dgvEditorial, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(95, 27)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(76, 27)
        txtID.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 1
        Label1.Text = "ID"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(96, 74)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(293, 27)
        txtNombre.TabIndex = 2
        ' 
        ' txtDirecion
        ' 
        txtDirecion.Location = New Point(96, 118)
        txtDirecion.Name = "txtDirecion"
        txtDirecion.Size = New Size(518, 27)
        txtDirecion.TabIndex = 3
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(96, 160)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(293, 27)
        txtTelefono.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 5
        Label2.Text = "Editorial"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 6
        Label3.Text = "Direccion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 7
        Label4.Text = "Telefono"
        ' 
        ' dgvEditorial
        ' 
        dgvEditorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEditorial.Location = New Point(22, 222)
        dgvEditorial.MultiSelect = False
        dgvEditorial.Name = "dgvEditorial"
        dgvEditorial.ReadOnly = True
        dgvEditorial.RowHeadersWidth = 51
        dgvEditorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEditorial.Size = New Size(797, 206)
        dgvEditorial.TabIndex = 8
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(673, 48)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(134, 39)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(673, 106)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(134, 39)
        btnModificar.TabIndex = 10
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(673, 163)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(134, 39)
        btnEliminar.TabIndex = 11
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' frmEditoriales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(849, 450)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnGuardar)
        Controls.Add(dgvEditorial)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtTelefono)
        Controls.Add(txtDirecion)
        Controls.Add(txtNombre)
        Controls.Add(Label1)
        Controls.Add(txtID)
        Name = "frmEditoriales"
        Text = "E D I T O R I A L E S"
        CType(dgvEditorial, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDirecion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvEditorial As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
End Class
