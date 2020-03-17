<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fimpares
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
        Me.ln = New System.Windows.Forms.Label()
        Me.Tn = New System.Windows.Forms.TextBox()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ln
        '
        Me.ln.AutoSize = True
        Me.ln.Location = New System.Drawing.Point(49, 45)
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(130, 13)
        Me.ln.TabIndex = 0
        Me.ln.Text = "Dame número de impares:"
        '
        'Tn
        '
        Me.Tn.Location = New System.Drawing.Point(185, 42)
        Me.Tn.Name = "Tn"
        Me.Tn.Size = New System.Drawing.Size(100, 20)
        Me.Tn.TabIndex = 1
        '
        'Salida
        '
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.Salida.Location = New System.Drawing.Point(152, 103)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(246, 150)
        Me.Salida.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Índice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Impares"
        Me.Column2.Name = "Column2"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(317, 40)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 3
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(407, 40)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 4
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Fimpares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(560, 291)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Tn)
        Me.Controls.Add(Me.ln)
        Me.Name = "Fimpares"
        Me.Text = "Impares"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ln As Label
    Friend WithEvents Tn As TextBox
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
End Class
