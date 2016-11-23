Public Class installprogress
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles abortbtn.Click
        MainPage.Show()
        Me.Close()

    End Sub

    Private Sub finltabclsbtn_Click(sender As Object, e As EventArgs) Handles finltabclsbtn.Click
        MainPage.Show()
        Me.Close()
    End Sub

    Private Sub installprogress_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub installprogress_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub installprogress_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub finltabclsbtn_MouseEnter(sender As Object, e As EventArgs) Handles finltabclsbtn.MouseEnter
        finltabclsbtn.ForeColor = Color.DeepSkyBlue

    End Sub


    Private Sub finltabclsbtn_MouseLeave1(sender As Object, e As EventArgs) Handles finltabclsbtn.MouseLeave
        finltabclsbtn.ForeColor = Color.Silver
    End Sub

    Private Sub finltabminibtn_MouseEnter1(sender As Object, e As EventArgs) Handles finltabminibtn.MouseEnter
        finltabminibtn.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub finltabminibtn_MouseLeave(sender As Object, e As EventArgs) Handles finltabminibtn.MouseLeave

        finltabminibtn.ForeColor = Color.Silver
    End Sub

    Private Sub abortbtn_MouseEnter(sender As Object, e As EventArgs) Handles abortbtn.MouseEnter
        abortbtn.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub abortbtn_MouseLeave(sender As Object, e As EventArgs) Handles abortbtn.MouseLeave
        abortbtn.ForeColor = Color.Silver
    End Sub

    Private Sub finltabminibtn_Click(sender As Object, e As EventArgs) Handles finltabminibtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class