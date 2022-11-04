Public Class Kalkulator

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 * angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 + angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 - angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 / angka2
        TextBox3.Text = hasil
    End Sub
End Class