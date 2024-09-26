Imports System.Net.Sockets
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class Form1

    Dim thMain As Threading.Thread
    Dim bThread As Boolean = False
    Dim bThreadStart As Boolean = False
    Dim serverStream As NetworkStream '네트워크 스트림
    ReadOnly STX As Char = ChrW(&H2)
    ReadOnly ETX As Char = ChrW(&H3)

    <Obsolete>
    Private Sub Btn_CarOut_Click(sender As Object, e As EventArgs) Handles Btn_CarOut.Click

        Dim query As String = ""
        Dim strIP As String = DB_IP_Box.Text
        Dim strDB As String = DB_Name_Box.Text
        Dim strID As String = "interfaceuser"
        Dim strPW As String = "interfaceuser"

        query = query & "UPDATE measure_interface SET EMPTY_WEIGHT=" & Replace(Empty_Weight_Box.Text, " ", "")
        query = query & ",WEIGHT_FLAG=2"
        query = query & " WHERE MEASURE_DATE=" & "'" & Replace(DateTime.Now.ToString("yyyMMdd"), " ", "") & "'"
        query = query & "AND INTERFACE_ID=" & Replace(OUT_Interface_id_Box.Text, " ", "")

        Dim scn As SqlConnection
        Dim scm As SqlCommand
        Dim sda As SqlDataAdapter
        Dim ReadCount As Integer = 0


        scn = New SqlConnection
        scn.ConnectionString = "Data Source=" & strIP & ";Initial Catalog=" & strDB & ";Persist Security Info=True;User ID=" & strID & ";Password=" & strPW

        scm = New SqlCommand
        scm.CommandTimeout = 600
        scm.CommandType = CommandType.Text
        scm.CommandText = query
        scm.Connection = scn

        '------------------------------------------------------------------------------------------------------------

        Dim ds As DataSet = New DataSet
        sda = New SqlDataAdapter(scm)
        ReadCount = sda.Fill(ds)
        sda.Dispose()


        Dim ServerIPAdress As String = Socket_IP_Box.Text '서버의 아이피 = 192.168.2.161
        Dim MainPort As String = Socket_Port_Box.Text '채팅서버 포트 = 22245

        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 서버에 접속을 시도합니다.")
        Dim clientSocket As New System.Net.Sockets.TcpClient() '메인소켓들
        clientSocket.Connect(ServerIPAdress, MainPort)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 서버접속에 성공하였습니다.")
        'serverStream이라는 네트워크 스트림변수를 생성하여 clientSocket의 스트림정보를 반환합니다.
        Dim serverStream As NetworkStream = clientSocket.GetStream()

        'outStream은 txtMsg에 적힌 텍스트를 Bytes형식으로 인코딩하여 넣습니다.
        Dim chasu As String
        chasu = "02" '2차 중량

        Dim Interface_ID As String
        Interface_ID = OUT_Interface_id_Box.Text 'INTERFACE_ID
        Dim SendStream As Byte() = System.Text.Encoding.ASCII.GetBytes(STX & (OUT_CarNumBox.Text).PadRight(12) & Interface_ID.PadRight(13) & chasu & ETX)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), SendStream.ToString)

        'serverStream에 내용을 씁니다.
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 Test1")
        serverStream.Write(SendStream, 0, SendStream.Length)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 Test2")

        '나중에 사용을 위해 보류합니다.
        serverStream.Flush()
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 Test3")
        Dim inStream(1024) As Byte

        'clientSocket의 수신버퍼크기는 1024로 해줍니다.
        clientSocket.ReceiveBufferSize = 1024
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 Test4")

        Dim numberOfBytesRead As Integer = 0
        'serverStream이 보낸값을 읽어옵니다.
        numberOfBytesRead = serverStream.Read(inStream, 0, inStream.Length)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 Test5")

        'returndata변수에  inStream으로 받아진 정보를 저장합니다.
        Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream, 0, numberOfBytesRead)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 서버와 통신정보 : " + returndata)

        clientSocket.Close()
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "출차 서버를 종료합니다.")


    End Sub

    Delegate Sub TextBoxDelegate(strText As String)

    Private Sub msg(ByVal strText As String)

        TextBox1.AppendText(Environment.NewLine + " >> " + strText)
        TextBox1.ScrollToCaret()

    End Sub

    Private Sub Btn_CarIn_Click(sender As Object, e As EventArgs) Handles Btn_CarIn.Click
        Dim query As String = ""
        Dim strIP As String = DB_IP_Box.Text
        Dim strDB As String = DB_Name_Box.Text
        Dim strID As String = "interfaceuser"
        Dim strPW As String = "interfaceuser"

        query = query & "INSERT INTO measure_interface(INTERFACE_ID, MEASURE_DATE, MEASURE_TIME, CAR_NUMBER, A_CODE, ITEM_CODE, TOTAL_WEIGHT, EMPTY_WEIGHT,  MEASURE_FLAG, WEIGHT_FLAG, INTERFACE_FLAG, LOAD_TYPE, BALE_SIZE, BALE_COUNT)"
        query = query & "VALUES" & "(" & "'" & Replace(IN_Interface_id_Box.Text, " ", "") & "'"
        query = query & "," & "'" & Replace(DateTime.Now.ToString("yyyMMdd"), " ", "") & "'"
        query = query & "," & "'" & Replace(DateTime.Now.ToString("HHmmss"), " ", "") & "'"
        query = query & "," & "'" & Replace(IN_CarNumBox.Text, " ", "") & "'"
        query = query & "," & "'032630'" & "," & "'12010003'"
        query = query & "," & Replace(Total_Weight_Box.Text, " ", "") & ", 0, '0', '1', '1', '0', '', '20'" & ")"

        Dim scn As SqlConnection
        Dim scm As SqlCommand
        Dim sda As SqlDataAdapter
        Dim ReadCount As Integer = 0


        scn = New SqlConnection
        scn.ConnectionString = "Data Source=" & strIP & ";Initial Catalog=" & strDB & ";Persist Security Info=True;User ID=" & strID & ";Password=" & strPW

        scm = New SqlCommand
        scm.CommandTimeout = 600
        scm.CommandType = CommandType.Text
        scm.CommandText = query
        scm.Connection = scn

        '------------------------------------------------------------------------------------------------------------

        Dim ds As DataSet = New DataSet
        sda = New SqlDataAdapter(scm)
        ReadCount = sda.Fill(ds)
        sda.Dispose()


        Dim ServerIPAdress As String = Socket_IP_Box.Text '서버의 아이피 = 192.168.2.161
        Dim MainPort As String = Socket_Port_Box.Text '채팅서버 포트 = 22245

        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 서버에 접속을 시도합니다.")
        Dim clientSocket As New System.Net.Sockets.TcpClient() '메인소켓들
        clientSocket.Connect(ServerIPAdress, MainPort)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 서버접속에 성공하였습니다.")
        'serverStream이라는 네트워크 스트림변수를 생성하여 clientSocket의 스트림정보를 반환합니다.
        Dim serverStream As NetworkStream = clientSocket.GetStream()

        'outStream은 txtMsg에 적힌 텍스트를 Bytes형식으로 인코딩하여 넣습니다.
        Dim chasu As String
        chasu = "01" '1차 중량

        Dim Interface_ID As String
        Interface_ID = IN_Interface_id_Box.Text 'INTERFACE_ID
        Dim SendStream As Byte() = System.Text.Encoding.ASCII.GetBytes(STX & (IN_CarNumBox.Text).PadRight(12) & Interface_ID.PadRight(13) & chasu & ETX)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), SendStream.ToString)

        'serverStream에 내용을 씁니다.
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 Test1")
        serverStream.Write(SendStream, 0, SendStream.Length)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 Test2")

        '나중에 사용을 위해 보류합니다.
        serverStream.Flush()
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 Test3")
        Dim inStream(1024) As Byte

        'clientSocket의 수신버퍼크기는 1024로 해줍니다.
        clientSocket.ReceiveBufferSize = 1024
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 Test4")

        Dim numberOfBytesRead As Integer = 0
        'serverStream이 보낸값을 읽어옵니다.
        numberOfBytesRead = serverStream.Read(inStream, 0, inStream.Length)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 Test5")

        'returndata변수에  inStream으로 받아진 정보를 저장합니다.
        Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream, 0, numberOfBytesRead)
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 서버와 통신정보 : " + returndata)

        clientSocket.Close()
        Me.Invoke(New TextBoxDelegate(AddressOf msg), "입차 서버를 종료합니다.")
    End Sub
End Class
