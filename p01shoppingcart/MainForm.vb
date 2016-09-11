Public Class MainForm
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnHombre.Click

        btnHombre.ForeColor = Color.LightSteelBlue
        btnMujer.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Red
        btnAccesorios.ForeColor = Color.Gray

    End Sub

    Private Sub btnMujer_Click(sender As Object, e As EventArgs) Handles btnMujer.Click

        btnMujer.ForeColor = Color.Black
        btnHombre.ForeColor = Color.LightSteelBlue
        btnCalzado.ForeColor = Color.Red
        btnAccesorios.ForeColor = Color.Gray

    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click

        btnCalzado.ForeColor = Color.Red
        btnHombre.ForeColor = Color.LightSteelBlue
        btnMujer.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Gray

    End Sub

    Private Sub btnAccesorios_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click

        btnAccesorios.ForeColor = Color.Gray
        btnHombre.ForeColor = Color.LightSteelBlue
        btnMujer.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Red

    End Sub

    Private Sub btnCamisa_Click(sender As Object, e As EventArgs) Handles btnCamisa.Click

        lblTalla.Text = "Camisa de Algodon"
        lblPrecio.Text = "$ 120"
        pbCover.Image = ilProductos.Images.Item(0)

    End Sub

    Private Sub pbCover_Click(sender As Object, e As EventArgs) Handles pbCover.Click

    End Sub

    Private Sub btnBlazer_Click(sender As Object, e As EventArgs) Handles btnBlazer.Click

        lblTalla.Text = "Blazer Mezcla de Lana"
        lblPrecio.Text = "$ 240"
        pbCover.Image = ilProductos.Images.Item(1)

    End Sub

    Private Sub btnJersey_Click(sender As Object, e As EventArgs) Handles btnJersey.Click

        lblTalla.Text = "Jersey Cuello Pico"
        lblPrecio.Text = "$ 160"
        pbCover.Image = ilProductos.Images.Item(2)

    End Sub

    Private Sub btnPolo_Click(sender As Object, e As EventArgs) Handles btnPolo.Click

        lblTalla.Text = "Polo Cuello Redondo"
        lblPrecio.Text = "$ 0"
        pbCover.Image = ilProductos.Images.Item(3)

    End Sub
End Class