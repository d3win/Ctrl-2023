﻿Imports MySql.Data.MySqlClient
Public Class FRventaporclientevinil
    Public idbusquedacliente As Integer
    Function cerrarconexion()
        If conexionMysql.State = ConnectionState.Open Then
            conexionMysql.Close()

        End If
    End Function

    Private Sub FRventaporclientevinil_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'recogemos el valor de quien es el que solicita el servicio



        stxtlistaclientes.Visible = False

    End Sub

    Private Sub Stxtlistaclientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stxtlistaclientes.SelectedIndexChanged
        'stxtcliente.Text = stxtlistaclientes.Text
        'stxtlistaclientes.Visible = False
        'stxtdescripcion.Focus()


    End Sub
    Function cargardatos()
        cerrarconexion()

        stxtfolio.Text = ""
        Try

            grilla.Rows.Clear()
            grilla2.Rows.Clear()
            grilla2.Visible = False
        Catch ex As Exception

        End Try


        Dim idcliente As Integer
        conexionMysql.Open()
        Try
            cerrarconexion()
            conexionMysql.Open()
            Dim Sql31 As String
            'consultamos el id del cliente para obtener un registro de quien es al que se le esta vendiendo
            Sql31 = "select idcliente from cliente where concat(nombre, ' ',ap, ' ', am) like '%" & stxtcliente.Text & "%';"
            Dim cmd31 As New MySqlCommand(Sql31, conexionMysql)
            reader = cmd31.ExecuteReader()
            reader.Read()
            idcliente = reader.GetString(0).ToString()
            conexionMysql.Close()
            'MsgBox(idcliente)
        Catch ex As Exception
            idcliente = 1
            '-MsgBox(idcliente)
        End Try
        conexionMysql.Close()


        cerrarconexion()

        conexionMysql.Open()
        Dim Sql As String
        '-------------------------------EL TIPO DE VENTA ES 2: QUE CORRESPONDE A SERVICIOS UNICAMENTE
        Sql = "select idventa,fecha,hora from venta where idcliente=" & idcliente & " and tipoventa=3;"
        Dim cmd As New MySqlCommand(Sql, conexionMysql)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        'cargamos el formulario  resumen
        da.Fill(dt)
        grilla.DataSource = dt
        'grilla.Columns(1).Width = 700
        'grilla.Columns(0).Width = 100
        'grilla.Columns(2).Width = 70
        'grilla2.Columns(3).Width = 70
        'grilla2.Columns(4).Width = 70
        'grilla2.Columns(5).Width = 70
        'grilla2.Columns(6).Width = 70
        'grilla2.Columns(7).Width = 70

        conexionMysql.Close()
    End Function

    Private Sub Grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

        cargarventaind()
    End Sub
    Function cargarventaind()
        Try
            grilla2.Visible = True

            Dim Variable As String = grilla.Item(0, grilla.CurrentRow.Index).Value
            'MsgBox(Variable)
            'txtclavep.Text = Variable
            'grilla2p.Visible = False
            'grillap.Visible = True
            'rbclavep.Checked = True
            stxtfolio.Text = Variable
            '--------------ahora buscamos el id del servicio y lo agregamos a la grilla

            conexionMysql.Open()
            Dim Sql As String
            '-------------------------------EL TIPO DE VENTA ES 2: QUE CORRESPONDE A SERVICIOS UNICAMENTE
            Sql = "select idventaind,actividad,descripcion,cantidad,costo,ancho,alto,cm2,valor from ventaind where idventa='" & Variable & "';"
            Dim cmd As New MySqlCommand(Sql, conexionMysql)
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(cmd)
            'cargamos el formulario  resumen
            da.Fill(dt)
            grilla2.DataSource = dt
            'grilla.Columns(1).Width = 700
            'grilla.Columns(0).Width = 100
            'grilla.Columns(2).Width = 70
            'grilla2.Columns(3).Width = 70
            'grilla2.Columns(4).Width = 70
            'grilla2.Columns(5).Width = 70
            'grilla2.Columns(6).Width = 70
            'grilla2.Columns(7).Width = 70

            conexionMysql.Close()

        Catch ex As Exception

        End Try

    End Function

    Private Sub grilla_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla.CellMouseClick
        cargarventaind()
    End Sub
End Class