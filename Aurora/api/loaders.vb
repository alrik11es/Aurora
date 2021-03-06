﻿Imports MySql.Data.MySqlClient

Module loaders

    Public Sub cargaListado(query As String, campo_a_mostrar As String, listado As ListView)
        Dim recordset As MySqlDataReader = frmPrincipal.conexion.exec(query)

        Dim id As Integer
        listado.Clear()

        If recordset.HasRows Then
            Do
                Try
                    id = recordset.GetString("id")
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                End Try

                Dim item As ListViewItem = New ListViewItem()
                item.Tag = id
                item.Text = recordset.GetString(campo_a_mostrar)

                If id Mod 2 = 0 Then
                    item.ImageIndex = 0
                Else
                    item.ImageIndex = 1
                End If
                listado.Items.Add(item)
                'recordset.NextResult()
            Loop While recordset.Read()
        End If
        recordset.Close()
    End Sub

    Public Sub cargaListadoEquipos(query As String, campo_a_mostrar As String, listado As ListView)
        Dim recordset As MySqlDataReader = frmPrincipal.conexion.exec(query)

        Dim id As Integer
        listado.Clear()
        If recordset.HasRows Then
            Do
                id = recordset.GetString("id")
                Dim item As ListViewItem = New ListViewItem()
                item.Tag = id
                item.Text = recordset.GetString(campo_a_mostrar)
                item.ImageIndex = recordset.GetString("tipo")
                item.SubItems.Add(recordset.GetString("empresa"))
                listado.Items.Add(item)
            Loop While recordset.Read()

            Dim columna As ColumnHeader

            columna = New ColumnHeader()
            columna.Text = "Nombre de equipo"
            columna.Width = 200
            listado.Columns.Add(columna)

            columna = New ColumnHeader()
            columna.Text = "Localizacion"
            columna.Width = 200
            listado.Columns.Add(columna)

        End If
        recordset.Close()

    End Sub
End Module
