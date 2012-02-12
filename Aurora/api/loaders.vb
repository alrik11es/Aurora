Module loaders

    Public Sub cargaListado(query As String, campo_a_mostrar As String, listado As ListView)
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec(query)
        Dim id As Integer
        listado.Clear()
        Do Until recordset.EOF
            id = recordset.Fields("id").Value
            Dim item As ListViewItem = New ListViewItem()
            item.Tag = id
            item.Text = recordset.Fields(campo_a_mostrar).Value
            If id Mod 2 = 0 Then
                item.ImageIndex = 0
            Else
                item.ImageIndex = 1
            End If
            listado.Items.Add(item)
            recordset.MoveNext()
        Loop
    End Sub

    Public Sub cargaListadoEquipos(query As String, campo_a_mostrar As String, listado As ListView)
        Dim recordset As ADODB.Recordset = frmPrincipal.conexion.exec(query)
        Dim id As Integer
        listado.Clear()
        Do Until recordset.EOF
            id = recordset.Fields("id").Value
            Dim item As ListViewItem = New ListViewItem()
            item.Tag = id
            item.Text = recordset.Fields(campo_a_mostrar).Value
            item.ImageIndex = recordset.Fields("tipo").Value
            listado.Items.Add(item)
            recordset.MoveNext()
        Loop
    End Sub
End Module
