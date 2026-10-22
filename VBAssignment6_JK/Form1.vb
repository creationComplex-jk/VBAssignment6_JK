Public Class Form1
    Private Sub btnWords_Click(sender As Object, e As EventArgs) Handles btnWords.Click
        'Declare Variables
        Dim strSentence As String = txtSentence.Text
        Dim intNumWords As Integer

        'Validation
        If Validation(strSentence) = False Then
            Exit Sub
        End If

        'Get Inputs
        strSentence = txtSentence.Text

        'Do Compuatitons
        intNumWords = CountWords(strSentence)

        'Display Outputs
        lblWordCount.Text = intNumWords

    End Sub

    Private Function CountWords(strSentence) As Integer
        Dim intNumSpaces As Integer
        Dim intNumWords As Integer

        For Each strNextCharacter In strSentence
            If strNextCharacter = " " Then
                intNumSpaces += 1
            End If

        Next

        intNumWords = intNumSpaces + 1

        Return intNumWords
    End Function

    Private Sub btnVowels_Click(sender As Object, e As EventArgs) Handles btnVowels.Click
        'Declare Variables
        Dim strSentence As String = txtSentence.Text
        Dim intNumVowels As Integer

        'Validation
        If Validation(strSentence) = False Then
            Exit Sub
        End If

        'Get Inputs
        strSentence = txtSentence.Text

        'Do Compuatitons
        intNumVowels = CountVowels(strSentence)

        'Display Outputs
        lblVowelCount.Text = intNumVowels
    End Sub

    Private Function CountVowels(strSentence)
        Dim intNumVowels As Integer
        For Each strNextCharacter As String In strSentence
            If strNextCharacter.ToLower() = "a" Or strNextCharacter.ToLower() = "e" Or strNextCharacter.ToLower() = "i" Or strNextCharacter.ToLower() = "o" Or strNextCharacter.ToLower() = "u" Then
                intNumVowels += 1
            End If

        Next
        Return intNumVowels
    End Function

    Private Sub btnBreak_Click(sender As Object, e As EventArgs) Handles btnBreak.Click
        Dim strRecord As String
        Dim intCommaIndex As Integer
        Dim strNextString As String

        strRecord = txtRecord.Text

        If Validation(strRecord) = False Then
            Exit Sub
        End If

        intCommaIndex = strRecord.IndexOf(",")
        strNextString = GetNextRecord(strRecord, intCommaIndex)
        Call RemoveFirstSubstring(strRecord, intCommaIndex)

        txtField1.Text = strNextString

        intCommaIndex = strRecord.IndexOf(",")
        strNextString = GetNextRecord(strRecord, intCommaIndex)
        Call RemoveFirstSubstring(strRecord, intCommaIndex)

        txtField2.Text = strNextString

        intCommaIndex = strRecord.IndexOf(",")
        strNextString = GetNextRecord(strRecord, intCommaIndex)
        Call RemoveFirstSubstring(strRecord, intCommaIndex)

        txtField3.Text = strNextString

        intCommaIndex = strRecord.IndexOf(",")
        strNextString = GetNextRecord(strRecord, intCommaIndex)
        Call RemoveFirstSubstring(strRecord, intCommaIndex)

        txtField4.Text = strNextString

        intCommaIndex = strRecord.IndexOf(",")
        strNextString = GetNextRecord(strRecord, intCommaIndex)
        Call RemoveFirstSubstring(strRecord, intCommaIndex)

        txtField5.Text = strNextString

        intCommaIndex = strRecord.IndexOf(",")
        strNextString = GetNextRecord(strRecord, intCommaIndex)
        Call RemoveFirstSubstring(strRecord, intCommaIndex)

        txtField6.Text = strNextString

    End Sub

    Private Function GetNextRecord(strRecord As String, intCommaIndex As Integer) As String
        Dim strNextSubstring As String
        If intCommaIndex = -1 Then
            strNextSubstring = strRecord
        Else
            strNextSubstring = strRecord.Substring(0, intCommaIndex)
        End If
        Return strNextSubstring
    End Function

    Private Sub RemoveFirstSubstring(ByRef strRecord As String, ByVal intCommaIndex As Integer)
        If intCommaIndex = -1 Then
            strRecord = ""
        Else
            strRecord = strRecord.Remove(0, intCommaIndex + 1)
            strRecord = strRecord.Trim()
        End If
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        Dim strPhoneNumber As String
        Dim strFormattedPhoneNumber
        strPhoneNumber = txtPhoneNumber.Text
        If Validation(strPhoneNumber) = False Then
            Exit Sub
        End If
        If strPhoneNumber.Length <> 10 Then
            MessageBox.Show("Please only enter 10 digit phone numbers.")
            Exit Sub
        End If
        strFormattedPhoneNumber = FormatPhoneNumber(strPhoneNumber)
        lblPhoneNumber.Text = strFormattedPhoneNumber
    End Sub

    Private Function FormatPhoneNumber(ByVal strPhoneNumber)
        strPhoneNumber = strPhoneNumber.Insert(0, "(")
        strPhoneNumber = strPhoneNumber.Insert(4, ")")
        strPhoneNumber = strPhoneNumber.Insert(8, "-")
        Return strPhoneNumber
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtField1.Text = ""
        txtField2.Text = ""
        txtField3.Text = ""
        txtField4.Text = ""
        txtField5.Text = ""
        txtField6.Text = ""
        txtPhoneNumber.Text = ""
        txtRecord.Text = ""
        txtSentence.Text = ""
        lblPhoneNumber.Text = ""
        lblVowelCount.Text = ""
        lblWordCount.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function Validation(ByVal VString)
        If VString = "" Then
            MessageBox.Show("Please enter a valid entry.")
            Return False
        Else
            Return True
        End If
    End Function
End Class