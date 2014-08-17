Imports System.IO, System.Net, System.Net.Sockets

Public Class Form1
    Dim Listener As TcpListener
    Dim Client As TcpClient
    Dim ClientList As New List(Of ChatClient)
    Dim sReader As StreamReader
    Dim cClient As ChatClient

    Sub xLoad() Handles Me.Load
        Dim strFile As String = "Porta.txt"
        Dim sr As New IO.StreamReader(strFile)
        Dim porta As String
        porta = sr.ReadToEnd()
        sr.Close()
        Dim a As String = porta
        Dim b As Integer
        If IsNumeric(porta) Then
            b = Int(porta)
        End If

        Listener = New TcpListener(IPAddress.Any, porta)
        Listener.Start()
        xUpdate("Server Babilonia Chat Reloaded avviato sulla porta " + porta, False)
        Listener.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listener)
    End Sub

    Sub AcceptClient(ByVal ar As IAsyncResult)
        cClient = New ChatClient(Listener.EndAcceptTcpClient(ar))
        AddHandler (cClient.MessageRecieved), AddressOf MessageRecieved
        AddHandler (cClient.ClientExited), AddressOf ClientExited
        ClientList.Add(cClient)
        xUpdate("Nuovo client connesso", True)
        Listener.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), Listener)
    End Sub

    Sub MessageRecieved(ByVal Str As String)
        xUpdate(Str, True)
    End Sub

    Sub ClientExited(ByVal Client As ChatClient)
        ClientList.Remove(Client)
        xUpdate("Un client si è disconnesso", True)
    End Sub

    Delegate Sub _xUpdate(ByVal Str As String, ByVal Relay As Boolean)
    Sub xUpdate(ByVal Str As String, ByVal Relay As Boolean)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), Str, Relay)
        Else
            RichTextBox1.AppendText(Str & vbNewLine)
            If Relay Then Send(Str)
            RichTextBox1.SelectionStart = RichTextBox1.Text.Length
            RichTextBox1.SelectionLength = 0
            RichTextBox1.ScrollToCaret()
        End If
    End Sub

    Sub Send(ByVal Str As String)
        For i As Integer = 0 To ClientList.Count - 1
            Try
                ClientList(i).Send(Str)
            Catch
                ClientList.RemoveAt(i)
            End Try
        Next
    End Sub
End Class