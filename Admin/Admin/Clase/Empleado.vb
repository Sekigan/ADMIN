Public Class Empleado
    Private id_empleado As Integer
    Private id_pais As Integer
    Private id_estado As Integer
    Private id_ciudad As Integer
    Private id_colonia As Integer
    Private nombre As String
    Private paterno As String
    Private materno As String
    Private edad As String
    Private rfc As String
    Private curp As String
    Private sex As Char
    Private emai As String
    Private num As String
    Private Ncalle As Integer
    Private calle As String

    Public Sub New()
        id_empleado = 0
        id_pais = 0
        id_estado = 0
        id_ciudad = 0
        id_colonia = 0
        nombre = ""
        paterno = ""
        materno = ""
        rfc = ""
        curp = ""
        sex = ""
        emai = ""
        num = 0
        Ncalle = 0
        calle = ""
    End Sub

    Public Sub New(ByVal id_E As Integer, ByVal id_Pais As Integer, ByVal id_estad As Integer, ByVal id_Ciud As Integer, ByVal id_c As Integer, ByVal nm As String,
        ByVal pat As String, ByVal mat As String, ByVal rfc As String, ByVal curp As String, ByVal sex As Char, ByVal emai As String, ByVal num As Integer,
        ByVal Ncalle As Integer, ByVal calle As String)
        id_empleado = id_E
        id_Pais = id_Pais
        id_estado = id_estad
        id_ciudad = id_Ciud
        id_colonia = id_c
        nombre = nm
        paterno = pat
        materno = mat
        rfc = rfc
        curp = curp
        sex = sex
        emai = emai
        num = num
        Ncalle = Ncalle
        calle = calle
    End Sub



    Public Sub poblarComboBox(ByRef combo As ComboBox)
        Dim strSQL As String
        Dim xCnx As New Oracle


        strSQL = "SELECT ID_EMPLEADO,NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  EMPLEADOS "

        combo.DataSource = xCnx.objetoDataAdapter(strSQL)

        combo.DisplayMember = "NOMBRE"
        combo.ValueMember = "ID_EMPLEADO"


    End Sub

    Public Function consultaContra() As String
        Dim strSQL As String
        Dim xCnx As New Oracle



        strSQL = "SELECT CONTRASENA FROM LOGIN WHERE ID_EMPLEADO=" & id_empleado


        consultaContra = xCnx.objetoDataAdapter(strSQL).Rows(0)("CONTRASENA").ToString()



    End Function

    Public Sub realizarQuery(ByVal consulta As String)
        Dim xCnx As New Oracle

        xCnx.objetoDataAdapter(consulta)
        cnx.Close()
    End Sub






End Class
