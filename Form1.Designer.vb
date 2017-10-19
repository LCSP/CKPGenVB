<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BW2 = New System.ComponentModel.BackgroundWorker()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.btn_verOnda = New System.Windows.Forms.Button()
        Me.txt_volumen = New System.Windows.Forms.TextBox()
        Me.txt_time = New System.Windows.Forms.TextBox()
        Me.txt_hz = New System.Windows.Forms.TextBox()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Location = New System.Drawing.Point(96, 12)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_iniciar.TabIndex = 0
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(96, 41)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(75, 23)
        Me.btn_stop.TabIndex = 1
        Me.btn_stop.Text = "Detener"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'BW2
        '
        Me.BW2.WorkerReportsProgress = True
        Me.BW2.WorkerSupportsCancellation = True
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(13, 78)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(872, 371)
        Me.pic.TabIndex = 2
        Me.pic.TabStop = False
        '
        'btn_verOnda
        '
        Me.btn_verOnda.Location = New System.Drawing.Point(178, 13)
        Me.btn_verOnda.Name = "btn_verOnda"
        Me.btn_verOnda.Size = New System.Drawing.Size(75, 23)
        Me.btn_verOnda.TabIndex = 3
        Me.btn_verOnda.Text = "Button1"
        Me.btn_verOnda.UseVisualStyleBackColor = True
        '
        'txt_volumen
        '
        Me.txt_volumen.Location = New System.Drawing.Point(648, 12)
        Me.txt_volumen.Name = "txt_volumen"
        Me.txt_volumen.Size = New System.Drawing.Size(100, 20)
        Me.txt_volumen.TabIndex = 4
        '
        'txt_time
        '
        Me.txt_time.Location = New System.Drawing.Point(542, 12)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(100, 20)
        Me.txt_time.TabIndex = 5
        '
        'txt_hz
        '
        Me.txt_hz.Location = New System.Drawing.Point(436, 12)
        Me.txt_hz.Name = "txt_hz"
        Me.txt_hz.Size = New System.Drawing.Size(100, 20)
        Me.txt_hz.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 461)
        Me.Controls.Add(Me.txt_hz)
        Me.Controls.Add(Me.txt_time)
        Me.Controls.Add(Me.txt_volumen)
        Me.Controls.Add(Me.btn_verOnda)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_iniciar As System.Windows.Forms.Button
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents btn_verOnda As System.Windows.Forms.Button
    Friend WithEvents txt_volumen As System.Windows.Forms.TextBox
    Friend WithEvents txt_time As System.Windows.Forms.TextBox
    Friend WithEvents txt_hz As System.Windows.Forms.TextBox

End Class
