Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.FileIO
Imports Hamburger_Reloaded.appdetails



Public Class MainPage

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public secnum, webnum, utinum, mesnum, devnum, mednum, runnum, comnum, imanum, docnum, filnum, onlnum, othnum As Integer
    Dim secgrpbx, webgrpbx, utigrpbx, mesgrpbx, medgrpbx, rungrpbx, comgrpbx, imagrpbx, docgrpbx, filgrpbx, onlgrpbx, devgrpbx, othgrpbx As New GroupBox
    Public indexnumber As Integer = 0
    Public lastindex As Integer
    Dim agr As Integer = 0
    Public newpath As String
    Public applicaton(50) As appdetails.appconfig
    Dim applistxml As New XmlDocument()
    Dim tempfrflpnl As Integer = 0
    Dim appchkbx(50) As CheckBox
    Dim tempapcaton As appconfig
    Dim sectempsort(50) As appconfig
    Dim alltempsort(50) As appconfig
    Dim chktempsort(50) As appconfig
    Dim chksrtind As Integer = 0
    Dim timeri As Integer = 0
    Dim timerj As Integer = 0
    Dim apptime As Integer = 0
    Dim tapp As Integer = 0
    Dim overvar As Integer = 0





    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nodestring As String
        Dim appnodelist As XmlNodeList
        Dim curpath As String = Directory.GetCurrentDirectory()
        newpath = curpath + "\HamburgerApps"
        If (Not System.IO.Directory.Exists(newpath)) Then
            System.IO.Directory.CreateDirectory(newpath)
        End If
        Directory.SetCurrentDirectory(newpath)
        If File.Exists("appcount.txt") Then
            Dim objReader As New System.IO.StreamReader("appcount.txt")
            Do While objReader.Peek() <> -1

                lastindex = objReader.ReadLine()

            Loop
            objReader.Close()
        Else
            Using writer As StreamWriter = New StreamWriter("appcount.txt")
                writer.Write(indexnumber)
                writer.Close()
            End Using
        End If

        If File.Exists("applist.xml") Then
            applistxml.Load("applist.xml")

        Else
            Dim applistwriter As New XmlTextWriter("applist.xml", System.Text.Encoding.UTF8)
            applistwriter.WriteStartDocument(True)
            applistwriter.WriteStartElement("newapp")
            applistwriter.WriteEndElement()
            applistwriter.WriteEndDocument()
            applistwriter.Close()
        End If
        Dim loopindex As Integer
        Dim adindex As Integer = 0
        For loopindex = indexnumber To lastindex
            nodestring = "/newapp/apps[@id = '" & loopindex & "']"
            appnodelist = applistxml.SelectNodes(nodestring)
            Dim appnode As XmlNode
            For Each appnode In appnodelist
                applicaton(adindex).filename = appnode.SelectSingleNode("name").InnerText

                If File.Exists(applicaton(adindex).filename) Then
                    applicaton(adindex).filecat = appnode.SelectSingleNode("filecats").InnerText
                    applicaton(adindex).silentcode = appnode.SelectSingleNode("silentcode").InnerText
                    applicaton(adindex).filesize = appnode.SelectSingleNode("filesize").InnerText
                    applicaton(adindex).dispfile = appnode.SelectSingleNode("dispname").InnerText

                    adindex = adindex + 1

                End If
            Next

        Next
        lastindex = adindex
    End Sub

    Private Sub sortcatnum()
        Try


            Dim k As Integer = 0

            secnum = 0
            webnum = 0
            utinum = 0
            mesnum = 0
            devnum = 0
            mednum = 0
            runnum = 0
            comnum = 0
            imanum = 0
            docnum = 0
            filnum = 0
            onlnum = 0
            othnum = 0

            For k = 0 To lastindex

                If applicaton(k).filecat = "Security" Then
                    secnum = secnum + 1
                End If
                If applicaton(k).filecat = "Web Browsers" Then
                    webnum = webnum + 1
                End If
                If applicaton(k).filecat = "Utilities" Then
                    utinum = utinum + 1
                End If
                If applicaton(k).filecat = "Messaging" Then
                    mesnum = mesnum + 1
                End If
                If applicaton(k).filecat = "Media" Then
                    mednum = mednum + 1
                End If
                If applicaton(k).filecat = "Developer Tools" Then
                    devnum = devnum + 1
                End If
                If applicaton(k).filecat = "Runtime" Then
                    runnum = runnum + 1
                End If
                If applicaton(k).filecat = "Compression" Then
                    comnum = comnum + 1
                End If
                If applicaton(k).filecat = "Imaging" Then
                    imanum = imanum + 1
                End If
                If applicaton(k).filecat = "Document" Then
                    docnum = docnum + 1
                End If
                If applicaton(k).filecat = "Filesharing" Then
                    filnum = filnum + 1
                End If
                If applicaton(k).filecat = "OnlineStorage" Then
                    onlnum = onlnum + 1
                End If
                If applicaton(k).filecat = "Other" Then
                    othnum = othnum + 1
                End If


            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkconfig(k As Integer, grpbx As Control, offset As Integer)
        appchkbx(k) = New CheckBox
        appchkbx(k).Location = New Point(10, offset)
        appchkbx(k).Name = applicaton(k).dispfile
        appchkbx(k).Text = applicaton(k).dispfile
        grpbx.Controls.Add(appchkbx(k))
        appchkbx(k).Visible = True
        appchkbx(k).BringToFront()
    End Sub

    Private Sub appsizesort()
        Dim k, j, l, m, n As Integer
        l = 0
        n = 0
        Dim index As Integer = 0

        Try
            For k = 0 To lastindex - 1
                If applicaton(k).filecat = "Security" Then
                    sectempsort(l) = applicaton(k)
                    l = l + 1

                Else
                    alltempsort(index) = applicaton(k)
                    index = index + 1

                End If
            Next

            For j = 0 To lastindex - 1
                For k = 0 To l
                    If k + 1 <> l Then
                        If Convert.ToInt64(sectempsort(k).filesize) > Convert.ToInt64(sectempsort(k + 1).filesize) Then
                            tempapcaton = sectempsort(k)
                            sectempsort(k) = sectempsort(k + 1)
                            sectempsort(k + 1) = tempapcaton

                        End If
                    End If

                Next

                For k = 0 To index
                    If k + 1 <> index Then
                        If Convert.ToInt64(alltempsort(k).filesize) > Convert.ToInt64(alltempsort(k + 1).filesize) Then
                            tempapcaton = alltempsort(k)
                            alltempsort(k) = alltempsort(k + 1)
                            alltempsort(k + 1) = tempapcaton
                        End If
                    End If

                Next
            Next



            For m = 0 To index - 1
                applicaton(m) = alltempsort(m)

            Next



            For m = 0 To l - 1
                applicaton(index) = sectempsort(m)
                index = index + 1
            Next
        Catch ex As Exception
            MsgBox("Sorting not done")
            MsgBox(ex.Message)
        End Try


    End Sub
 
    Private Sub addnewchkbx()
        Dim secoff, weboff, utioff, mesoff, medoff, devoff, runoff, comoff, imaoff, docoff, filoff, onloff, othoff As Integer
        secoff = 20
        weboff = 20
        utioff = 20
        mesoff = 20
        devoff = 20
        medoff = 20
        runoff = 20
        comoff = 20
        imaoff = 20
        docoff = 20
        filoff = 20
        onloff = 20
        othoff = 20


        Try

            For k = 0 To lastindex
                If applicaton(k).filecat = "Security" Then
                    chkconfig(k, secgrpbx, secoff)
                    secoff = secoff + 20
                End If
                If applicaton(k).filecat = "Web Browsers" Then
                    chkconfig(k, webgrpbx, weboff)
                    weboff = weboff + 20

                End If
                If applicaton(k).filecat = "Utilities" Then
                    chkconfig(k, utigrpbx, utioff)
                    utioff = utioff + 20
                End If
                If applicaton(k).filecat = "Messaging" Then
                    chkconfig(k, mesgrpbx, mesoff)
                    mesoff = mesoff + 20
                End If
                If applicaton(k).filecat = "Media" Then
                    chkconfig(k, medgrpbx, medoff)
                    medoff = medoff + 20
                End If
                If applicaton(k).filecat = "Developer Tools" Then
                    chkconfig(k, devgrpbx, devoff)
                    devoff = devoff + 20
                End If
                If applicaton(k).filecat = "Runtime" Then
                    chkconfig(k, rungrpbx, runoff)
                    runoff = runoff + 20
                End If
                If applicaton(k).filecat = "Compression" Then
                    chkconfig(k, comgrpbx, comoff)
                    comoff = comoff + 20
                End If
                If applicaton(k).filecat = "Imaging" Then
                    chkconfig(k, imagrpbx, imaoff)
                    imaoff = imaoff + 20
                End If
                If applicaton(k).filecat = "Document" Then
                    chkconfig(k, docgrpbx, docoff)
                    docoff = docoff + 20
                End If
                If applicaton(k).filecat = "Filesharing" Then
                    chkconfig(k, filgrpbx, filoff)
                    filoff = filoff + 20
                End If
                If applicaton(k).filecat = "OnlineStorage" Then
                    chkconfig(k, onlgrpbx, onloff)
                    onloff = onloff + 20
                End If
                If applicaton(k).filecat = "Other" Then
                    chkconfig(k, othgrpbx, othoff)
                    othoff = othoff + 20
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub creategrpndchkbx()
        Dim h As Integer = 0

        If secnum > 0 Then


            secgrpbx.Text = "Security"
            Me.flwlayoutpnl.Controls.Add(secgrpbx)
            secgrpbx.AutoSize = True


        End If
        If webnum > 0 Then


            webgrpbx.Text = "Web Browsers"
            Me.flwlayoutpnl.Controls.Add(webgrpbx)
            webgrpbx.AutoSize = True

        End If
        If utinum > 0 Then

            utigrpbx.Text = "Utilities"
            Me.flwlayoutpnl.Controls.Add(utigrpbx)
            utigrpbx.AutoSize = True

        End If
        If mesnum > 0 Then

            mesgrpbx.Text = "Messaging"
            Me.flwlayoutpnl.Controls.Add(mesgrpbx)
            mesgrpbx.AutoSize = True

        End If
        If mednum > 0 Then

            medgrpbx.Text = "Media"
            Me.flwlayoutpnl.Controls.Add(medgrpbx)
            medgrpbx.AutoSize = True

        End If
        If runnum > 0 Then

            rungrpbx.Text = "Runtimes"
            Me.flwlayoutpnl.Controls.Add(rungrpbx)
            rungrpbx.AutoSize = True

        End If
        If comnum > 0 Then

            comgrpbx.Text = "Compression"
            Me.flwlayoutpnl.Controls.Add(comgrpbx)
            comgrpbx.AutoSize = True

        End If
        If imanum > 0 Then

            imagrpbx.Text = "Imaging"
            Me.flwlayoutpnl.Controls.Add(imagrpbx)
            imagrpbx.AutoSize = True
        End If
        If docnum > 0 Then

            docgrpbx.Text = "Document"
            Me.flwlayoutpnl.Controls.Add(docgrpbx)
            docgrpbx.AutoSize = True
        End If
        If filnum > 0 Then

            filgrpbx.Text = "File Sharing"
            Me.flwlayoutpnl.Controls.Add(filgrpbx)
            filgrpbx.AutoSize = True
        End If
        If onlnum > 0 Then

            onlgrpbx.Text = "Online Storage"
            Me.flwlayoutpnl.Controls.Add(onlgrpbx)
            onlgrpbx.AutoSize = True
        End If
        If devnum > 0 Then

            devgrpbx.Text = "Developer Tools"
            Me.flwlayoutpnl.Controls.Add(devgrpbx)
            devgrpbx.AutoSize = True

        End If
        If webnum > 0 Then

            othgrpbx.Text = "Other"
            Me.flwlayoutpnl.Controls.Add(othgrpbx)
            othgrpbx.AutoSize = True

        End If
    End Sub

    Private Sub offlntabconfig()
        If tempfrflpnl > 0 Then
            flwlayoutpnl.AutoScroll = True
            flwlayoutpnl.AutoSize = False
            sortcatnum()
            creategrpndchkbx()
            addnewchkbx()
            Me.tabctrl.SelectedTab = offlinetab
            tempfrflpnl = 1
        Else

            Me.flwlayoutpnl.Controls.Clear()
            flwlayoutpnl.AutoScroll = True
            flwlayoutpnl.AutoSize = False
            sortcatnum()
            creategrpndchkbx()
            addnewchkbx()
            Me.tabctrl.SelectedTab = offlinetab
            tempfrflpnl = 1

        End If
    End Sub

    Private Sub chksort()
        Dim srtind As Integer


        Try
            For srtind = 0 To lastindex - 1
                If appchkbx(srtind).Checked = True Then
                    chktempsort(chksrtind) = applicaton(srtind)
                    chksrtind = chksrtind + 1
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles apptimer.Tick

        If timerj < 98 And timeri < 100 Then
            installprogress.pgbr1.Value = timerj
            installprogress.pgbr2.Value += 1
            timerj += 1
            Thread.Sleep(apptime)
        ElseIf timerj >= 98 And timeri <> 100 Then
            installprogress.pgbr1.Value = 97
            Thread.Sleep(apptime)

        End If

    End Sub

    Private Sub bgappinstl_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwrkr.ProgressChanged
        timeri = e.ProgressPercentage
        overvar = tapp * 100
        If timeri = 0 Then
            timerj = 0
            apptimer.Enabled = True
        Else
            installprogress.pgbr2.Value = overvar
            installprogress.pgbr1.Value = timeri
            apptimer.Enabled = False
        End If
        installprogress.statslbl.Text = Convert.ToString(tapp) + " out of " + Convert.ToString(chksrtind - 1)
        timeri = e.ProgressPercentage
        installprogress.pgststslbl.Text = e.UserState
    End Sub
    Private Sub addtogrid()
        Dim adtogrdind As Integer
        For adtogrdind = 0 To chksrtind - 1
            Dim row As String() = New String() {chktempsort(adtogrdind).dispfile, "Waiting"}
            installprogress.statusgrid.Rows.Add(row)
        Next

    End Sub
    Private Sub instlbtn_Click(sender As Object, e As EventArgs) Handles instlbtn.Click

        chksort()
        addtogrid()
        Me.Hide()
        installprogress.Show()
        bgwrkr.RunWorkerAsync()
    End Sub
    Private Function calapptime(sz As Integer)
        Dim tmpaptme As Integer
        tmpaptme = sz / 8
        Return (tmpaptme)
    End Function
    Private Sub bgappinstl_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwrkr.DoWork
        Dim bgindex As Integer = 0
        bgwrkr.WorkerReportsProgress = True
        Try
            For bgindex = 0 To chksrtind - 1
                apptime = calapptime(chktempsort(bgindex).filesize)
                timeri = 0
                Dim apname As String
                apname = chktempsort(bgindex).filename
                bgwrkr.ReportProgress(timeri, apname)
                Dim instldirpath As String
                instldirpath = newpath + "\" + chktempsort(bgindex).filename
                Dim hminstl As System.Diagnostics.Process
                Try
                    hminstl = New System.Diagnostics.Process()
                    hminstl.StartInfo.FileName = instldirpath
                    hminstl.StartInfo.Arguments = chktempsort(bgindex).silentcode
                    hminstl.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    hminstl.Start()
                    hminstl.WaitForExit()
                    hminstl.Close()
                    ' For Each prog As Process In Process.GetProcesses
                    'If prog.ProcessName = chktempsort(bgindex).filename Then
                    'prog.Kill()
                    '   Exit For
                    '    End If
                    '   Next
                    timeri = 100
                    tapp += 1
                    bgwrkr.ReportProgress(timeri, apname)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub oflnbg_Click(sender As Object, e As EventArgs) Handles oflnbg.Click, oflnimg.Click, oflnnts.Click, oflnhd.Click
        If lastindex = 0 Then
            Me.tabctrl.SelectedTab = modetab
            MsgBox("Add Apps in advance tab first")
        End If
        If lastindex > 0 Then
            appsizesort()
            offlntabconfig()
        End If
       
    End Sub

    Private Sub mnmz1_Click(sender As Object, e As EventArgs) Handles mnmz1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mnmz2_Click(sender As Object, e As EventArgs) Handles mnmz2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mnmz3_Click(sender As Object, e As EventArgs) Handles mnmz3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub intronxtbtn_Click(sender As Object, e As EventArgs)
        Me.tabctrl.SelectedTab = agreetab


    End Sub

    Private Sub mnmz4_Click(sender As Object, e As EventArgs) Handles mnmz4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Close()
    End Sub

    Private Sub oflmhd_Click(sender As Object, e As EventArgs) Handles oflnhd.Click
        Me.tabctrl.SelectedTab = offlinetab
    End Sub

    Private Sub oflnimg_Click(sender As Object, e As EventArgs) Handles oflnimg.Click
        Me.tabctrl.SelectedTab = offlinetab
    End Sub

    Private Sub oflnnts_Click(sender As Object, e As EventArgs) Handles oflnnts.Click
        Me.tabctrl.SelectedTab = offlinetab
    End Sub

    Private Sub advhd_Click(sender As Object, e As EventArgs) Handles advhd.Click
        Me.tabctrl.SelectedTab = advnctab
    End Sub

    Private Sub advimg_Click(sender As Object, e As EventArgs) Handles advimg.Click
        Me.tabctrl.SelectedTab = advnctab
    End Sub

    Private Sub advnts_Click(sender As Object, e As EventArgs) Handles advnts.Click
        Me.tabctrl.SelectedTab = advnctab
    End Sub

    Private Sub advbg_Click(sender As Object, e As EventArgs) Handles advbg.Click
        Me.tabctrl.SelectedTab = advnctab
    End Sub

    Private Sub oflnbg_MouseEnter(sender As Object, e As EventArgs) Handles oflnhd.MouseEnter, oflnimg.MouseEnter, oflnnts.MouseEnter, oflnbg.MouseEnter
        oflnbg.BackColor = Color.DeepSkyBlue
        oflnimg.BackColor = Color.DeepSkyBlue
        oflnnts.BackColor = Color.DeepSkyBlue
        oflnhd.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub oflnbg_MouseLeave(sender As Object, e As EventArgs) Handles oflnbg.MouseLeave, oflnhd.MouseLeave, oflnimg.MouseLeave, oflnnts.MouseLeave
        oflnbg.BackColor = Color.Tomato
        oflnhd.BackColor = Color.Tomato
        oflnimg.BackColor = Color.Tomato
        oflnnts.BackColor = Color.Tomato

    End Sub

    Private Sub advbg_MouseEnter(sender As Object, e As EventArgs) Handles advbg.MouseEnter, advhd.MouseEnter, advimg.MouseEnter, advnts.MouseEnter
        advbg.BackColor = Color.DeepSkyBlue
        advhd.BackColor = Color.DeepSkyBlue
        advimg.BackColor = Color.DeepSkyBlue
        advnts.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub advbg_MouseLeave(sender As Object, e As EventArgs) Handles advbg.MouseLeave, advhd.MouseLeave, advimg.MouseLeave, advnts.MouseLeave
        advbg.BackColor = Color.LimeGreen
        advhd.BackColor = Color.LimeGreen
        advimg.BackColor = Color.LimeGreen
        advnts.BackColor = Color.LimeGreen
    End Sub

    Private Sub addapplb_MouseEnter(sender As Object, e As EventArgs) Handles addapplb.MouseEnter
        addapplb.ForeColor = Color.Black
        addapplb.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub addapplb_MouseLeave(sender As Object, e As EventArgs) Handles addapplb.MouseLeave
        addapplb.ForeColor = Color.Black
        addapplb.BackColor = Color.LightGray
    End Sub

    Private Sub bck1_Click(sender As Object, e As EventArgs) Handles bck1.Click
        Me.tabctrl.SelectedTab = introtab
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabctrl.MouseDown, introtab.MouseDown, agreetab.MouseDown, modetab.MouseDown, advnctab.MouseDown, offlinetab.MouseDown, finaltab.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub agreechkbx_CheckedChanged(sender As Object, e As EventArgs) Handles agreechkbx.CheckedChanged
        If agr = 1 Then
            agr = 0
        Else
            agr = 1
        End If

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabctrl.MouseMove, introtab.MouseMove, agreetab.MouseMove, modetab.MouseMove, advnctab.MouseMove, offlinetab.MouseMove, finaltab.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabctrl.MouseUp, introtab.MouseUp, agreetab.MouseUp, modetab.MouseUp, advnctab.MouseUp, offlinetab.MouseUp, finaltab.MouseUp
        drag = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.tabctrl.SelectedTab = agreetab
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If agr = 1 Then
            Me.tabctrl.SelectedTab = modetab
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.tabctrl.SelectedTab = agreetab
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.tabctrl.SelectedTab = modetab
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Silver
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Silver
    End Sub

    Private Sub mnmz2_MouseEnter(sender As Object, e As EventArgs) Handles mnmz2.MouseEnter
        mnmz2.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub mnmz2_MouseLeave(sender As Object, e As EventArgs) Handles mnmz2.MouseLeave
        mnmz2.ForeColor = Color.Silver
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Silver
    End Sub

    Private Sub bck1_MouseEnter(sender As Object, e As EventArgs) Handles bck1.MouseEnter
        bck1.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub bck1_MouseLeave(sender As Object, e As EventArgs) Handles bck1.MouseLeave
        bck1.ForeColor = Color.Silver
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Silver
    End Sub

    Private Sub mnmz3_MouseEnter(sender As Object, e As EventArgs) Handles mnmz3.MouseEnter
        mnmz3.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub mnmz3_MouseLeave(sender As Object, e As EventArgs) Handles mnmz3.MouseLeave
        mnmz3.ForeColor = Color.Silver
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.Silver
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        Label8.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.ForeColor = Color.Silver
    End Sub

    Private Sub mnmz1_MouseEnter(sender As Object, e As EventArgs) Handles mnmz1.MouseEnter
        mnmz1.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub mnmz1_MouseLeave(sender As Object, e As EventArgs) Handles mnmz1.MouseLeave
        mnmz1.ForeColor = Color.Silver
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Silver
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As EventArgs) Handles Label11.MouseEnter
        Label11.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        Label11.ForeColor = Color.Silver
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Silver
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles offlinbackbtn.Click
        Me.tabctrl.SelectedTab = modetab
    End Sub

    Private Sub instlbtn_MouseEnter(sender As Object, e As EventArgs) Handles instlbtn.MouseEnter
        instlbtn.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub instlbtn_MouseLeave(sender As Object, e As EventArgs) Handles instlbtn.MouseLeave
        instlbtn.ForeColor = Color.Silver
    End Sub

    Private Sub offlinbackbtn_MouseEnter(sender As Object, e As EventArgs) Handles offlinbackbtn.MouseEnter
        offlinbackbtn.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub offlinbackbtn_MouseLeave(sender As Object, e As EventArgs) Handles offlinbackbtn.MouseLeave
        offlinbackbtn.ForeColor = Color.Silver
    End Sub

    Private Sub finltabminibtn_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub finltabclsbtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Close()
    End Sub

    Private Sub addapplb_Click(sender As Object, e As EventArgs) Handles addapplb.Click
        Newapp.Visible = True
        Me.Visible = False
    End Sub

End Class
