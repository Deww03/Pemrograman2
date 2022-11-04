Public Class Belanja

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbonus.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtnama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""
        txtdiscon.Text = ""
        txtbayar.Text = ""
        txtbonus.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus As String
        'Deklarasi Input Harga dan Jumlah 
        harga = txtharga.Text
        jumlah = txtjumlah.Text
        'Perhitungan Total Harga 
        total = harga * jumlah
        'Penentuan Discon dan Bonus 
        If total >= 500000 Then
            diskon = 0.2 * total
            bonus = "Tas Pinggang"
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Payung"
        ElseIf total >= 100000 Then
            diskon = 0.1 * total
            bonus = "Kaos"
        ElseIf total >= 50000 Then
            diskon = 0.05 * total
            bonus = "Pena"
        Else
            diskon = 0
            bonus = "Tidak Ada"
        End If
19:
        'Perhitungan total Bayar 
        bayar = total - diskon
        'Deklarasi keluaran total Harga, diskon,total bayar, dan bonus 
        txttotal.Text = total
        txtdiscon.Text = diskon
        txtbayar.Text = bayar
        txtbonus.Text = bonus
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Belanja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtnama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnama.TextChanged

    End Sub

    Private Sub txtharga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtharga.TextChanged

    End Sub

    Private Sub txtjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjumlah.TextChanged

    End Sub

    Private Sub txttotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub txtdiscon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiscon.TextChanged

    End Sub

    Private Sub txtbayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbayar.TextChanged

    End Sub
End Class