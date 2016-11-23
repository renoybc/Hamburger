Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization
Imports Hamburger_Reloaded.appdetails
Imports Hamburger_Reloaded.MainPage



Public Class Newapp
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim appcountindex As Integer = Hamburger_Reloaded.MainPage.lastindex
    Dim fldrpath As String = Hamburger_Reloaded.MainPage.newpath
    Dim applistxml As New XmlDocument()
    Dim appcount As New XmlDocument()
    Dim orgfilepath As String
    Dim appfilesize As String
    Dim orgfilename As String






    Private Sub appendxml(ByVal filepath As String, ByVal filename As String, ByVal filecateg As String, ByVal slnt As String, ByVal flsz As String, ByVal dispnme As String)
        Dim xmldocs As New XDocument
        If File.Exists(filepath) Then
            xmldocs = XDocument.Load(filepath)
        Else
            MsgBox("no file exist")
        End If
        Dim root = New XElement("apps")
        Dim rootattr = New XAttribute("id", Hamburger_Reloaded.MainPage.lastindex)
        Dim docelname = New XElement("name", filename)
        Dim flcategory = New XElement("filecats", filecateg)
        Dim docslntcd = New XElement("silentcode", slnt)
        Dim flsiz = New XElement("filesize", flsz)
        Dim disnme = New XElement("dispname", dispnme)
        root.Add(rootattr, docelname, flcategory, docslntcd, flsiz, disnme)
        xmldocs.Root.Add(root)
        xmldocs.Save(filepath)
        Hamburger_Reloaded.MainPage.lastindex = Hamburger_Reloaded.MainPage.lastindex + 1
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).filename = filename
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).filecat = filecateg
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).silentcode = slnt
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).filesize = flsz
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).dispfile = dispnme
        Using writer As StreamWriter = New StreamWriter("appcount.txt")
            writer.Write(Hamburger_Reloaded.MainPage.lastindex)
            writer.Close()
        End Using
    End Sub

    Private Sub Panel1_DragDrop(sender As Object, e As DragEventArgs) Handles Panel1.DragDrop
        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
            adnwapflnme.Text = Path.GetFileName(files(0))
            orgfilename = Path.GetFileName(files(0))
            Dim myFile As New FileInfo(files(0))
            appfilesize = myFile.Length

            For Each path In files
                orgfilepath = path
            Next
        Catch
            MsgBox("Error while dropping")
        End Try
    End Sub



    Private Sub Panel1_DragEnter(sender As Object, e As DragEventArgs) Handles Panel1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub addtolist(ByVal filesz As String)
        Dim tempfld As String
        tempfld = fldrpath + "\" + orgfilename
        appendxml("applist.xml", orgfilename, catslctbx.Text, silntkytxtbx.Text, filesz, adnwapflnme.Text)
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).filename = orgfilename
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).filecat = catslctbx.Text
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).silentcode = silntkytxtbx.Text
        Hamburger_Reloaded.MainPage.applicaton(Hamburger_Reloaded.MainPage.lastindex).dispfile = adnwapflnme.Text
        Try
            My.Computer.FileSystem.CopyFile(orgfilepath, tempfld, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Catch
            MsgBox("Error in copying")
        End Try
    End Sub

    Private Sub adnewbtn_Click(sender As Object, e As EventArgs) Handles adnewbtn.Click
        If adnwapflnme.Text <> "" Then
            If adnwapflnme.TextLength > 13 Then
                MsgBox("Due to some design Limitations you have to enter a name that has length not more than 13")
            Else
                If catslctbx.Text <> "" Then
                    Dim i As Integer = 0
                    Dim fileexist As Integer = 0
                    For i = 0 To Hamburger_Reloaded.MainPage.lastindex
                        If Hamburger_Reloaded.MainPage.applicaton(i).filesize = appfilesize Then
                            fileexist = 1
                        End If
                    Next
                    If fileexist = 0 Then
                        addtolist(appfilesize)
                        adnwapflnme.Text = ""
                        silntkytxtbx.Text = ""
                        catslctbx.SelectedItem = Nothing
                    Else

                        MsgBox(adnwapflnme.Text + "already exist. Add a Different App")
                    End If
                Else
                    MsgBox("Please select a  Catogoery")
                End If
            End If
        End If

    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        If adnwapflnme.Text <> "" Then
            If adnwapflnme.TextLength > 13 Then
                MsgBox("Due to some design Limitations you have to enter a name that has length not more than 13")
            Else
                If catslctbx.Text <> "" Then
                    Dim i As Integer = 0
                    Dim fileexist As Integer = 0
                    For i = 0 To Hamburger_Reloaded.MainPage.lastindex
                        If Hamburger_Reloaded.MainPage.applicaton(i).filesize = appfilesize Then
                            fileexist = 1
                        End If
                    Next
                    If fileexist = 0 Then
                        addtolist(appfilesize)
                    End If
                    Me.Close()
                    My.Forms.MainPage.Visible = True
                Else
                    MsgBox("Please select a  Catogoery")
                End If
            End If

          
        Else
            MsgBox("No app is added")
            Me.Close()
            My.Forms.MainPage.Visible = True

        End If
       
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Close()
        My.Forms.MainPage.Visible = True

    End Sub

    Private Sub mnmz4_Click(sender As Object, e As EventArgs) Handles mnmz4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter
        Label10.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave
        Label10.ForeColor = Color.Silver
    End Sub


    Private Sub mnmz4_MouseEnter(sender As Object, e As EventArgs) Handles mnmz4.MouseEnter
        mnmz4.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub mnmz4_MouseLeave(sender As Object, e As EventArgs) Handles mnmz4.MouseLeave
        mnmz4.ForeColor = Color.Silver
    End Sub

    Private Sub adnewbtn_MouseEnter(sender As Object, e As EventArgs) Handles adnewbtn.MouseEnter
        adnewbtn.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub adnewbtn_MouseLeave(sender As Object, e As EventArgs) Handles adnewbtn.MouseLeave
        adnewbtn.ForeColor = Color.Silver
    End Sub

    Private Sub okbtn_MouseEnter(sender As Object, e As EventArgs) Handles okbtn.MouseEnter
        okbtn.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub okbtn_MouseLeave(sender As Object, e As EventArgs) Handles okbtn.MouseLeave
        okbtn.ForeColor = Color.Silver
    End Sub
End Class