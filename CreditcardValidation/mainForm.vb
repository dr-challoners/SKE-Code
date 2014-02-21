' -----------------------
' Credit Card Validation.
' -----------------------

' -----
' NOTES
' -----
#Region "Notes"
'
'#1 The function here uses a pretty straight forward naive approach, and, of course, the same algorithm
'   may be programmed in many other ways (in the same language, let alone using other languages), e.g.,
'   as in isCardNumberValid_2.  Encourage students to find other ways to encode this algorithm.
'
'#2 When we use an iterator, we don't need to keep the index of our position in the list of things
'   we're iterating through. This allows us to keep the code simpler as we don't have to declare 
'   initialise and set the counter - so, for example, we'll never get an off-by-one error using
'   an iterator.
'
'   That said, in this code, we have to process characters differently according to their position
'   in the string, i.e., we need to double every other digit from some starting point and potentially
'   do some other processing depending upon the value obtained.  So how do we keep track of which
'   digits need doubling when we don't have a handy index that we could, say, test using index mod 2
'   to see if it's even or not?  The way it is done here is to simply toggle a boolean - justAddIt.
'
'   Although using an iterator with a boolean works, is it as clear as using an index variable?
'   A good exercise is to convert the iterator code above into its index variable counterpart.
'
'#3 On the subject of what's clear or not, a good discussion can be had around which is clearer:
'
'   t += i Mod 10 + 1
'   t += i - 10 + 1 
'   t += i - 9
'
'   Or any variation of this.

#End Region 

Public Class mainForm

    ' This program comprises three methods of validating the credit card number and a method of evaluating the efficiency of the solution. 
    ' They are in order they should be used. 


    Public Sub CheckCardValidityAndPerformance( _
        ByVal cardNumber As String _
    )
        'This sub is used to measure the time taken to run the different methods


        Dim total As Integer = 1000000

        Dim start_1 As DateTime = DateTime.Now() ' Millisecond
        ' Dim ticks_Start_1 As Int64 = DateTime.Now().Ticks ' Processor Ticks

        For i As Integer = 0 To total

            isCardNumberValid(cardNumber)

        Next

        Dim duration_1 As TimeSpan = DateTime.Now - start_1 ' Millisecond
        ' Dim ticks_Duration_1 As Int64 = DateTime.Now.Ticks - ticks_Start_1 ' Processor Ticks
        Console.WriteLine(String.Format("Time Taken for {0} was {1} seconds.", "Method-1", Math.Round(duration_1.TotalSeconds, 3)))

    End Sub

    Private Function isCardNumberValid(ByVal cardNumber As String) As Boolean

        ' This function is inelegant, but it is the one most like the algorithm method discussed previously.

        Dim justAddIt As Boolean = True

        Dim cardNumber_reversed As Char() = StrReverse(cardNumber.Trim().Replace(" ", "")).ToCharArray()

        Dim running_Total As Integer = 0

        For i As Integer = 1 To cardNumber_reversed.Length - 1 Step 2 ' Start at one as ignore check digit

            Dim single_Character As Char = cardNumber_reversed(i)

            Dim single_Character_As_Integer As Integer = Integer.Parse(single_Character) * 2

            If single_Character_As_Integer.ToString().Length = 2 Then ' This method adds together the 2 numbers in a value over 10

                Dim first_Number_As_String As String = single_Character_As_Integer.ToString().Substring(0, 1)
                Dim second_Number_As_String As String = single_Character_As_Integer.ToString().Substring(1, 1)

                running_Total = running_Total + Integer.Parse(first_Number_As_String) ' 1 if 16
                running_Total = running_Total + Integer.Parse(second_Number_As_String) ' 6 if 16

            Else

                running_Total = running_Total + single_Character_As_Integer

            End If

        Next

        For i As Integer = 0 To cardNumber_reversed.Length - 1 Step 2 ' Start at zero to include  check digit

            Dim single_Character As Char = cardNumber_reversed(i)

            Dim single_Character_As_Integer As Integer = Integer.Parse(single_Character)

            running_Total = running_Total + single_Character_As_Integer

        Next

        If running_Total Mod 10 = 0 Then
            Return True ' Is Valid
        Else
            Return False ' Not Valid
        End If

    End Function

    


    Private Function isCardNumberValid_2(ByVal cardNumber As String) As Boolean

        Dim running_Total As Integer = 0

        Dim justAddIt As Boolean = True ' Flag: We just start doubling after the first char.

        ' Pre-computed values for summing cardNumber's component-digits once doubled.
        ' 0 - 4 map to 0, 2, 4, 6 8, and 5 - 9 map to (5*2 = 10 [1+0 = 1], 3, 5, 7, 9.
        '
        Dim pre_Computed As Integer() = {0, 2, 4, 6, 8, 1, 3, 5, 7, 9}

        Dim cardNumber_As_Array As Char() = StrReverse(cardNumber.Trim()).ToCharArray()

        For Each single_Digit_As_Char As Char In cardNumber_As_Array         ' Using an iterator rather than a loop variable. Note #1

            Dim single_Digit_As_Integer As Integer = Integer.Parse(single_Digit_As_Char)         ' Convert the character into a value -> '8' --> 8 etc.

            ' Based on justAddIt, either just add i to the total t, or use the preComp array to get the correct value to add.
            '
            running_Total += IIf(justAddIt, _
                                 single_Digit_As_Integer, _
                                 pre_Computed(single_Digit_As_Integer) _
                                )

            ' As we don't have a loop variable, we need some other way (rather than using var mod 2) to
            ' flag that we're looking at every other character; toggling a boolean every char should do.
            '
            justAddIt = Not justAddIt

        Next

        ' Return running_Total Mod 10 = 0

        Return running_Total Mod 10 = 0

    End Function

    Private Function isCardNumberValid_3(ByVal cardNumber As String) As Boolean

        Dim justAddIt As Boolean = True ' Flag: We just start doubling after the first char.

        Dim card_Number_Reversed As Char() = StrReverse(cardNumber.Trim().Replace(" ", "")).ToCharArray()

        Dim running_Total As Integer = 0

        ' -- Adding Loop --

        For Each card_digit As Char In card_Number_Reversed         ' Using an iterator rather than a loop variable. Note #2

            Dim card_digit_as_integer As Integer = Integer.Parse(card_digit)         ' Convert the character into a value -> '8' --> 8 etc.

            If justAddIt Then            ' We just add every other character to the total.                

                running_Total += card_digit_as_integer

            Else                         ' But for each of the other ones ...

                card_digit_as_integer *= 2                   ' we double it, and then ...

                If card_digit_as_integer >= 10 Then          ' if it's 10 or more ...

                    running_Total += 1
                    running_Total += card_digit_as_integer Mod 10    ' add its component digits. (t += i - 10 + 1 if you prefer, or even t += i - 9). Note #3

                Else                     ' It was less than 10 ...

                    running_Total += card_digit_as_integer               ' so just add it to the total.

                End If

            End If

            ' As we don't have a loop variable, we need some other way (rather than using var mod 2) to
            ' flag that we're looking at every other character; toggling a boolean every char should do.
            '
            justAddIt = Not justAddIt

        Next

        Return running_Total Mod 10 = 0

    End Function


    Private Sub validate_Click(sender As System.Object, e As System.EventArgs) Handles validate.Click

        ' Change this to test isCardNumberValid_2() instead of isCardNumberValid()
        '
        Dim ok As Boolean = isCardNumberValid(cardNumber.Text)

        MessageBox.Show(cardNumber.Text + " is " + IIf(ok, "", "Not ") + "valid", Me.Text)

    End Sub


    Private Sub mainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim tt As New ToolTip()

        tt.AutoPopDelay = 1000
        tt.InitialDelay = 1000
        tt.ReshowDelay = 500
        tt.ShowAlways = True

        tt.SetToolTip(cardNumber, "Minimum 11 characters long")

        tt.SetToolTip(lb, "Test numbers from www.getcreditcardnumbers.com")

    End Sub


    Private Sub cardNumber_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cardNumber.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then e.Handled = True

    End Sub


    Private Sub cardNumber_TextChanged(sender As System.Object, e As System.EventArgs) Handles cardNumber.TextChanged

        validate.Enabled = cardNumber.Text.Length >= 11

    End Sub


    Private Sub lb_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lb.SelectedIndexChanged

        If sender.Text <> "" Then cardNumber.Text = lb.SelectedItems(0).Trim()

    End Sub


    Private Sub ll_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ll.LinkClicked

        System.Diagnostics.Process.Start(ll.Text)

    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem1.Click

        aboutForm.ShowDialog(Me)

    End Sub

End Class

