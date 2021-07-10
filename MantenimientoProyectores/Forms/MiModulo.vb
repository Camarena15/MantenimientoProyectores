Module MiModulo
    Public RecursoAsignado(4) As String
    Public formSelected As String
    Public idsCat As New ArrayList
    Public res As String
    Public s As String = "Server=mysql-sistemamediosav.alwaysdata.net;database=sistemamediosav_db;user id=230400_db;password=W*eH0EBY%7oH;port=3306;"
    Public tiposervicio_1 As String
    Public indiceSupervision As Integer
    Public image As Image
    'Public s As String = "Server=26.176.23.206;database=sistemamediosav_db;user id=Admin;password=1234;port=3306;"
    'Variables Usadas para extraer informacion de un Reporte
    Public tipoReporte As String
    Public pFechaInicio As String
    Public pFechaFin As String
    Public idReporte_1 As String
    Public estadoreporte_1 As String
    Public fecha_1 As String
    Public observaciones_1 As String
    Public obtainedInfoRep As Boolean
    'Variables Usadas para extraer informacion de un Recurso
    Public recursoasignadoEdificio As String
    Public recursoasignadoAula As String
    Public recursoCat As String
    Public idRecurso_1 As String
    Public concepto_1 As String
    Public idcat_1 As String = ""
    Public estado_1 As String
    Public invcapece_1 As String
    Public modelo_1 As String
    Public marca_1 As String
    Public obtainedInfoRec As Boolean
    'Variables Usadas para extraer informacion de un Movimiento
    Public idMov_1 As String
    Public encargado_1 As String
    Public obtainedInfoMov As Boolean
    'Variables Usadas para controlar el monitoreo de carga de imagenes por FTP
    Public offset As Single
    Public BufferLength As Single
    Public trigger As Boolean
    Public filecount As Integer
    'Variables usadas para controlar los Reportes
    Public opcion As String
    Public defAppPath As String = AppDomain.CurrentDomain.BaseDirectory

End Module
