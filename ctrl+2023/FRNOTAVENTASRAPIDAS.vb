Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class FRNOTAVENTASRAPIDAS
    Private Sub FRNOTAVENTASRAPIDAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fechacompleta, fecha, fechafinal As String

        ' fechacompleta = calendario.SelectionRange.Start.ToString("yyyy/MM/dd")
        ' Dim fechacompleta As String
        '------------------------------------------
        'recibo el folio del corte de caja
        '----------------------------------------------
        fechacompleta = frmindex.calendario.SelectionRange.Start.ToString("yyyy/MM/dd")
        fecha = fechacompleta & " 00:00:00"
        fechafinal = fechacompleta & " 23:59:59"

        ' MsgBox(fechacompleta)


        'MsgBox(FRcerrarcaja.txtid.Text)
        'MsgBox(frmindex.indexidusuario)
        'cerrarconexion()

        '-----------------------------------------------
        'OBTENEMOS EL ID MAXIMO DE LA CAJA PARA SABER QUE IMPRIMIR
        '-----------------------------------------------

        'Dim idcaja, i As Integer
        ''cantidad = 0
        'conexionMysql.Open()
        'Dim Sql2a As String
        'Sql2a = "select max(idcaja) from caja;"
        'Dim cmd2a As New MySqlCommand(Sql2a, conexionMysql)
        'reader = cmd2a.ExecuteReader
        'reader.Read()
        'idcaja = reader.GetString(0).ToString
        ''cargamos el formulario  resumen
        'conexionMysql.Close()

        'MsgBox("hay tantos resultados:" & cantidad)

        'cerrarconexion()

        '-------------------
        'DATOS DEL TIPO DE USUARIO
        'conexionMysql.Open()
        'Dim ds As DataSet
        'Dim Sql As String
        'Sql = "select max(idcaja) from caja;"
        'Dim cmd As New MySqlCommand(Sql, conexionMysql)
        'Dim dt As New DataTable
        'Dim da As New MySqlDataAdapter(cmd)
        ''cargamos el formulario  resumen
        ''da.Fill(dt)
        'ds = New DataSet()
        'da.Fill(ds)
        'conexionMysql.Close()
        '------------------


        '-----------------------------------
        'DATOS DE LA EMPRESA
        conexionMysql.Open()
        Dim ds2 As DataSet
        Dim Sql2 As String
        Sql2 = "select nombre,calle_numero,colonia_ciudad,cp,estado,telefono,whatsapp,correo,fanpage,sitio_web,director,horario,giro, saludo_nota from datos_empresa;"
        Dim cmd2 As New MySqlCommand(Sql2, conexionMysql)
        Dim dt2 As New DataTable
        Dim da2 As New MySqlDataAdapter(cmd2)
        'cargamos el formulario  resumen
        'da.Fill(dt)
        ds2 = New DataSet()
        da2.Fill(ds2)
        conexionMysql.Close()

        '.-----------------------------------
        'EL LOGOTIPO
        conexionMysql.Open()
        Dim ds23 As DataSet
        Dim Sql23 As String
        Sql23 = "select logo from logo_empresa"
        Dim cmd23 As New MySqlCommand(Sql23, conexionMysql)
        Dim dt23 As New DataTable
        Dim da23 As New MySqlDataAdapter(cmd23)
        'cargamos el formulario  resumen
        'da.Fill(dt)
        ds23 = New DataSet()
        da23.Fill(ds23)
        conexionMysql.Close()

        '------------------------------------
        '-------------------

        conexionMysql.Open()
        Dim ds24 As DataSet
        Dim Sql24 As String
        Sql24 = "select venta.idventa, ventaind.idventaind, ventaind.actividad, ventaind.cantidad, ventaind.costo,(ventaind.cantidad * ventaind.costo) as Total, ventaind.idproducto, venta.hora,venta.fecha from ventaind, venta where ventaind.idventa = venta.idventa and venta.tipoventa='1' and fecha between '" & fecha & "' and '" & fechafinal & "';"
        Dim cmd24 As New MySqlCommand(Sql24, conexionMysql)
        Dim dt24 As New DataTable
        Dim da24 As New MySqlDataAdapter(cmd24)
        'cargamos el formulario  resumen
        'da.Fill(dt)
        ds24 = New DataSet()
        da24.Fill(ds24)
        conexionMysql.Close()
        '------------------

        ' Dim rds As New ReportDataSource("dsservicio", ds.Tables(0))
        Dim rds2 As New ReportDataSource("dsdatos_empresa", ds2.Tables(0))
        Dim rds3 As New ReportDataSource("dslogo", ds23.Tables(0))
        Dim rds4 As New ReportDataSource("dsventasrapidas", ds24.Tables(0))

        ReportViewer1.LocalReport.DataSources.Clear()              'limpio la fuente de datos
        'ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.LocalReport.DataSources.Add(rds2)
        ReportViewer1.LocalReport.DataSources.Add(rds3)
        ReportViewer1.LocalReport.DataSources.Add(rds4)

        ' Me.ReportViewer1.RefreshReport()


        Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer1.RefreshReport()
        ' Me.ReportViewer2.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub FRNOTAVENTASRAPIDAS_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class