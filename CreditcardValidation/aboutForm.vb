Public Class aboutForm

    Private Sub aboutForm_Load(sender As System.Object,  e As System.EventArgs) Handles MyBase.Load

        myName.Parent    = backGround  
        myName.BackColor = Color.Transparent

        ll.Parent        =  backGround 
        ll.BackColor     = Color.Transparent

    End Sub


    Private Sub ll_LinkClicked(sender As System.Object,  e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ll.LinkClicked

        Try

            System.Diagnostics.Process.Start("mailto:" + ll.Text + "?subject=" + System.IO.Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(".exe", "")))

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    
    End Sub

    
    Private Sub backGround_Click(sender As System.Object,  e As System.EventArgs) Handles backGround.Click, ll.Click, myName.Click 

        Me.Close()

    End Sub

End Class