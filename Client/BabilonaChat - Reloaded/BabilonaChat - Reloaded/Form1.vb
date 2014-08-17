Imports System.IO, System.Net, System.Net.Sockets
Imports PassGen

Public Class Form1
    Dim Client As TcpClient
    Dim sWriter As StreamWriter

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Play(My.Resources.logoff, AudioPlayMode.Background)
        If MsgBox("Sei sicuro di voler uscire?", MsgBoxStyle.YesNo, "Uscita") = DialogResult.No Then
            e.Cancel = True
        Else
        End If
    End Sub

    Sub xLoad() Handles Me.Load
        Me.Text &= " " & nickbox.Text
        My.Computer.Audio.Play(My.Resources.logon, AudioPlayMode.Background)
        nickbox.Text = My.Computer.Name
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ipbox.Text = "" Then
            MessageBox.Show("Inserire un IP", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If portabox.Text = "" Then
                MessageBox.Show("Inserire una porta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If nickbox.Text = "" Then
                    MessageBox.Show("Inserire un nick", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If chiavebox.Text = "" Then
                        MessageBox.Show("Inserire una chiave AES", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else

                        Try
                            Client = New TcpClient(ipbox.Text, CInt(portabox.Text))
                            Client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf Read), Nothing)
                            Button2.Enabled = True
                            ipbox.ReadOnly = True
                            portabox.ReadOnly = True
                            nickbox.ReadOnly = True
                            chiavebox.ReadOnly = True
                            Button1.Enabled = False
                            chiavebox.PasswordChar = "●"
                            Button3.Enabled = False

                        Catch
                            xUpdate("Impossibile connettere al server.")
                            Button2.Enabled = False
                            ipbox.ReadOnly = False
                            portabox.ReadOnly = False
                            nickbox.ReadOnly = False
                            chiavebox.ReadOnly = False
                            Button1.Enabled = True
                            Button3.Enabled = True
                            chiavebox.PasswordChar = ""
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Client.Client.Close()
        Client = Nothing
        ipbox.ReadOnly = False
        portabox.ReadOnly = False
        nickbox.ReadOnly = False
        chiavebox.ReadOnly = False
        Button2.Enabled = False
        Button1.Enabled = True
        chiavebox.PasswordChar = ""
        Button3.Enabled = True
    End Sub


    Sub Read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(Client.GetStream).ReadLine)
            Client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf Read, Nothing)
        Catch
            xUpdate("Ti sei disconnesso dal server.")
            Exit Sub
        End Try
    End Sub

    Private Sub Send(ByVal Str As String)
        Try
            sWriter = New StreamWriter(Client.GetStream)
            sWriter.WriteLine(Str)
            sWriter.Flush()
        Catch
            xUpdate("Non sei connesso a nessun server.")
        End Try
    End Sub

    Delegate Sub _xUpdate(ByVal Str As String)
    Sub xUpdate(ByVal Str As String)
        Dim aes As AES256 = New AES256(chiavebox.Text)
        Dim decriptato As String
        decriptato = aes.Decrypt(Str)
        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), decriptato)

            If Suono.Checked = True Then
                My.Computer.Audio.Play(My.Resources.messaggio, AudioPlayMode.Background)
            Else
            End If
            
        Else
            boxricevi.Text = boxricevi.Text + decriptato + vbCrLf
            If Suono.Checked = True Then
                My.Computer.Audio.Play(My.Resources.messaggio, AudioPlayMode.Background)
            Else
            End If
            boxricevi.SelectionStart = boxricevi.Text.Length
            boxricevi.SelectionLength = 0
            boxricevi.ScrollToCaret()

            If CheckBox1.Checked = True Then
                If Not boxricevi.Focused Then
                    FlashWindow.Flash(Me)
                Else
                End If

            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If boxinvia.Text = "" Then
        Else

            Dim aes As AES256 = New AES256(chiavebox.Text)
            Send(aes.Encrypt(nickbox.Text & ": " & boxinvia.Text))
            boxinvia.Clear()
        End If
    End Sub



    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Donazioni
        If MsgBox("Questa chat è completamente gratuita e open source," + vbCrLf + "Puoi ringraziarmi effettuando una donazione libera, se accetti verrai reindirizzato al form donazioni ufficiale paypal..." + vbCrLf + "Vuoi donare qualcosa?", MsgBoxStyle.YesNo, "Donazione") = DialogResult.Yes Then
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=5WYAW4TUB6TDE&lc=IT&item_name=Donazioni%2dLeprechaun&currency_code=EUR&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted")
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'About + licenza gpl v3
        If MsgBox("Babilonia Chat - Reloaded v. " + Application.ProductVersion + " By Leprechaun" + vbCrLf + "Software sotto licenza GPL v.3" + vbCrLf + "Visitare la pagina della licenza?", MsgBoxStyle.YesNo, "Licenza") = DialogResult.Yes Then
            System.Diagnostics.Process.Start("http://www.gnu.org/licenses/gpl.html")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        chiavebox.Text = Generator.GenerateRandomString("25", True)
    End Sub
End Class
