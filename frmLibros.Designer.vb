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
        txtIdLibro = New TextBox()
        txtTitulo = New TextBox()
        txtIdioma = New TextBox()
        txtFormato = New TextBox()
        nudEdicion = New NumericUpDown()
        cboEditorial = New ComboBox()
        btnGuardar = New Button()
        btnModificar = New Button()
        btnEliminar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudEdicion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(102, 22)
        txtFiltro.Margin = New Padding(3, 2, 3, 2)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(197, 23)
        txtFiltro.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 1
        Label1.Text = "Libro"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(317, 22)
        btnBuscar.Margin = New Padding(3, 2, 3, 2)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(93, 22)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnRefrescar
        ' 
        btnRefrescar.Location = New Point(426, 21)
        btnRefrescar.Margin = New Padding(3, 2, 3, 2)
        btnRefrescar.Name = "btnRefrescar"
        btnRefrescar.Size = New Size(93, 22)
        btnRefrescar.TabIndex = 3
        btnRefrescar.Text = "REFRESCAR"
        btnRefrescar.UseVisualStyleBackColor = True
        ' 
        ' dgvLibros
        ' 
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(14, 62)
        dgvLibros.Margin = New Padding(3, 2, 3, 2)
        dgvLibros.MultiSelect = False
        dgvLibros.Name = "dgvLibros"
        dgvLibros.ReadOnly = True
        dgvLibros.RowHeadersWidth = 51
        dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLibros.Size = New Size(866, 251)
        dgvLibros.TabIndex = 4
        ' 
        ' txtIdLibro
        ' 
        txtIdLibro.Location = New Point(108, 332)
        txtIdLibro.Name = "txtIdLibro"
        txtIdLibro.ReadOnly = True
        txtIdLibro.Size = New Size(52, 23)
        txtIdLibro.TabIndex = 5
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(108, 361)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(426, 23)
        txtTitulo.TabIndex = 6
        ' 
        ' txtIdioma
        ' 
        txtIdioma.Location = New Point(108, 390)
        txtIdioma.Name = "txtIdioma"
        txtIdioma.Size = New Size(141, 23)
        txtIdioma.TabIndex = 7
        ' 
        ' txtFormato
        ' 
        txtFormato.Location = New Point(108, 419)
        txtFormato.Name = "txtFormato"
        txtFormato.Size = New Size(141, 23)
        txtFormato.TabIndex = 8
        ' 
        ' nudEdicion
        ' 
        nudEdicion.Location = New Point(108, 448)
        nudEdicion.Name = "nudEdicion"
        nudEdicion.Size = New Size(65, 23)
        nudEdicion.TabIndex = 9
        ' 
        ' cboEditorial
        ' 
        cboEditorial.DropDownStyle = ComboBoxStyle.DropDownList
        cboEditorial.FormattingEnabled = True
        cboEditorial.Location = New Point(109, 479)
        cboEditorial.Name = "cboEditorial"
        cboEditorial.Size = New Size(425, 23)
        cboEditorial.TabIndex = 10
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(573, 326)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(103, 33)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(573, 365)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(103, 33)
        btnModificar.TabIndex = 12
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(573, 404)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(103, 33)
        btnEliminar.TabIndex = 13
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 335)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 15)
        Label2.TabIndex = 14
        Label2.Text = "ID Libro"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 365)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 15
        Label3.Text = "Titulo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 393)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 16
        Label4.Text = "Idioma"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 422)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 17
        Label5.Text = "Formato"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(56, 450)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 15)
        Label6.TabIndex = 18
        Label6.Text = "Edicion"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 482)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 15)
        Label7.TabIndex = 19
        Label7.Text = "Editorial"
        ' 
        ' frmLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(905, 520)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnGuardar)
        Controls.Add(cboEditorial)
        Controls.Add(nudEdicion)
        Controls.Add(txtFormato)
        Controls.Add(txtIdioma)
        Controls.Add(txtTitulo)
        Controls.Add(txtIdLibro)
        Controls.Add(dgvLibros)
        Controls.Add(btnRefrescar)
        Controls.Add(btnBuscar)
        Controls.Add(Label1)
        Controls.Add(txtFiltro)
        Name = "frmLibros"
        Text = "Libros"
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        CType(nudEdicion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents txtIdLibro As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtIdioma As TextBox
    Friend WithEvents txtFormato As TextBox
    Friend WithEvents nudEdicion As NumericUpDown
    Friend WithEvents cboEditorial As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
