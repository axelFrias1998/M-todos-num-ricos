<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fraiz
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fraiz))
        Me.Li = New System.Windows.Forms.Label()
        Me.Lc = New System.Windows.Forms.Label()
        Me.Ti = New System.Windows.Forms.TextBox()
        Me.Tc = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.td = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Li
        '
        Me.Li.AutoSize = True
        Me.Li.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Li.Location = New System.Drawing.Point(12, 48)
        Me.Li.Name = "Li"
        Me.Li.Size = New System.Drawing.Size(62, 13)
        Me.Li.TabIndex = 0
        Me.Li.Text = "Dame inicio"
        '
        'Lc
        '
        Me.Lc.AutoSize = True
        Me.Lc.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lc.Location = New System.Drawing.Point(206, 48)
        Me.Lc.Name = "Lc"
        Me.Lc.Size = New System.Drawing.Size(63, 13)
        Me.Lc.TabIndex = 1
        Me.Lc.Text = "Dame cifras"
        '
        'Ti
        '
        Me.Ti.Location = New System.Drawing.Point(81, 45)
        Me.Ti.Name = "Ti"
        Me.Ti.Size = New System.Drawing.Size(100, 20)
        Me.Ti.TabIndex = 2
        '
        'Tc
        '
        Me.Tc.Location = New System.Drawing.Point(276, 45)
        Me.Tc.Name = "Tc"
        Me.Tc.Size = New System.Drawing.Size(100, 20)
        Me.Tc.TabIndex = 3
        '
        'Calcular
        '
        Me.Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Calcular.Location = New System.Drawing.Point(430, 43)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Salir.Location = New System.Drawing.Point(511, 43)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(292, 90)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(294, 166)
        Me.Salida.TabIndex = 6
        '
        'Column1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Índice"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Raíz"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Error"
        Me.Column3.Name = "Column3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox2.Location = New System.Drawing.Point(-3, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(635, 290)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(91, 15)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Dame funcion:"
        '
        'td
        '
        Me.td.Location = New System.Drawing.Point(291, 15)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(100, 20)
        Me.td.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(206, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Dame derivada:"
        '
        'tr
        '
        Me.tr.Location = New System.Drawing.Point(133, 240)
        Me.tr.Name = "tr"
        Me.tr.Size = New System.Drawing.Size(100, 20)
        Me.tr.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(63, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "La raíz es:"
        '
        'Fraiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(632, 287)
        Me.Controls.Add(Me.tr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.td)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Tc)
        Me.Controls.Add(Me.Ti)
        Me.Controls.Add(Me.Lc)
        Me.Controls.Add(Me.Li)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Fraiz"
        Me.Text = "Raíz de dos"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Li As Label
    Friend WithEvents Lc As Label
    Friend WithEvents Ti As TextBox
    Friend WithEvents Tc As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents tf As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents td As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tr As TextBox
    Friend WithEvents Label4 As Label
End Class
