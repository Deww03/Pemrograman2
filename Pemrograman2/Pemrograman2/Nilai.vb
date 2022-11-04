Public Class Nilai

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NilaiAbs As Byte
        Dim NilaiTugas As Byte
        Dim NilaiUTS As Byte
        Dim NilaiUAS As Byte
        Dim NilaiAkhir As Byte
        NilaiAbs = txtAbsensi.Text
        NilaiAbs = (NilaiAbs * 10) / 100
        txtHasilAbs.Text = NilaiAbs
        NilaiTugas = txtTugas.Text
        NilaiTugas = (NilaiTugas * 20) / 100
        txtHasilTugas.Text = NilaiTugas
        NilaiUTS = txtUts.Text
        NilaiUTS = (NilaiUTS * 30) / 100
        txtHasilUts.Text = NilaiUTS
        NilaiUAS = txtUas.Text
        NilaiUAS = (NilaiUAS * 40) / 100
        txtHasilUas.Text = NilaiUAS
        NilaiAkhir = NilaiAbs + NilaiTugas + NilaiUTS + NilaiUAS
        txtNilaiAkhir.Text = NilaiAkhir
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

    Private Sub txtAbsensi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbsensi.TextChanged

    End Sub

    Private Sub txtTugas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTugas.TextChanged

    End Sub

    Private Sub txtUts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUts.TextChanged

    End Sub

    Private Sub txtUas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUas.TextChanged

    End Sub

    Private Sub txtNilaiAkhir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNilaiAkhir.TextChanged

    End Sub

    Private Sub txtHasilAbs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHasilAbs.TextChanged

    End Sub

    Private Sub txtHasilTugas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHasilTugas.TextChanged

    End Sub

    Private Sub txtHasilUts_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHasilUts.TextChanged

    End Sub

    Private Sub txtHasilUas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHasilUas.TextChanged

    End Sub
End Class