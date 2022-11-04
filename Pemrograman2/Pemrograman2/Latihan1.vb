Public Class Latihan1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NilaiAbs As Byte
        Dim NilaiTugas As Byte
        Dim NilaiUTS As Byte
        Dim NilaiUAS As Byte
        Dim NilaiAkhir As Byte
        NilaiAbs = txtAbsensi.Text
        NilaiAbs = (NilaiAbs * 20) / 100
        txtHasilAbs.Text = NilaiAbs
        NilaiTugas = txtTugas.Text
        NilaiTugas = (NilaiTugas * 15) / 100
        txtHasilTugas.Text = NilaiTugas
        NilaiUTS = txtUts.Text
        NilaiUTS = (NilaiUTS * 30) / 100
        txtHasilUts.Text = NilaiUTS
        NilaiUAS = txtUas.Text
        NilaiUAS = (NilaiUAS * 35) / 100
        txtHasilUas.Text = NilaiUAS
        NilaiAkhir = NilaiAbs + NilaiTugas + NilaiUTS + NilaiUAS
        txtNilaiAkhir.Text = NilaiAkhir
    End Sub
End Class