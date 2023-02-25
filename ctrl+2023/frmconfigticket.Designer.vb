<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconfigticket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconfigticket))
        Me.cbcontenido = New System.Windows.Forms.ComboBox()
        Me.cbtitulo = New System.Windows.Forms.ComboBox()
        Me.cbfuente = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.p3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.pbabrir = New System.Windows.Forms.Button()
        Me.logoticket = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.pbguardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logoticket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbcontenido
        '
        Me.cbcontenido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcontenido.FormattingEnabled = True
        Me.cbcontenido.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cbcontenido.Location = New System.Drawing.Point(152, 116)
        Me.cbcontenido.Name = "cbcontenido"
        Me.cbcontenido.Size = New System.Drawing.Size(75, 21)
        Me.cbcontenido.TabIndex = 19
        '
        'cbtitulo
        '
        Me.cbtitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtitulo.FormattingEnabled = True
        Me.cbtitulo.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cbtitulo.Location = New System.Drawing.Point(152, 89)
        Me.cbtitulo.Name = "cbtitulo"
        Me.cbtitulo.Size = New System.Drawing.Size(75, 21)
        Me.cbtitulo.TabIndex = 18
        '
        'cbfuente
        '
        Me.cbfuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbfuente.FormattingEnabled = True
        Me.cbfuente.Items.AddRange(New Object() {"Arial", "Times New Roman", "True Type"})
        Me.cbfuente.Location = New System.Drawing.Point(152, 63)
        Me.cbfuente.Name = "cbfuente"
        Me.cbfuente.Size = New System.Drawing.Size(154, 21)
        Me.cbfuente.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Fuente y tamaño"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Tamaño contenido"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(86, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Fuente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbcontenido)
        Me.GroupBox2.Controls.Add(Me.cbtitulo)
        Me.GroupBox2.Controls.Add(Me.cbfuente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(59, 221)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 192)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Tamaño titulo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.p1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.p2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.p3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 192)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Posición (0 - 100)"
        '
        'p1
        '
        Me.p1.Location = New System.Drawing.Point(172, 64)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(84, 20)
        Me.p1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "FOLIO"
        '
        'p2
        '
        Me.p2.Location = New System.Drawing.Point(172, 90)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(84, 20)
        Me.p2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Actividades"
        '
        'p3
        '
        Me.p3.Location = New System.Drawing.Point(172, 116)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(84, 20)
        Me.p3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre Empresa"
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(887, 72)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(263, 20)
        Me.txtruta.TabIndex = 27
        Me.txtruta.WordWrap = False
        '
        'pbabrir
        '
        Me.pbabrir.BackColor = System.Drawing.Color.White
        Me.pbabrir.ForeColor = System.Drawing.Color.White
        Me.pbabrir.Location = New System.Drawing.Point(887, 337)
        Me.pbabrir.Name = "pbabrir"
        Me.pbabrir.Size = New System.Drawing.Size(120, 39)
        Me.pbabrir.TabIndex = 25
        Me.pbabrir.Text = "Abrir"
        Me.pbabrir.UseVisualStyleBackColor = False
        '
        'logoticket
        '
        Me.logoticket.BackColor = System.Drawing.Color.White
        Me.logoticket.Location = New System.Drawing.Point(887, 98)
        Me.logoticket.Name = "logoticket"
        Me.logoticket.Size = New System.Drawing.Size(263, 223)
        Me.logoticket.TabIndex = 24
        Me.logoticket.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(217, 482)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 39)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Previsualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(104, 482)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 39)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Aplicar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(901, 398)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(249, 228)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'pbguardar
        '
        Me.pbguardar.BackColor = System.Drawing.Color.Crimson
        Me.pbguardar.ForeColor = System.Drawing.Color.White
        Me.pbguardar.Location = New System.Drawing.Point(1030, 337)
        Me.pbguardar.Name = "pbguardar"
        Me.pbguardar.Size = New System.Drawing.Size(120, 39)
        Me.pbguardar.TabIndex = 26
        Me.pbguardar.Text = "Guardar"
        Me.pbguardar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(458, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 570)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'frmconfigticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1209, 644)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtruta)
        Me.Controls.Add(Me.pbabrir)
        Me.Controls.Add(Me.logoticket)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.pbguardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmconfigticket"
        Me.Text = "frmconfigticket"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logoticket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbcontenido As ComboBox
    Friend WithEvents cbtitulo As ComboBox
    Friend WithEvents cbfuente As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents p1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents p2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents p3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtruta As TextBox
    Friend WithEvents pbabrir As Button
    Friend WithEvents logoticket As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents pbguardar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
