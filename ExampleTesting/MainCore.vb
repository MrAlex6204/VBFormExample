Module MainCore

    '//Creamos una instancia de nuestro formulario principal
    'Para acceder de manera gobal a nuestro formaulario principal
    Private _MainForm As New MainForm()

    '//Creamos una propiedad publica que nos regrese 
    'una instancia de Tipo de nuestro formulario principal
    Public ReadOnly Property FormularioInicial As MainForm
        Get
            Return _MainForm
        End Get
    End Property


    Sub Main(Args() As String)
        '//El Main es el inicio del programa y Args los parametros que recibe 
        '//separados por coma y son opcionales
        '//Ej. MiPrograma.exe Parametro1 Parametro 2 ParametroN..

        Try

            '//Indicamos al programa que ejecute el MainForm como ventana principal
            Application.Run(FormularioInicial)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Ocurrio un error!")
        Finally
            Application.Exit()
        End Try


    End Sub

End Module
