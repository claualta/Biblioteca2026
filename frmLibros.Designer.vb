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
        btnAutoresTemas = New Button()
        picPortada = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        btnBuscarImagen = New Button()
        btnGuardarImagen = New Button()
        btnQuitarImagen = New Button()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudEdicion, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPortada, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(117, 29)
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
        btnBuscar.Location = New Point(362, 29)
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
        dgvLibros.Size = New Size(822, 335)
        dgvLibros.TabIndex = 4
        ' 
        ' txtIdLibro
        ' 
        txtIdLibro.Location = New Point(123, 443)
        txtIdLibro.Margin = New Padding(3, 4, 3, 4)
        txtIdLibro.Name = "txtIdLibro"
        txtIdLibro.ReadOnly = True
        txtIdLibro.Size = New Size(59, 27)
        txtIdLibro.TabIndex = 5
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(123, 481)
        txtTitulo.Margin = New Padding(3, 4, 3, 4)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(486, 27)
        txtTitulo.TabIndex = 6
        ' 
        ' txtIdioma
        ' 
        txtIdioma.Location = New Point(123, 520)
        txtIdioma.Margin = New Padding(3, 4, 3, 4)
        txtIdioma.Name = "txtIdioma"
        txtIdioma.Size = New Size(161, 27)
        txtIdioma.TabIndex = 7
        ' 
        ' txtFormato
        ' 
        txtFormato.Location = New Point(123, 559)
        txtFormato.Margin = New Padding(3, 4, 3, 4)
        txtFormato.Name = "txtFormato"
        txtFormato.Size = New Size(161, 27)
        txtFormato.TabIndex = 8
        ' 
        ' nudEdicion
        ' 
        nudEdicion.Location = New Point(123, 597)
        nudEdicion.Margin = New Padding(3, 4, 3, 4)
        nudEdicion.Name = "nudEdicion"
        nudEdicion.Size = New Size(74, 27)
        nudEdicion.TabIndex = 9
        ' 
        ' cboEditorial
        ' 
        cboEditorial.DropDownStyle = ComboBoxStyle.DropDownList
        cboEditorial.FormattingEnabled = True
        cboEditorial.Location = New Point(125, 639)
        cboEditorial.Margin = New Padding(3, 4, 3, 4)
        cboEditorial.Name = "cboEditorial"
        cboEditorial.Size = New Size(485, 28)
        cboEditorial.TabIndex = 10
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(655, 435)
        btnGuardar.Margin = New Padding(3, 4, 3, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(118, 44)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(655, 487)
        btnModificar.Margin = New Padding(3, 4, 3, 4)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(118, 44)
        btnModificar.TabIndex = 12
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(655, 539)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(118, 44)
        btnEliminar.TabIndex = 13
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 447)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 14
        Label2.Text = "ID Libro"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 487)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 15
        Label3.Text = "Titulo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(66, 524)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 20)
        Label4.TabIndex = 16
        Label4.Text = "Idioma"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(57, 563)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 17
        Label5.Text = "Formato"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(64, 600)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 20)
        Label6.TabIndex = 18
        Label6.Text = "Edicion"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(61, 643)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 20)
        Label7.TabIndex = 19
        Label7.Text = "Editorial"
        ' 
        ' btnAutoresTemas
        ' 
        btnAutoresTemas.Location = New Point(655, 597)
        btnAutoresTemas.Margin = New Padding(3, 4, 3, 4)
        btnAutoresTemas.Name = "btnAutoresTemas"
        btnAutoresTemas.Size = New Size(118, 66)
        btnAutoresTemas.TabIndex = 20
        btnAutoresTemas.Text = "AUTORES Y TEMAS"
        btnAutoresTemas.UseVisualStyleBackColor = True
        ' 
        ' picPortada
        ' 
        picPortada.BackColor = SystemColors.ActiveCaption
        picPortada.Location = New Point(844, 83)
        picPortada.Name = "picPortada"
        picPortada.Size = New Size(332, 335)
        picPortada.SizeMode = PictureBoxSizeMode.Zoom
        picPortada.TabIndex = 21
        picPortada.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' btnBuscarImagen
        ' 
        btnBuscarImagen.Location = New Point(844, 435)
        btnBuscarImagen.Margin = New Padding(3, 4, 3, 4)
        btnBuscarImagen.Name = "btnBuscarImagen"
        btnBuscarImagen.Size = New Size(332, 32)
        btnBuscarImagen.TabIndex = 22
        btnBuscarImagen.Text = "BUSCAR PORTADA"
        btnBuscarImagen.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarImagen
        ' 
        btnGuardarImagen.Location = New Point(844, 478)
        btnGuardarImagen.Margin = New Padding(3, 4, 3, 4)
        btnGuardarImagen.Name = "btnGuardarImagen"
        btnGuardarImagen.Size = New Size(332, 32)
        btnGuardarImagen.TabIndex = 23
        btnGuardarImagen.Text = "GUARDAR PORTADA"
        btnGuardarImagen.UseVisualStyleBackColor = True
        ' 
        ' btnQuitarImagen
        ' 
        btnQuitarImagen.Location = New Point(844, 518)
        btnQuitarImagen.Margin = New Padding(3, 4, 3, 4)
        btnQuitarImagen.Name = "btnQuitarImagen"
        btnQuitarImagen.Size = New Size(332, 32)
        btnQuitarImagen.TabIndex = 24
        btnQuitarImagen.Text = "QUITAR PORTADA"
        btnQuitarImagen.UseVisualStyleBackColor = True
        ' 
        ' frmLibros
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1198, 693)
        Controls.Add(btnQuitarImagen)
        Controls.Add(btnGuardarImagen)
        Controls.Add(btnBuscarImagen)
        Controls.Add(picPortada)
        Controls.Add(btnAutoresTemas)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmLibros"
        Text = "Libros"
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        CType(nudEdicion, ComponentModel.ISupportInitialize).EndInit()
        CType(picPortada, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAutoresTemas As Button
    Friend WithEvents picPortada As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnBuscarImagen As Button
    Friend WithEvents btnGuardarImagen As Button
    Friend WithEvents btnQuitarImagen As Button
End Class
