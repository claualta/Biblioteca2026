<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibros
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
        txtFiltro = New TextBox()
        Label1 = New Label()
        btnBuscar = New Button()
        btnRefrescar = New Button()
        dgvLibros = New DataGridView()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(116, 30)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(225, 27)
        txtFiltro.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 1
        Label1.Text = "Libro"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(362, 30)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(106, 29)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnRefrescar
        ' 
        btnRefrescar.Location = New Point(487, 28)
        btnRefrescar.Name = "btnRefrescar"
        btnRefrescar.Size = New Size(106, 29)
        btnRefrescar.TabIndex = 3
        btnRefrescar.Text = "REFRESCAR"
        btnRefrescar.UseVisualStyleBackColor = True
        ' 
        ' dgvLibros
        ' 
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(16, 83)
        dgvLibros.MultiSelect = False
        dgvLibros.Name = "dgvLibros"
        dgvLibros.ReadOnly = True
        dgvLibros.RowHeadersWidth = 51
        dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLibros.Size = New Size(841, 454)
        dgvLibros.TabIndex = 4
        ' 
        ' frmLibros
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(dgvLibros)
        Controls.Add(btnRefrescar)
        Controls.Add(btnBuscar)
        Controls.Add(Label1)
        Controls.Add(txtFiltro)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmLibros"
        Text = "Libros"
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents dgvLibros As DataGridView
End Class
