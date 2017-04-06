<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgdResults = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.rbtCodigo = New System.Windows.Forms.RadioButton()
        Me.rbtNome = New System.Windows.Forms.RadioButton()
        Me.btnImp = New System.Windows.Forms.Button()
        CType(Me.dgdResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgdResults
        '
        Me.dgdResults.AllowUserToAddRows = False
        Me.dgdResults.AllowUserToDeleteRows = False
        Me.dgdResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgdResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgdResults.Location = New System.Drawing.Point(12, 88)
        Me.dgdResults.Name = "dgdResults"
        Me.dgdResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdResults.Size = New System.Drawing.Size(634, 195)
        Me.dgdResults.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CLIE_ID"
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CLIE_Nome"
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Location = New System.Drawing.Point(196, 50)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(241, 26)
        Me.txtSearch.TabIndex = 4
        '
        'rbtCodigo
        '
        Me.rbtCodigo.AutoSize = True
        Me.rbtCodigo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtCodigo.ForeColor = System.Drawing.Color.Black
        Me.rbtCodigo.Location = New System.Drawing.Point(241, 22)
        Me.rbtCodigo.Name = "rbtCodigo"
        Me.rbtCodigo.Size = New System.Drawing.Size(69, 22)
        Me.rbtCodigo.TabIndex = 5
        Me.rbtCodigo.TabStop = True
        Me.rbtCodigo.Text = "Código"
        Me.rbtCodigo.UseVisualStyleBackColor = True
        '
        'rbtNome
        '
        Me.rbtNome.AutoSize = True
        Me.rbtNome.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbtNome.ForeColor = System.Drawing.Color.Black
        Me.rbtNome.Location = New System.Drawing.Point(333, 22)
        Me.rbtNome.Name = "rbtNome"
        Me.rbtNome.Size = New System.Drawing.Size(64, 22)
        Me.rbtNome.TabIndex = 6
        Me.rbtNome.TabStop = True
        Me.rbtNome.Text = "Nome"
        Me.rbtNome.UseVisualStyleBackColor = True
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(481, 50)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 23)
        Me.btnImp.TabIndex = 7
        Me.btnImp.Text = "Impressão"
        Me.btnImp.UseVisualStyleBackColor = True
        '
        'ConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(658, 296)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.rbtNome)
        Me.Controls.Add(Me.rbtCodigo)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgdResults)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ConsultaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cliente"
        CType(Me.dgdResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgdResults As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents rbtCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNome As System.Windows.Forms.RadioButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnImp As System.Windows.Forms.Button
End Class
