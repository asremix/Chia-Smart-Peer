Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class CheckForm
    Public version As String
    Public publicAcciveNodes1 As Integer
    Public publicAcciveNodes2 As Integer
    Public publicAcciveNodes3 As Integer
    Public publicAcciveNodes4 As Integer
    Public Connectionnow As Integer
    Private pOutput As String
    Private pError As String
    Private newrawresp As String()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FilePath1 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.1\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.2\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath3 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.3\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath4 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.4\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath5 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.5\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath6 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.6\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath7 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.7\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath8 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.8\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath9 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.1.9\resources\app.asar.unpacked\daemon\chia.exe"
        Dim FilePath10 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-1.2.0\resources\app.asar.unpacked\daemon\chia.exe"

        If System.IO.File.Exists(FilePath1) Then
            version = "1.1.1"

        ElseIf System.IO.File.Exists(FilePath2) Then
            version = "1.1.2"

        ElseIf System.IO.File.Exists(FilePath3) Then
            version = "1.1.3"

        ElseIf System.IO.File.Exists(FilePath4) Then
            version = "1.1.4"

        ElseIf System.IO.File.Exists(FilePath5) Then
            version = "1.1.5"

        ElseIf System.IO.File.Exists(FilePath6) Then
            version = "1.1.6"

        ElseIf System.IO.File.Exists(FilePath7) Then
            version = "1.1.7"

        ElseIf System.IO.File.Exists(FilePath8) Then
            version = "1.1.8"

        ElseIf System.IO.File.Exists(FilePath9) Then
            version = "1.1.9"

        ElseIf System.IO.File.Exists(FilePath10) Then
            version = "1.2.0"

        Else
            MsgBox("The file not exists")
        End If
    End Sub
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    Public Function CountNode(ByVal version As String)
        Dim mProcess As New Process
        mProcess.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-" + version + "\resources\app.asar.unpacked\daemon\chia.exe"
        mProcess.StartInfo.Arguments = "show -c"
        mProcess.StartInfo.RedirectStandardOutput = True
        mProcess.StartInfo.RedirectStandardError = True
        mProcess.StartInfo.UseShellExecute = False
        mProcess.StartInfo.CreateNoWindow = True

        mProcess = Process.Start(mProcess.StartInfo)

        pOutput = mProcess.StandardOutput.ReadToEnd
        pError = mProcess.StandardError.ReadToEnd

        Dim count As Integer
        count = CountCharacter(pOutput, "FULL_NODE")
        Control.CheckForIllegalCrossThreadCalls = False
        txtConnection.Text = count
        Connectionnow = count
        mProcess.CloseMainWindow()
        mProcess.Close()
        Return count
    End Function
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CountNode(version)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (BackgroundWorker1.IsBusy = False) Then
            BackgroundWorker1.RunWorkerAsync()
        End If
        If (BackgroundWorker2finder1.IsBusy = False) Then
            BackgroundWorker2finder1.RunWorkerAsync()
        End If
        ' If (BackgroundWorker2finder2.IsBusy = False) Then
        ' BackgroundWorker2finder2.RunWorkerAsync()
        'End If
        'If (BackgroundWorker2finder3.IsBusy = False) Then
        'BackgroundWorker2finder3.RunWorkerAsync()
        ' End If
        ' If (BackgroundWorker2finder4.IsBusy = False) Then
        'BackgroundWorker2finder4.RunWorkerAsync()
        'End If
        If (BackgroundWorker2finderTotal.IsBusy = False) Then
            BackgroundWorker2finderTotal.RunWorkerAsync()
        End If
        If (BackgroundWorker2add.IsBusy = False) Then
            If (Connectionnow < 100) Then
                BackgroundWorker2add.RunWorkerAsync()
            End If
        End If
    End Sub
    Private Sub BackgroundWorker2finder_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2finder1.DoWork
        Control.CheckForIllegalCrossThreadCalls = False
        Dim reader As StreamReader
        Dim Path As String

        Path = Application.StartupPath + "\NodeList.txt"
        reader = New StreamReader(Path)
        Dim rawresp As String
        rawresp = reader.ReadToEnd()
        newrawresp = rawresp.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim Shufflelist As List(Of String)
        Shufflelist = Shuffle(newrawresp)
        publicAcciveNodes1 = newrawresp.Length
        Dim cnt As Integer = 0
        For Each ipaddressandport As String In Shufflelist
            Dim words = ipaddressandport.Split(" : ")
            Dim Hostname = words(0)
            Dim Port = words(1)
            Dim num = 0
            'Call the function
            Dim PortOpen = IsPortOpen(Hostname, Port)
            If (PortOpen(0) Is "True" AndAlso Int(PortOpen(1)) < 150) Then
                'MessageBox.Show(Hostname + " : " + str(Port) + " : " + PortOpen(1))
                Dim liststr(3) As String
                Dim itm As ListViewItem

                liststr(0) = Hostname.ToString
                liststr(1) = PortOpen(1) + " ms".ToString
                liststr(2) = "Pending"
                itm = New ListViewItem(liststr)
                ListView1.Items.Insert(0, itm)
                num = num + 1
            End If
        Next
    End Sub
    Private Function IsPortOpen(ByVal Host As String, ByVal PortNumber As Integer)

        Dim clientSocket As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient

        Try
            Dim timeStampstart As DateTime = DateTime.Now
            clientSocket.Connect(Host, PortNumber)
            clientSocket.ReceiveTimeout = 100
            clientSocket.SendTimeout = 100
            Dim timeStampend As DateTime = DateTime.Now
            Dim Result As TimeSpan = timeStampend - timeStampstart
            clientSocket.Close()
            'MessageBox.Show(Host + " : " + Str(PortNumber) + " : " + Str(Result.TotalMilliseconds))
            Dim returnlist As New List(Of String)
            returnlist.Add("True")
            returnlist.Add(Str(Result.TotalMilliseconds))
            Return returnlist
        Catch ex As SocketException
            Dim returnlist As New List(Of String)
            returnlist.Add("False")
            Return returnlist
        Finally
            If Not clientSocket Is Nothing Then
                clientSocket.Close()
            End If
        End Try



    End Function

    Private Sub BackgroundWorker2add_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2add.DoWork
        connectNode(version)
    End Sub

    Public Function connectNode(ByVal version As String)
        Control.CheckForIllegalCrossThreadCalls = False

        If ListView1.Items.Count > 0 Then
            ListView1.Items(0).SubItems(2).Text = "Connecting"
            Label3.Text = ListView1.Items(0).Text + ":8444"

            Dim mProcess As New Process
            mProcess.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\AppData\Local\chia-blockchain\app-" + version + "\resources\app.asar.unpacked\daemon\chia.exe"
            mProcess.StartInfo.Arguments = "show -a " + ListView1.Items(0).Text + ":8444"
            mProcess.StartInfo.RedirectStandardOutput = True
            mProcess.StartInfo.RedirectStandardError = True
            mProcess.StartInfo.UseShellExecute = False
            mProcess.StartInfo.CreateNoWindow = True

            mProcess = Process.Start(mProcess.StartInfo)

            pOutput = mProcess.StandardOutput.ReadToEnd
            pError = mProcess.StandardError.ReadToEnd

            mProcess.CloseMainWindow()
            mProcess.Close()
            System.Threading.Thread.Sleep(2000)
            ListView1.Items.RemoveAt(0)
        Else
            Label3.Text = "Idle"
        End If
        Return 0
    End Function

    Private Sub BackgroundWorker2finder2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2finder2.DoWork
        Control.CheckForIllegalCrossThreadCalls = False
        Dim reader As StreamReader
        Dim Path As String

        Path = Application.StartupPath + "\NodeList.txt"
        reader = New StreamReader(Path)
        Dim rawresp As String
        rawresp = reader.ReadToEnd()
        newrawresp = rawresp.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim Shufflelist As List(Of String)
        Shufflelist = Shuffle(newrawresp)
        publicAcciveNodes2 = newrawresp.Length
        Dim cnt As Integer = 0
        For Each ipaddressandport As String In Shufflelist
            Dim words = ipaddressandport.Split(" : ")
            Dim Hostname = words(0)
            Dim Port = words(1)
            Dim num = 0
            'Call the function
            Dim PortOpen = IsPortOpen(Hostname, Port)
            If (PortOpen(0) Is "True" AndAlso Int(PortOpen(1)) < 100) Then
                'MessageBox.Show(Hostname + " : " + str(Port) + " : " + PortOpen(1))
                Dim liststr(3) As String
                Dim itm As ListViewItem
                liststr(0) = Hostname.ToString
                liststr(1) = PortOpen(1) + " ms".ToString
                liststr(2) = "Pending"
                itm = New ListViewItem(liststr)
                ListView1.Items.Insert(0, itm)
                num = num + 1
            End If
        Next
    End Sub

    Private Sub BackgroundWorker2finder3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2finder3.DoWork
        Control.CheckForIllegalCrossThreadCalls = False
        Control.CheckForIllegalCrossThreadCalls = False
        Dim reader As StreamReader
        Dim Path As String

        Path = Application.StartupPath + "\NodeList.txt"
        reader = New StreamReader(Path)
        Dim rawresp As String
        rawresp = reader.ReadToEnd()
        newrawresp = rawresp.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim Shufflelist As List(Of String)
        Shufflelist = Shuffle(newrawresp)
        publicAcciveNodes3 = newrawresp.Length
        Dim cnt As Integer = 0
        For Each ipaddressandport As String In Shufflelist
            Dim words = ipaddressandport.Split(" : ")
            Dim Hostname = words(0)
            Dim Port = words(1)
            Dim num = 0
            'Call the function
            Dim PortOpen = IsPortOpen(Hostname, Port)
            If (PortOpen(0) Is "True" AndAlso Int(PortOpen(1)) < 100) Then
                'MessageBox.Show(Hostname + " : " + str(Port) + " : " + PortOpen(1))
                Dim liststr(3) As String
                Dim itm As ListViewItem
                liststr(0) = Hostname.ToString
                liststr(1) = PortOpen(1) + " ms".ToString
                liststr(2) = "Pending"
                itm = New ListViewItem(liststr)
                ListView1.Items.Insert(0, itm)
                num = num + 1
            End If
        Next
    End Sub

    Private Sub BackgroundWorker2finder4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2finder4.DoWork
        Control.CheckForIllegalCrossThreadCalls = False
        Dim reader As StreamReader
        Dim Path As String

        Path = Application.StartupPath + "\NodeList.txt"
        reader = New StreamReader(Path)
        Dim rawresp As String
        rawresp = reader.ReadToEnd()
        newrawresp = rawresp.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim Shufflelist As List(Of String)
        Shufflelist = Shuffle(newrawresp)
        publicAcciveNodes4 = newrawresp.Length
        Dim cnt As Integer = 0
        For Each ipaddressandport As String In Shufflelist
            Dim words = ipaddressandport.Split(" : ")
            Dim Hostname = words(0)
            Dim Port = words(1)
            Dim num = 0
            'Call the function
            Dim PortOpen = IsPortOpen(Hostname, Port)
            If (PortOpen(0) Is "True" AndAlso Int(PortOpen(1)) < 100) Then
                'MessageBox.Show(Hostname + " : " + str(Port) + " : " + PortOpen(1))
                Dim liststr(3) As String
                Dim itm As ListViewItem
                liststr(0) = Hostname.ToString
                liststr(1) = PortOpen(1) + " ms".ToString
                liststr(2) = "Pending"
                itm = New ListViewItem(liststr)
                ListView1.Items.Insert(0, itm)
                num = num + 1
            End If
        Next
    End Sub

    Private Sub BackgroundWorker2finderTotal_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2finderTotal.DoWork
        'txtAcciveNodes.Text = publicAcciveNodes1 + publicAcciveNodes2 + publicAcciveNodes3 + publicAcciveNodes4
        txtAcciveNodes.Text = publicAcciveNodes1
    End Sub
    Function Shuffle(Of T)(collection As IEnumerable(Of T)) As List(Of T)
        Dim r As Random = New Random()
        Shuffle = collection.OrderBy(Function(a) r.Next()).ToList()
    End Function

End Class
