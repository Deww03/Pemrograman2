Public Class Latihan2

    Private Sub txtdiscon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscon.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""
        txtdiscon.Text = ""
        txtbayar.Text = ""
        txtbonus.Text = ""
        txtkupon.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar, kupon As Double
        Dim bonus As String
        'Deklarasi Input Harga dan Jumlah 
        harga = txtharga.Text
        jumlah = txtjumlah.Text
        'Perhitungan Total Harga 
        total = harga * jumlah
        'Penentuan Discon dan Bonus 
        If total >= 700000 Then
            diskon = 0.3 * total
            bonus = "Baju Tidur"
            kupon = 22
        ElseIf total >= 300000 Then
            diskon = 0.2 * total
            bonus = "Topi Anak"
            kupon = 19
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Kaos Anak"
            kupon = 15
        ElseIf total >= 100000 Then
            diskon = 0.05 * total
            bonus = "Sapu Tangan"
            kupon = 5
        Else
            diskon = 0
            bonus = "Tidak Ada Bonus"
            kupon = 0
        End If
19:
        'Perhitungan total Bayar 
        bayar = total - diskon
        'Deklarasi keluaran total Harga, diskon,total bayar, dan bonus 
        txttotal.Text = total
        txtdiscon.Text = diskon
        txtbayar.Text = bayar
        txtbonus.Text = bonus
        txtkupon.Text = kupon
    End Sub
End Class