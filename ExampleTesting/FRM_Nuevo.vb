Public Class FRM_Nuevo


    Private _FormularioNo As Integer = 0


    Public Property FormularioNo As Integer
        Get
            Return _FormularioNo
        End Get
        Set(value As Integer)
            _FormularioNo = value
        End Set
    End Property

    Private Sub cmdNotificar_Click(sender As Object, e As EventArgs) Handles cmdNotificar.Click

        '//Notificar al formulario principal a travez de la propiedad status.
        MainCore.FormularioInicial.Status = "Formulario No " + Me.FormularioNo.ToString("00")

    End Sub
End Class