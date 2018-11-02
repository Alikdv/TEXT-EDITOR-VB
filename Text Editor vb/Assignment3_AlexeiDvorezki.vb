'Project Text Editor
'Copyright(C) 2018 Alexei Dvoreki

'This program Is free software: you can redistribute it And / Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'any later version.

'This program Is distributed In the hope that it will be useful,
'  but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.See the
'GNU General Public License For more details.

'  See <https://www.gnu.org/licenses/> to receive a copy of the GNU General Public License.

Imports System.Drawing.Text

Public Class Assignment3_AlexeiDvorezki



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboSize()

    End Sub


    Private Sub PopulateComboSize()
        Dim i As Integer
        For i = 8 To 60 Step 4
            SizeBox.Items.Add(i)
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startText As Integer = 0
        Dim endText As Integer

        endText = RichTextBox1.Text.LastIndexOf(TextBox1.Text)

        RichTextBox1.SelectAll()
        RichTextBox1.SelectionBackColor = Color.White

        While startText < endText

            RichTextBox1.Find(TextBox1.Text, startText, RichTextBox1.TextLength, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectionBackColor = Color.Pink

            startText = RichTextBox1.Text.IndexOf(TextBox1.Text, startText) + 1
        End While

    End Sub

    Private Function GetDefaultFont() As Font
        Return New Font("Sans Serif", 10, FontStyle.Regular)
    End Function
    'OPEN 
    Private Sub Open()
        If openWorks.ShowDialog = Windows.Forms.DialogResult.OK Then

            RichTextBox1.LoadFile(openWorks.FileName,
                              RichTextBoxStreamType.PlainText)

        End If
    End Sub
    'SAVE 
    Private Sub Save()
        If SaveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                RichTextBox1.SaveFile(SaveWork.FileName,
                                  RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        'check box to change text for Arial 

        RichTextBox1.Font = New Font("Arial", 12.0F)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub  CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        ' bold


        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Bold)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        '  'font style change to  Italic

        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Italic)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ''font style change to  Underline 

        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily, RichTextBox1.Font.Size, FontStyle.Underline)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'check box to change text for Sanserif 
        RichTextBox1.Font = New Font("Sanserif", 12.0F)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'check box to change text for GenericMonospace 

        RichTextBox1.Font = New Font(FontFamily.GenericMonospace, 12.0F)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles nMUndo.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub nMredo_Click(sender As Object, e As EventArgs) Handles nMredo.Click
        RichTextBox1.Redo()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Reset
        RichTextBox1.Font = New Drawing.Font("Times New Roman", 12.0F)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SizeBox.SelectedIndexChanged

    End Sub

    Private Sub SizeBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles SizeBox.SelectedValueChanged
        Dim Size As Single = Trim(Mid(SizeBox.Text, 1, 2))
        RichTextBox1.Font = New System.Drawing.Font("Calibri", Size, FontStyle.Regular)
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub
    'Save 
    Private Sub tbSave_Click(sender As Object, e As EventArgs) Handles tbSave.Click
        Save()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveWork.FileOk

    End Sub

    Private Sub tbOpen_Click(sender As Object, e As EventArgs) Handles tbOpen.Click
        Open()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        AboutBox1.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        AboutBox3.ShowDialog()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        AboutBox4.ShowDialog()

    End Sub
End Class
