<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckForm))
        Me.ConnectionLabel1 = New System.Windows.Forms.Label()
        Me.txtConnection = New System.Windows.Forms.Label()
        Me.peers = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.IPaddress = New System.Windows.Forms.ColumnHeader()
        Me.latency = New System.Windows.Forms.ColumnHeader()
        Me.status = New System.Windows.Forms.ColumnHeader()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAcciveNodes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker2finder1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2add = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2finder2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2finder3 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2finder4 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2finderTotal = New System.ComponentModel.BackgroundWorker()
        Me.peers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionLabel1
        '
        Me.ConnectionLabel1.AutoSize = True
        Me.ConnectionLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ConnectionLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConnectionLabel1.Location = New System.Drawing.Point(1, 22)
        Me.ConnectionLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.ConnectionLabel1.Name = "ConnectionLabel1"
        Me.ConnectionLabel1.Size = New System.Drawing.Size(222, 28)
        Me.ConnectionLabel1.TabIndex = 0
        Me.ConnectionLabel1.Text = "Current Connections : "
        '
        'txtConnection
        '
        Me.txtConnection.AutoSize = True
        Me.txtConnection.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtConnection.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtConnection.Location = New System.Drawing.Point(216, 17)
        Me.txtConnection.Name = "txtConnection"
        Me.txtConnection.Size = New System.Drawing.Size(33, 37)
        Me.txtConnection.TabIndex = 1
        Me.txtConnection.Text = "0"
        '
        'peers
        '
        Me.peers.Controls.Add(Me.ConnectionLabel1)
        Me.peers.Controls.Add(Me.txtConnection)
        Me.peers.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.peers.Location = New System.Drawing.Point(432, 363)
        Me.peers.Name = "peers"
        Me.peers.Size = New System.Drawing.Size(290, 70)
        Me.peers.TabIndex = 2
        Me.peers.TabStop = False
        Me.peers.Text = "Node count (Max 100 Connections)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 263)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "low Latency node found List "
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IPaddress, Me.latency, Me.status})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(408, 241)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'IPaddress
        '
        Me.IPaddress.Text = "IP address"
        Me.IPaddress.Width = 200
        '
        'latency
        '
        Me.latency.Text = "Latency"
        Me.latency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.latency.Width = 100
        '
        'status
        '
        Me.status.Text = "Status"
        Me.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.status.Width = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAcciveNodes)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(432, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 70)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total active nodes"
        '
        'txtAcciveNodes
        '
        Me.txtAcciveNodes.AutoSize = True
        Me.txtAcciveNodes.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAcciveNodes.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtAcciveNodes.Location = New System.Drawing.Point(85, 20)
        Me.txtAcciveNodes.Name = "txtAcciveNodes"
        Me.txtAcciveNodes.Size = New System.Drawing.Size(33, 37)
        Me.txtAcciveNodes.TabIndex = 1
        Me.txtAcciveNodes.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total  : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(309, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 50)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Smart Peer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(432, 257)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Connecting to : "
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(30, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "127.0.0.1:8444"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(13, 68)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(413, 70)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(58, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Searching for low latency peer from Total active nodes"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(215, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BackgroundWorker2finder1
        '
        '
        'BackgroundWorker2add
        '
        '
        'BackgroundWorker2finder2
        '
        '
        'BackgroundWorker2finder3
        '
        '
        'BackgroundWorker2finder4
        '
        '
        'BackgroundWorker2finderTotal
        '
        '
        'CheckForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(734, 441)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.peers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CheckForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chia Smart Peer v.1.0"
        Me.peers.ResumeLayout(False)
        Me.peers.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ConnectionLabel1 As Label
    Friend WithEvents txtConnection As Label
    Friend WithEvents peers As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAcciveNodes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents IPaddress As ColumnHeader
    Friend WithEvents latency As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker2finder1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2add As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2finder2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2finder3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2finder4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2finderTotal As System.ComponentModel.BackgroundWorker
End Class
