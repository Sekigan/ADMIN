Public Class Paquetes

    Private id_paquete As Integer
    Private id_empleado As Integer
    Private id_cliente As Integer
    Private remitente As String
    Private telefono_remitente As Integer
    Private fecha_envio As Date
    Private contenido As String
    Private peso As String
    Private empleado As String
    Private dia_dealta As Date
    Private precio_envio As Integer
    Private observacion As String
    Private fecha_entrega As Date

    Public Sub New()
        id_paquete = 0
        id_empleado = 0
        id_cliente = 0
        remitente = ""
        telefono_remitente = 0
        fecha_envio = Today
        contenido = ""
        peso = ""
        empleado = ""
        dia_dealta = Today
        observacion = ""
        fecha_entrega = Today

    End Sub

    Public Sub New(ByVal id_paquete As Integer, ByVal id_empleado As Integer, ByVal id_cliente As Integer, ByVal remitente As String,
        ByVal telefono_remitente As Integer, ByVal fecha_envio As Date, ByVal contenido As String, ByVal peso As String, ByVal empleado As String,
        ByVal dia_dealta As Date, ByVal obeservacion As String, ByVal fecha_entrega As Date)


        id_paquete = id_paquete
        id_empleado = id_empleado
        id_cliente = id_cliente
        remitente = remitente
        telefono_remitente = telefono_remitente
        fecha_envio = fecha_envio
        contenido = contenido
        peso = peso
        empleado = empleado
        dia_dealta = dia_dealta
        observacion = obeservacion
        fecha_entrega = fecha_entrega

    End Sub


    Public Sub realizarQuery(ByVal consulta As String)
        Dim xCnx As New Oracle


        xCnx.objetoDataAdapter(consulta)
        cnx.Close()
    End Sub
End Class
