Imports System.IO
Imports System.Threading

Public Class Form1
    Dim dt As String = ""
    Dim dtstyle As String = "ddd"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        txt_waktu.Text = My.Settings.belmasuk
        txt_belpulang.Text = My.Settings.belpulang
        txt_p1.Text = My.Settings.p1
        txt_p2.Text = My.Settings.p2
        txt_p3.Text = My.Settings.p3
        txt_p4.Text = My.Settings.p4
        txt_p5.Text = My.Settings.p5
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        dt = DateTime.Now.ToString(dtstyle)
        TextBox1.Text = dt
        My.Settings.hari = dt
        lbl_timenow.Text = TimeOfDay.ToString("HH:mm:ss")
        If lbl_timenow.Text = My.Settings.belmasuk Then
            My.Computer.Audio.Play(My.Resources.Bel_Masuk, AudioPlayMode.Background)
        ElseIf lbl_timenow.Text = My.Settings.belpulang Then
            My.Computer.Audio.Play(My.Resources.Bel_Pulang, AudioPlayMode.Background)
        ElseIf lbl_timenow.Text = My.Settings.p1 Then
            My.Computer.Audio.Play(My.Resources.Pengumuman_Baru, AudioPlayMode.Background)
        ElseIf lbl_timenow.Text = My.Settings.p2 Then
            My.Computer.Audio.Play(My.Resources.Pengumuman_Baru, AudioPlayMode.Background)
        ElseIf lbl_timenow.Text = My.Settings.p3 Then
            My.Computer.Audio.Play(My.Resources.Pengumuman_Baru, AudioPlayMode.Background)
        ElseIf lbl_timenow.Text = My.Settings.p4 Then
            My.Computer.Audio.Play(My.Resources.Pengumuman_Baru, AudioPlayMode.Background)
        ElseIf lbl_timenow.Text = My.Settings.p5 Then
            My.Computer.Audio.Play(My.Resources.Pengumuman_Baru, AudioPlayMode.Background)
        End If
        
    End Sub
    Private Sub btn_waktu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_waktu.Click
        My.Settings.belmasuk = txt_waktu.Text
        My.Settings.belpulang = txt_belpulang.Text
        My.Settings.p1 = txt_p1.Text
        My.Settings.p2 = txt_p2.Text
        My.Settings.p3 = txt_p3.Text
        My.Settings.p4 = txt_p4.Text
        My.Settings.p5 = txt_p5.Text
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If TextBox1.Text = "Mon" Then
            txt_waktu.Text = "08:00:00"
            txt_belpulang.Text = "16:28:00"
            txt_p1.Text = "08:02:00"
            txt_p2.Text = "10:00:00"
            txt_p3.Text = "12:00:00"
            txt_p4.Text = "14:00:00"
            txt_p5.Text = "16:00:00"
            btn_waktu.PerformClick()
        ElseIf TextBox1.Text = "Tue" Then
            txt_waktu.Text = "07:00:00"
            txt_belpulang.Text = "15:28:00"
            txt_p1.Text = "07:02:00"
            txt_p2.Text = "09:00:00"
            txt_p3.Text = "11:00:00"
            txt_p4.Text = "13:00:00"
            txt_p5.Text = "15:00:00"
            btn_waktu.PerformClick()
        ElseIf TextBox1.Text = "Wed" Then
            txt_waktu.Text = "08:00:00"
            txt_belpulang.Text = "16:28:00"
            txt_p1.Text = "08:02:00"
            txt_p2.Text = "10:00:00"
            txt_p3.Text = "12:00:00"
            txt_p4.Text = "14:00:00"
            txt_p5.Text = "16:00:00"
            btn_waktu.PerformClick()
        ElseIf TextBox1.Text = "Thu" Then
            txt_waktu.Text = "08:00:00"
            txt_belpulang.Text = "16:28:00"
            txt_p1.Text = "08:02:00"
            txt_p2.Text = "10:00:00"
            txt_p3.Text = "12:00:00"
            txt_p4.Text = "14:00:00"
            txt_p5.Text = "16:00:00"
            btn_waktu.PerformClick()
        ElseIf TextBox1.Text = "Fri" Then
            txt_waktu.Text = "07:00:00"
            txt_belpulang.Text = "15:58:00"
            txt_p1.Text = "07:02:00"
            txt_p2.Text = "09:00:00"
            txt_p3.Text = "11:00:00"
            txt_p4.Text = "13:00:00"
            txt_p5.Text = "15:00:00"
            btn_waktu.PerformClick()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Process.Start("http://www.dilmil-pontianak.go.id/")
    End Sub

    Private Sub GantiJamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiJamToolStripMenuItem.Click
        fMenu.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
