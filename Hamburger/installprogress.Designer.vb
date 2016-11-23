<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class installprogress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.abortbtn = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pgststslbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.statslbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.statusgrid = New System.Windows.Forms.DataGridView()
        Me.nameofapp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.finltabclsbtn = New System.Windows.Forms.Label()
        Me.finltabminibtn = New System.Windows.Forms.Button()
        Me.pgbr2 = New Hamburger_Reloaded.progressbar()
        Me.pgbr1 = New Hamburger_Reloaded.progressbar()
        CType(Me.statusgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'abortbtn
        '
        Me.abortbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.abortbtn.FlatAppearance.BorderSize = 0
        Me.abortbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.abortbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.abortbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abortbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.abortbtn.ForeColor = System.Drawing.Color.Silver
        Me.abortbtn.Location = New System.Drawing.Point(476, 461)
        Me.abortbtn.Name = "abortbtn"
        Me.abortbtn.Size = New System.Drawing.Size(75, 23)
        Me.abortbtn.TabIndex = 51
        Me.abortbtn.Text = "Abort"
        Me.abortbtn.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(12, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Overall Progress"
        '
        'pgststslbl
        '
        Me.pgststslbl.AutoSize = True
        Me.pgststslbl.ForeColor = System.Drawing.Color.Gold
        Me.pgststslbl.Location = New System.Drawing.Point(53, 89)
        Me.pgststslbl.Name = "pgststslbl"
        Me.pgststslbl.Size = New System.Drawing.Size(54, 13)
        Me.pgststslbl.TabIndex = 47
        Me.pgststslbl.Text = "Loading..."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "App : "
        '
        'statslbl
        '
        Me.statslbl.AutoSize = True
        Me.statslbl.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.statslbl.Location = New System.Drawing.Point(501, 127)
        Me.statslbl.Name = "statslbl"
        Me.statslbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statslbl.Size = New System.Drawing.Size(34, 13)
        Me.statslbl.TabIndex = 49
        Me.statslbl.Text = "1 of 5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(173, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(228, 25)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Installation Progress"
        '
        'statusgrid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray
        Me.statusgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.statusgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.statusgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.statusgrid.BackgroundColor = System.Drawing.Color.White
        Me.statusgrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.statusgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.statusgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.statusgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nameofapp, Me.appstatus})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.statusgrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.statusgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.statusgrid.EnableHeadersVisualStyles = False
        Me.statusgrid.GridColor = System.Drawing.Color.White
        Me.statusgrid.Location = New System.Drawing.Point(11, 156)
        Me.statusgrid.MultiSelect = False
        Me.statusgrid.Name = "statusgrid"
        Me.statusgrid.ReadOnly = True
        Me.statusgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.statusgrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.statusgrid.RowHeadersVisible = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.statusgrid.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.statusgrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray
        Me.statusgrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.statusgrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.statusgrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.statusgrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.statusgrid.Size = New System.Drawing.Size(542, 299)
        Me.statusgrid.TabIndex = 43
        '
        'nameofapp
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver
        Me.nameofapp.DefaultCellStyle = DataGridViewCellStyle3
        Me.nameofapp.HeaderText = "Application"
        Me.nameofapp.Name = "nameofapp"
        Me.nameofapp.ReadOnly = True
        '
        'appstatus
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver
        Me.appstatus.DefaultCellStyle = DataGridViewCellStyle4
        Me.appstatus.HeaderText = "Status"
        Me.appstatus.Name = "appstatus"
        Me.appstatus.ReadOnly = True
        '
        'finltabclsbtn
        '
        Me.finltabclsbtn.AutoSize = True
        Me.finltabclsbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.finltabclsbtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.finltabclsbtn.Location = New System.Drawing.Point(531, 13)
        Me.finltabclsbtn.Name = "finltabclsbtn"
        Me.finltabclsbtn.Size = New System.Drawing.Size(25, 24)
        Me.finltabclsbtn.TabIndex = 42
        Me.finltabclsbtn.Text = "X"
        '
        'finltabminibtn
        '
        Me.finltabminibtn.BackColor = System.Drawing.Color.Transparent
        Me.finltabminibtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.finltabminibtn.FlatAppearance.BorderSize = 0
        Me.finltabminibtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.finltabminibtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.finltabminibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.finltabminibtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finltabminibtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.finltabminibtn.Location = New System.Drawing.Point(504, 8)
        Me.finltabminibtn.Name = "finltabminibtn"
        Me.finltabminibtn.Size = New System.Drawing.Size(21, 33)
        Me.finltabminibtn.TabIndex = 41
        Me.finltabminibtn.Text = "-"
        Me.finltabminibtn.UseVisualStyleBackColor = False
        '
        'pgbr2
        '
        Me.pgbr2.BackColor = System.Drawing.Color.Gray
        Me.pgbr2.Location = New System.Drawing.Point(13, 113)
        Me.pgbr2.Maximum = 100
        Me.pgbr2.Minimum = 0
        Me.pgbr2.Name = "pgbr2"
        Me.pgbr2.ProgressBarColor = System.Drawing.Color.Blue
        Me.pgbr2.Size = New System.Drawing.Size(540, 10)
        Me.pgbr2.TabIndex = 44
        Me.pgbr2.Value = 0
        '
        'pgbr1
        '
        Me.pgbr1.BackColor = System.Drawing.Color.Gray
        Me.pgbr1.Location = New System.Drawing.Point(13, 76)
        Me.pgbr1.Maximum = 100
        Me.pgbr1.Minimum = 0
        Me.pgbr1.Name = "pgbr1"
        Me.pgbr1.ProgressBarColor = System.Drawing.Color.Blue
        Me.pgbr1.Size = New System.Drawing.Size(540, 10)
        Me.pgbr1.TabIndex = 45
        Me.pgbr1.Value = 0
        '
        'installprogress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(565, 491)
        Me.Controls.Add(Me.abortbtn)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.pgststslbl)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.statslbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.statusgrid)
        Me.Controls.Add(Me.finltabclsbtn)
        Me.Controls.Add(Me.finltabminibtn)
        Me.Controls.Add(Me.pgbr2)
        Me.Controls.Add(Me.pgbr1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "installprogress"
        Me.Text = "installprogress"
        CType(Me.statusgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents abortbtn As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents pgststslbl As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents statslbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents statusgrid As System.Windows.Forms.DataGridView
    Friend WithEvents nameofapp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents appstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents finltabclsbtn As System.Windows.Forms.Label
    Friend WithEvents finltabminibtn As System.Windows.Forms.Button
    Friend WithEvents pgbr2 As Hamburger_Reloaded.progressbar
    Friend WithEvents pgbr1 As Hamburger_Reloaded.progressbar
End Class
