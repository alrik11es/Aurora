﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarEquipos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarEquipos))
        Me.listadoEquipos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ctMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'listadoEquipos
        '
        Me.listadoEquipos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.listadoEquipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listadoEquipos.Location = New System.Drawing.Point(0, 0)
        Me.listadoEquipos.Name = "listadoEquipos"
        Me.listadoEquipos.Size = New System.Drawing.Size(574, 403)
        Me.listadoEquipos.SmallImageList = Me.imgList
        Me.listadoEquipos.TabIndex = 0
        Me.listadoEquipos.UseCompatibleStateImageBehavior = False
        Me.listadoEquipos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre equipo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Localización"
        '
        'ctMenu
        '
        Me.ctMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.EditarToolStripMenuItem, Me.BorrarToolStripMenuItem})
        Me.ctMenu.Name = "ContextMenuStrip1"
        Me.ctMenu.Size = New System.Drawing.Size(116, 70)
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "server.png")
        Me.imgList.Images.SetKeyName(1, "computer.png")
        Me.imgList.Images.SetKeyName(2, "printer.png")
        Me.imgList.Images.SetKeyName(3, "router.png")
        Me.imgList.Images.SetKeyName(4, "switch_icon.png")
        Me.imgList.Images.SetKeyName(5, "image.png")
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.server
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.server_edit
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Image = Global.Aurora.My.Resources.Resources.server_delete
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'frmListarEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 403)
        Me.Controls.Add(Me.listadoEquipos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListarEquipos"
        Me.Text = "Listado de equipos"
        Me.ctMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listadoEquipos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ctMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imgList As System.Windows.Forms.ImageList
End Class
