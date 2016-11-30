Imports System.Collections.Specialized

''' <summary>
''' Displays 2 dropdowns with the tables columns
''' </summary>
Public Class DCombineRowsColumnPicker

	Private d_sdColumn As New StringDictionary

	Public Property Columns As StringDictionary
		Get
			Return d_sdColumn
		End Get
		Private Set(value As StringDictionary)
			d_sdColumn = value
		End Set
	End Property


	''' <summary>
	''' Constructor
	''' </summary>
	''' <param name="dtTable"></param>
	Public Sub New(ByRef dtTable As DataTable)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		Try

			cmbColumnToCombine.Items.Add("ALL")

			For Each dcCol As DataColumn In dtTable.Columns
				cmbColumnToJoin.Items.Add(dcCol.ColumnName)
				cmbColumnToCombine.Items.Add(dcCol.ColumnName)
			Next

		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

	End Sub


	''' <summary>
	''' Returns the Selected columns as long as they're different
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

		Try

			If cmbColumnToCombine.SelectedItem = cmbColumnToJoin.SelectedItem Then

				MessageBox.Show("The Same column cannot be selected!")
				Exit Sub

			End If

			d_sdColumn.Add("Join", cmbColumnToJoin.SelectedItem)
			d_sdColumn.Add("Combine", cmbColumnToCombine.SelectedItem)
			d_sdColumn.Add("Delimiter", cmbDuplicateDelimiter.Text)

		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

	End Sub
End Class