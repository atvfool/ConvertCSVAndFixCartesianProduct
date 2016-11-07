<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DCombineRowsColumnPicker
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
		Me.btnOK = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cmbColumnToJoin = New System.Windows.Forms.ComboBox()
		Me.cmbColumnToCombine = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnOK
		'
		Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOK.Location = New System.Drawing.Point(12, 112)
		Me.btnOK.Name = "btnOK"
		Me.btnOK.Size = New System.Drawing.Size(75, 23)
		Me.btnOK.TabIndex = 0
		Me.btnOK.Text = "OK"
		Me.btnOK.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(93, 112)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(80, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Column To Join"
		'
		'cmbColumnToJoin
		'
		Me.cmbColumnToJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbColumnToJoin.FormattingEnabled = True
		Me.cmbColumnToJoin.Location = New System.Drawing.Point(12, 36)
		Me.cmbColumnToJoin.Name = "cmbColumnToJoin"
		Me.cmbColumnToJoin.Size = New System.Drawing.Size(156, 21)
		Me.cmbColumnToJoin.TabIndex = 3
		'
		'cmbColumnToCombine
		'
		Me.cmbColumnToCombine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbColumnToCombine.FormattingEnabled = True
		Me.cmbColumnToCombine.Location = New System.Drawing.Point(12, 85)
		Me.cmbColumnToCombine.Name = "cmbColumnToCombine"
		Me.cmbColumnToCombine.Size = New System.Drawing.Size(156, 21)
		Me.cmbColumnToCombine.TabIndex = 5
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 69)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(102, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Column To Combine"
		'
		'DCombineRowsColumnPicker
		'
		Me.AcceptButton = Me.btnOK
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(179, 148)
		Me.ControlBox = False
		Me.Controls.Add(Me.cmbColumnToCombine)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.cmbColumnToJoin)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOK)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "DCombineRowsColumnPicker"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Column Picker"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnOK As Button
	Friend WithEvents btnCancel As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents cmbColumnToJoin As ComboBox
	Friend WithEvents cmbColumnToCombine As ComboBox
	Friend WithEvents Label2 As Label
End Class
