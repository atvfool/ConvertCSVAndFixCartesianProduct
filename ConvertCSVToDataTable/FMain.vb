Imports System.Collections.Specialized
Imports System.IO


''' <summary>
''' Main Form in program. Opens at application startup
''' </summary>
Public Class FMain

	'''''''''''''''''''''''''''''''''''''''''''''''''
	'					Properties					'
	'''''''''''''''''''''''''''''''''''''''''''''''''
	Private f_strFileName As String = String.Empty




	'''''''''''''''''''''''''''''''''''''''''''''''''
	'					Methods						'
	'''''''''''''''''''''''''''''''''''''''''''''''''

	''' <summary>
	''' Form load Properties
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub FMain_Load(sender As Object, e As EventArgs) Handles Me.Load

		Try

			cmbDelimiter.SelectedIndex = 0

		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

	End Sub

	''' <summary>
	''' Closes the application
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub FMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
		Application.Exit()
	End Sub


	''' <summary>
	''' Closes the application
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

		FMain_FormClosed(ExitToolStripMenuItem, New EventArgs())

	End Sub


	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		Try



		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try
	End Sub


	''' <summary>
	''' Loads CSV File
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click

		Try

			Dim diaResult As DialogResult = ofdCSVFile.ShowDialog

			If diaResult = DialogResult.OK Then
				f_strFileName = ofdCSVFile.FileName
				ConvertCSVToDataTable()
				btnSelectFile.Text = ofdCSVFile.FileName.ToString
			End If

		Catch excError As Exception
			MessageBox.Show(excError.ToString)
			f_strFileName = String.Empty
		End Try

	End Sub

	''' <summary>
	''' Opens a dialog to select which columns to combine by then combines selected data
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	Private Sub btnCombineMultipleRows_Click(sender As Object, e As EventArgs) Handles btnCombineMultipleRows.Click

		Try
			If IsNothing(dgvData.DataSource) Then
				MessageBox.Show("No file is loaded, click select file to load a file")
				Exit Try
			End If

			Dim diaColumnPicker As New DCombineRowsColumnPicker(dgvData.DataSource)

			Dim diaResult As DialogResult = diaColumnPicker.ShowDialog

			If diaResult = DialogResult.OK Then

				Dim sdColumns As StringDictionary = diaColumnPicker.Columns

				CombineRows(sdColumns("Join"), sdColumns("Combine"))

			End If


		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

	End Sub


	''' <summary>
	''' Takes a CSV File (path stored in f_strFileName) and converts it into a datatable and displays
	''' </summary>
	Private Sub ConvertCSVToDataTable()

		Try

			If IO.File.Exists(f_strFileName) Then

				Dim strDelimiter As String = GetDelimiter()
				Dim strLines As String() = File.ReadAllLines(f_strFileName)
				Dim dtTable As New DataTable
				Dim intColCount As Integer = strLines.First.Split(strDelimiter).Length

				For intIndex As Integer = 1 To intColCount
					dtTable.Columns.Add(New DataColumn("Column_" & intIndex))
				Next

				For Each strLine As String In strLines

					Dim objFields As String() = strLine.Split(strDelimiter)
					Dim drNewRow As DataRow = dtTable.NewRow
					drNewRow.ItemArray = objFields

					For Each dcCol As DataColumn In dtTable.Columns
						drNewRow(dcCol.ColumnName) = drNewRow(dcCol.ColumnName).ToString.Replace("""", "").Replace("NULL", "")
					Next

					dtTable.Rows.Add(drNewRow)

				Next

				dgvData.DataSource = dtTable

			End If

		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

	End Sub

	''' <summary>
	''' Returns the delimiter selected 
	''' </summary>
	''' <returns></returns>
	Private Function GetDelimiter() As String

		Dim strReturn As String = ","

		Try

			'(,) Comma
			'TAB
			'Space

			Select Case cmbDelimiter.SelectedValue
				Case "(,) Comma"
					strReturn = ","
				Case "TAB"
					strReturn = vbTab
				Case "Space"
					strReturn = " "
			End Select

		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

		Return strReturn

	End Function


	''' <summary>
	''' Combines Rows with duplicate values
	''' </summary>
	''' <param name="strJoinColumn">Column that should Identitfy the unique rows</param>
	''' <param name="strColumnToCombine">If ALL is passed then it cycles through the whole table to get combine the different values Else gets rid of duplicates in 1 column</param>
	''' <param name="strDelimitter">Comma (,) by default for what to insert between the different values for a row</param>
	Private Sub CombineRows(ByVal strJoinColumn As String, ByVal strColumnToCombine As String, Optional ByVal strDelimitter As String = ",")

		Try

			Dim dtTable As DataTable = dgvData.DataSource
			Dim dtNewTable As DataTable = dtTable.Clone
			Dim strPreviousID As String = String.Empty
			Dim strCombinedValues As String = String.Empty

			Dim drNewRow As DataRow = dtNewTable.NewRow

			If strColumnToCombine = "ALL" Then

				For Each drRow As DataRow In dtTable.Rows

					' If specie hasn't been added to Table
					If dtNewTable.Select(strJoinColumn & "='" & drRow(strJoinColumn) & "'").Count = 0 Then

						drNewRow = dtNewTable.NewRow

						' Get just that specie
						For Each drSpecie As DataRow In dtTable.Select(strJoinColumn & "='" & drRow(strJoinColumn) & "'")

							For Each dcCol As DataColumn In dtTable.Columns

								' If the value hasn't been added to that column already add it with a delimitter
								If Not drNewRow(dcCol.ColumnName).ToString.Contains(drSpecie(dcCol.ColumnName).ToString) Then
									If drNewRow(dcCol.ColumnName).ToString <> String.Empty Then drNewRow(dcCol.ColumnName) &= strDelimitter
									drNewRow(dcCol.ColumnName) &= drSpecie(dcCol.ColumnName).ToString
								End If

							Next

						Next
						dtNewTable.Rows.Add(drNewRow)

					End If

				Next

			Else
				For Each drRow As DataRow In dtTable.Select("", strJoinColumn & " ASC")

					If strPreviousID = drRow(strJoinColumn).ToString Then

						If strCombinedValues <> String.Empty Then strCombinedValues &= strDelimitter

						strCombinedValues &= drRow(strColumnToCombine).ToString

						For Each dcCol As DataColumn In dtNewTable.Columns
							drNewRow(dcCol.ColumnName) = drRow(dcCol.ColumnName)
						Next

					Else

						If strPreviousID <> String.Empty Then '  Prevents 1st blank row from being adding
							drNewRow(strColumnToCombine) = strCombinedValues

							dtNewTable.Rows.Add(drNewRow)

							strCombinedValues = String.Empty

							drNewRow = dtNewTable.NewRow
						End If

						For Each dcCol As DataColumn In dtNewTable.Columns
							drNewRow(dcCol.ColumnName) = drRow(dcCol.ColumnName)
						Next

						strCombinedValues = drRow(strColumnToCombine)

					End If
					strPreviousID = drRow(strJoinColumn).ToString
				Next

				drNewRow(strColumnToCombine) = strCombinedValues

				dtNewTable.Rows.Add(drNewRow)

			End If

			dgvData.DataSource = dtNewTable

		Catch excError As Exception
			MessageBox.Show(excError.ToString)
		End Try

	End Sub

End Class
