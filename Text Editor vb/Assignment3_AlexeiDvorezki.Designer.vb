<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assignment3_AlexeiDvorezki
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tbOpen = New System.Windows.Forms.Button()
        Me.tbSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SizeBox = New System.Windows.Forms.ComboBox()
        Me.nMredo = New System.Windows.Forms.Button()
        Me.nMUndo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveWork = New System.Windows.Forms.SaveFileDialog()
        Me.openWork = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1255, 637)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(114, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(12, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton1.Location = New System.Drawing.Point(940, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 21)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.Text = "SansSerif"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton2.Location = New System.Drawing.Point(1047, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 21)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Monospace"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton3.Location = New System.Drawing.Point(1166, 20)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(57, 21)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.Text = "Arial"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CheckBox1.Location = New System.Drawing.Point(613, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 21)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Underline"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CheckBox2.Location = New System.Drawing.Point(710, 20)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(58, 21)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Italic"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CheckBox3.Location = New System.Drawing.Point(774, 20)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(58, 21)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Text = "Bold"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbOpen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SizeBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nMredo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nMUndo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1255, 695)
        Me.SplitContainer1.SplitterDistance = 54
        Me.SplitContainer1.TabIndex = 9
        '
        'tbOpen
        '
        Me.tbOpen.ImageKey = "(none)"
        Me.tbOpen.Location = New System.Drawing.Point(215, 16)
        Me.tbOpen.Name = "tbOpen"
        Me.tbOpen.Size = New System.Drawing.Size(51, 29)
        Me.tbOpen.TabIndex = 18
        Me.tbOpen.Text = "&Open"
        Me.tbOpen.UseVisualStyleBackColor = True
        '
        'tbSave
        '
        Me.tbSave.ImageKey = "(none)"
        Me.tbSave.Location = New System.Drawing.Point(272, 16)
        Me.tbSave.Name = "tbSave"
        Me.tbSave.Size = New System.Drawing.Size(51, 29)
        Me.tbSave.TabIndex = 17
        Me.tbSave.Text = "&Save"
        Me.tbSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Size"
        '
        'SizeBox
        '
        Me.SizeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SizeBox.FormattingEnabled = True
        Me.SizeBox.Items.AddRange(New Object() {"8px ", "10px "})
        Me.SizeBox.Location = New System.Drawing.Point(370, 18)
        Me.SizeBox.Name = "SizeBox"
        Me.SizeBox.Size = New System.Drawing.Size(55, 24)
        Me.SizeBox.TabIndex = 15
        '
        'nMredo
        '
        Me.nMredo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nMredo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nMredo.Location = New System.Drawing.Point(431, 16)
        Me.nMredo.Name = "nMredo"
        Me.nMredo.Size = New System.Drawing.Size(85, 29)
        Me.nMredo.TabIndex = 14
        Me.nMredo.Text = "&Redo"
        Me.nMredo.UseVisualStyleBackColor = True
        '
        'nMUndo
        '
        Me.nMUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nMUndo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nMUndo.Location = New System.Drawing.Point(522, 16)
        Me.nMUndo.Name = "nMUndo"
        Me.nMUndo.Size = New System.Drawing.Size(85, 29)
        Me.nMUndo.TabIndex = 13
        Me.nMUndo.Text = "&Undo"
        Me.nMUndo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(838, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 29)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SaveWork
        '
        '
        'openWork
        '
        Me.openWork.FileName = "openWork"
        '
        'Assignment3_AlexeiDvorezki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 695)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Assignment3_AlexeiDvorezki"
        Me.Text = "Text editor"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button2 As Button
    Friend WithEvents nMredo As Button
    Friend WithEvents nMUndo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SizeBox As ComboBox
    Friend WithEvents tbSave As Button
    Friend WithEvents SaveWork As SaveFileDialog
    Friend WithEvents tbOpen As Button
    Friend WithEvents openWork As OpenFileDialog
End Class
