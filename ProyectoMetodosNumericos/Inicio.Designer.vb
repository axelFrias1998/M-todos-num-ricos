<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrimerParcialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaízDeDosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImparesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BisecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewtonRaphsonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReglaFalsaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegundoParcialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JacobiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TercerParcialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimerParcialToolStripMenuItem, Me.SegundoParcialToolStripMenuItem, Me.TercerParcialToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(349, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrimerParcialToolStripMenuItem
        '
        Me.PrimerParcialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RaízDeDosToolStripMenuItem, Me.ImparesToolStripMenuItem, Me.BisecciónToolStripMenuItem, Me.NewtonRaphsonToolStripMenuItem, Me.ReglaFalsaToolStripMenuItem})
        Me.PrimerParcialToolStripMenuItem.Name = "PrimerParcialToolStripMenuItem"
        Me.PrimerParcialToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.PrimerParcialToolStripMenuItem.Text = "Primer parcial"
        '
        'RaízDeDosToolStripMenuItem
        '
        Me.RaízDeDosToolStripMenuItem.Name = "RaízDeDosToolStripMenuItem"
        Me.RaízDeDosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RaízDeDosToolStripMenuItem.Text = "Raíz de dos"
        '
        'ImparesToolStripMenuItem
        '
        Me.ImparesToolStripMenuItem.Name = "ImparesToolStripMenuItem"
        Me.ImparesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImparesToolStripMenuItem.Text = "Impares"
        '
        'BisecciónToolStripMenuItem
        '
        Me.BisecciónToolStripMenuItem.Name = "BisecciónToolStripMenuItem"
        Me.BisecciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BisecciónToolStripMenuItem.Text = "Bisección"
        '
        'NewtonRaphsonToolStripMenuItem
        '
        Me.NewtonRaphsonToolStripMenuItem.Name = "NewtonRaphsonToolStripMenuItem"
        Me.NewtonRaphsonToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewtonRaphsonToolStripMenuItem.Text = "Newton Raphson"
        '
        'ReglaFalsaToolStripMenuItem
        '
        Me.ReglaFalsaToolStripMenuItem.Name = "ReglaFalsaToolStripMenuItem"
        Me.ReglaFalsaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReglaFalsaToolStripMenuItem.Text = "Regla falsa"
        '
        'SegundoParcialToolStripMenuItem
        '
        Me.SegundoParcialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JacobiToolStripMenuItem})
        Me.SegundoParcialToolStripMenuItem.Name = "SegundoParcialToolStripMenuItem"
        Me.SegundoParcialToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.SegundoParcialToolStripMenuItem.Text = "Segundo parcial"
        '
        'JacobiToolStripMenuItem
        '
        Me.JacobiToolStripMenuItem.Name = "JacobiToolStripMenuItem"
        Me.JacobiToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.JacobiToolStripMenuItem.Text = "Jacobi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Axel Frías Hernández"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Programas métodos numéricos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(258, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "2NV50"
        '
        'TercerParcialToolStripMenuItem
        '
        Me.TercerParcialToolStripMenuItem.Name = "TercerParcialToolStripMenuItem"
        Me.TercerParcialToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.TercerParcialToolStripMenuItem.Text = "Tercer parcial"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(130, 125)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(349, 160)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrimerParcialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaízDeDosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImparesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BisecciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewtonRaphsonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReglaFalsaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegundoParcialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents JacobiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TercerParcialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Salir As Button
End Class
