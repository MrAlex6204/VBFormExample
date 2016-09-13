Public Class MainForm

    Private Counter As Integer = 0

    '//Esta propiedad es de solo escritura
    Public WriteOnly Property Status As String
        Set(value As String)
            '//Esta propiedad nos servira para cambiar el valor del status desde fuera
            lblStatus.Text = "Status: " + value
        End Set
    End Property


    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim WndNuevo As New FRM_Nuevo()

        Counter += 1

        With WndNuevo
            .FormularioNo = Counter '//Indicar que No de formulario es
            .Text = "Formulario No." + Counter.ToString("00")
            .Show()
        End With




    End Sub
End Class
