<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMain
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnCombineMultipleRows = New System.Windows.Forms.Button()
		Me.cmbDelimiter = New System.Windows.Forms.ComboBox()
		Me.lblDelimiter = New System.Windows.Forms.Label()
		Me.btnSelectFile = New System.Windows.Forms.Button()
		Me.mnuMain = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ofdCSVFile = New System.Windows.Forms.OpenFileDialog()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.dgvData = New System.Windows.Forms.DataGridView()
		Me.sfdFile = New System.Windows.Forms.SaveFileDialog()
		Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GroupBox1.SuspendLayout()
		Me.mnuMain.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnCombineMultipleRows)
		Me.GroupBox1.Controls.Add(Me.cmbDelimiter)
		Me.GroupBox1.Controls.Add(Me.lblDelimiter)
		Me.GroupBox1.Controls.Add(Me.btnSelectFile)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
		Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(735, 56)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "File Options"
		'
		'btnCombineMultipleRows
		'
		Me.btnCombineMultipleRows.Location = New System.Drawing.Point(317, 20)
		Me.btnCombineMultipleRows.Name = "btnCombineMultipleRows"
		Me.btnCombineMultipleRows.Size = New System.Drawing.Size(141, 23)
		Me.btnCombineMultipleRows.TabIndex = 3
		Me.btnCombineMultipleRows.Text = "Combine Rows"
		Me.btnCombineMultipleRows.UseVisualStyleBackColor = True
		'
		'cmbDelimiter
		'
		Me.cmbDelimiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbDelimiter.FormattingEnabled = True
		Me.cmbDelimiter.Items.AddRange(New Object() {"(,) Comma", "Tab", "Space"})
		Me.cmbDelimiter.Location = New System.Drawing.Point(229, 22)
		Me.cmbDelimiter.Name = "cmbDelimiter"
		Me.cmbDelimiter.Size = New System.Drawing.Size(82, 21)
		Me.cmbDelimiter.TabIndex = 2
		'
		'lblDelimiter
		'
		Me.lblDelimiter.AutoSize = True
		Me.lblDelimiter.Location = New System.Drawing.Point(173, 25)
		Me.lblDelimiter.Name = "lblDelimiter"
		Me.lblDelimiter.Size = New System.Drawing.Size(47, 13)
		Me.lblDelimiter.TabIndex = 1
		Me.lblDelimiter.Text = "Delimiter"
		'
		'btnSelectFile
		'
		Me.btnSelectFile.Location = New System.Drawing.Point(7, 20)
		Me.btnSelectFile.Name = "btnSelectFile"
		Me.btnSelectFile.Size = New System.Drawing.Size(160, 23)
		Me.btnSelectFile.TabIndex = 0
		Me.btnSelectFile.Text = "Select File..."
		Me.btnSelectFile.UseVisualStyleBackColor = True
		'
		'mnuMain
		'
		Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExportToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.mnuMain.Location = New System.Drawing.Point(0, 0)
		Me.mnuMain.Name = "mnuMain"
		Me.mnuMain.Size = New System.Drawing.Size(735, 24)
		Me.mnuMain.TabIndex = 1
		Me.mnuMain.Text = "Menu Strip"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
		Me.ExitToolStripMenuItem.Text = "Exit"
		'
		'ExportToolStripMenuItem
		'
		Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CSVToolStripMenuItem, Me.ExcelToolStripMenuItem})
		Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
		Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.ExportToolStripMenuItem.Text = "Export"
		'
		'CSVToolStripMenuItem
		'
		Me.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem"
		Me.CSVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.CSVToolStripMenuItem.Text = "CSV"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem.Text = "Help"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
		Me.AboutToolStripMenuItem.Text = "About"
		'
		'ofdCSVFile
		'
		Me.ofdCSVFile.DefaultExt = "*.csv"
		Me.ofdCSVFile.FileName = "*.csv"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.dgvData)
		Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox2.Location = New System.Drawing.Point(0, 80)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(735, 480)
		Me.GroupBox2.TabIndex = 2
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Data"
		'
		'dgvData
		'
		Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvData.Location = New System.Drawing.Point(3, 16)
		Me.dgvData.Name = "dgvData"
		Me.dgvData.Size = New System.Drawing.Size(729, 461)
		Me.dgvData.TabIndex = 0
		'
		'sfdFile
		'
		Me.sfdFile.DefaultExt = "*.csv"
		Me.sfdFile.FileName = "New Document.csv"
		Me.sfdFile.Filter = """Comma Seperated Values|*.csv"""
		'
		'ExcelToolStripMenuItem
		'
		Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
		Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.ExcelToolStripMenuItem.Text = "Excel"
		'
		'FMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(735, 560)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.mnuMain)
		Me.MainMenuStrip = Me.mnuMain
		Me.Name = "FMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Convert CSV To DataTable"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.mnuMain.ResumeLayout(False)
		Me.mnuMain.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnCombineMultipleRows As Button
	Friend WithEvents cmbDelimiter As ComboBox
	Friend WithEvents lblDelimiter As Label
	Friend WithEvents btnSelectFile As Button
	Friend WithEvents mnuMain As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ofdCSVFile As OpenFileDialog
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents dgvData As DataGridView
	Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CSVToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents sfdFile As SaveFileDialog
	Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
End Class
