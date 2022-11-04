Public Class Order_Makanan
    Public hrgmakanan, hrgminuman As Integer

    Private Sub Order_Makanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Uduk"
                Label2.Text = "Rp. 5000"
                hrgmakanan = 5000
            Case "Bakso"
                Label2.Text = "Rp. 12000"
                hrgmakanan = 12000
            Case "Mie Ayam"
                Label2.Text = "Rp. 10000"
                hrgmakanan = 10000
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                Label5.Text = "Rp. 5000"
                hrgminuman = 5000
            Case "Jus Alpukat"
                Label5.Text = "Rp. 10000"
                hrgminuman = 10000
            Case "Teh Manis"
                Label5.Text = "Rp. 7000"
                hrgminuman = 7000
        End Select
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Enabled = False Then
            ComboBox2.Visible = False
        End If
        If CheckBox1.Enabled = True Then
            ComboBox2.Visible = True
            Label4.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim porsimkn, porsimnm, jumlah As Integer
        porsimkn = TextBox1.Text
        porsimnm = TextBox2.Text
        jumlah = (hrgmakanan * porsimkn) + (hrgminuman * porsimnm)
        Label8.Text = "Rp. " & jumlah.ToString
    End Sub
End Class