<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVowelCount = New System.Windows.Forms.Label()
        Me.lblWordCount = New System.Windows.Forms.Label()
        Me.Sentence2 = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.btnWords = New System.Windows.Forms.Button()
        Me.btnVowels = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtField4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtField2 = New System.Windows.Forms.TextBox()
        Me.txtField6 = New System.Windows.Forms.TextBox()
        Me.txtField3 = New System.Windows.Forms.TextBox()
        Me.txtField5 = New System.Windows.Forms.TextBox()
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.btnBreak = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.btnFormat = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtField1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblVowelCount)
        Me.GroupBox1.Controls.Add(Me.lblWordCount)
        Me.GroupBox1.Controls.Add(Me.Sentence2)
        Me.GroupBox1.Controls.Add(Me.txtSentence)
        Me.GroupBox1.Controls.Add(Me.btnWords)
        Me.GroupBox1.Controls.Add(Me.btnVowels)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1070, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "grpStep1"
        '
        'lblVowelCount
        '
        Me.lblVowelCount.AutoSize = True
        Me.lblVowelCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVowelCount.Location = New System.Drawing.Point(296, 147)
        Me.lblVowelCount.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblVowelCount.Name = "lblVowelCount"
        Me.lblVowelCount.Size = New System.Drawing.Size(200, 30)
        Me.lblVowelCount.TabIndex = 20
        '
        'lblWordCount
        '
        Me.lblWordCount.AutoSize = True
        Me.lblWordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWordCount.Location = New System.Drawing.Point(562, 147)
        Me.lblWordCount.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblWordCount.Name = "lblWordCount"
        Me.lblWordCount.Size = New System.Drawing.Size(200, 30)
        Me.lblWordCount.TabIndex = 19
        '
        'Sentence2
        '
        Me.Sentence2.AutoSize = True
        Me.Sentence2.Location = New System.Drawing.Point(191, 37)
        Me.Sentence2.Name = "Sentence2"
        Me.Sentence2.Size = New System.Drawing.Size(99, 26)
        Me.Sentence2.TabIndex = 9
        Me.Sentence2.Text = "Sentence:"
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(296, 30)
        Me.txtSentence.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(485, 33)
        Me.txtSentence.TabIndex = 8
        '
        'btnWords
        '
        Me.btnWords.Location = New System.Drawing.Point(562, 80)
        Me.btnWords.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWords.Name = "btnWords"
        Me.btnWords.Size = New System.Drawing.Size(142, 43)
        Me.btnWords.TabIndex = 7
        Me.btnWords.Text = "Count Words"
        Me.btnWords.UseVisualStyleBackColor = True
        '
        'btnVowels
        '
        Me.btnVowels.Location = New System.Drawing.Point(353, 80)
        Me.btnVowels.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVowels.Name = "btnVowels"
        Me.btnVowels.Size = New System.Drawing.Size(142, 43)
        Me.btnVowels.TabIndex = 0
        Me.btnVowels.Text = "Count Vowels"
        Me.btnVowels.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtField4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtField2)
        Me.GroupBox2.Controls.Add(Me.txtField6)
        Me.GroupBox2.Controls.Add(Me.txtField3)
        Me.GroupBox2.Controls.Add(Me.txtField5)
        Me.GroupBox2.Controls.Add(Me.txtField1)
        Me.GroupBox2.Controls.Add(Me.txtRecord)
        Me.GroupBox2.Controls.Add(Me.btnBreak)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 242)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1070, 275)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "grpStep2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Record: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 26)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Field 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(732, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 26)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Field 2"
        '
        'txtField4
        '
        Me.txtField4.Location = New System.Drawing.Point(808, 133)
        Me.txtField4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtField4.Name = "txtField4"
        Me.txtField4.Size = New System.Drawing.Size(131, 33)
        Me.txtField4.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(732, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Field 4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Field 3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 26)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Field 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(732, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 26)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Field 6"
        '
        'txtField2
        '
        Me.txtField2.Location = New System.Drawing.Point(808, 77)
        Me.txtField2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtField2.Name = "txtField2"
        Me.txtField2.Size = New System.Drawing.Size(131, 33)
        Me.txtField2.TabIndex = 14
        '
        'txtField6
        '
        Me.txtField6.Location = New System.Drawing.Point(808, 185)
        Me.txtField6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtField6.Name = "txtField6"
        Me.txtField6.Size = New System.Drawing.Size(131, 33)
        Me.txtField6.TabIndex = 13
        '
        'txtField3
        '
        Me.txtField3.Location = New System.Drawing.Point(116, 133)
        Me.txtField3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtField3.Name = "txtField3"
        Me.txtField3.Size = New System.Drawing.Size(131, 33)
        Me.txtField3.TabIndex = 12
        '
        'txtField5
        '
        Me.txtField5.Location = New System.Drawing.Point(116, 185)
        Me.txtField5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtField5.Name = "txtField5"
        Me.txtField5.Size = New System.Drawing.Size(131, 33)
        Me.txtField5.TabIndex = 11
        '
        'txtRecord
        '
        Me.txtRecord.Location = New System.Drawing.Point(296, 26)
        Me.txtRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.Size = New System.Drawing.Size(485, 33)
        Me.txtRecord.TabIndex = 9
        '
        'btnBreak
        '
        Me.btnBreak.Location = New System.Drawing.Point(469, 73)
        Me.btnBreak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBreak.Name = "btnBreak"
        Me.btnBreak.Size = New System.Drawing.Size(132, 38)
        Me.btnBreak.TabIndex = 6
        Me.btnBreak.Text = "Break Apart"
        Me.btnBreak.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblPhoneNumber)
        Me.GroupBox3.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox3.Controls.Add(Me.btnFormat)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 538)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1070, 215)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "grpStep3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(186, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(243, 26)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Formatted Phone Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(91, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 26)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Enter Phone Number:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneNumber.Location = New System.Drawing.Point(435, 91)
        Me.lblPhoneNumber.MinimumSize = New System.Drawing.Size(200, 30)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(200, 30)
        Me.lblPhoneNumber.TabIndex = 11
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(296, 30)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(485, 33)
        Me.txtPhoneNumber.TabIndex = 10
        '
        'btnFormat
        '
        Me.btnFormat.Location = New System.Drawing.Point(435, 150)
        Me.btnFormat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFormat.Name = "btnFormat"
        Me.btnFormat.Size = New System.Drawing.Size(217, 41)
        Me.btnFormat.TabIndex = 5
        Me.btnFormat.Text = "Format Phone Number"
        Me.btnFormat.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(660, 768)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 43)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(377, 768)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 43)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtField1
        '
        Me.txtField1.Location = New System.Drawing.Point(116, 77)
        Me.txtField1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtField1.Name = "txtField1"
        Me.txtField1.Size = New System.Drawing.Size(131, 33)
        Me.txtField1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 846)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnWords As Button
    Friend WithEvents btnVowels As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBreak As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnFormat As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSentence As TextBox
    Friend WithEvents txtRecord As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtField6 As TextBox
    Friend WithEvents txtField3 As TextBox
    Friend WithEvents txtField5 As TextBox
    Friend WithEvents txtField4 As TextBox
    Friend WithEvents txtField2 As TextBox
    Friend WithEvents Sentence2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblVowelCount As Label
    Friend WithEvents lblWordCount As Label
    Friend WithEvents txtField1 As TextBox
End Class
