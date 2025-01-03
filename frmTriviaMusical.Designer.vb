<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriviaMusical
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTriviaMusical))
        Me.btnResponder = New System.Windows.Forms.Button()
        Me.lblTriviaM = New System.Windows.Forms.Label()
        Me.bbTriviaM = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblBajo = New System.Windows.Forms.Label()
        CType(Me.bbTriviaM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnResponder
        '
        Me.btnResponder.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnResponder.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResponder.ForeColor = System.Drawing.Color.IndianRed
        Me.btnResponder.Location = New System.Drawing.Point(126, 281)
        Me.btnResponder.Name = "btnResponder"
        Me.btnResponder.Size = New System.Drawing.Size(117, 49)
        Me.btnResponder.TabIndex = 0
        Me.btnResponder.Text = "&Responder"
        Me.btnResponder.UseVisualStyleBackColor = False
        '
        'lblTriviaM
        '
        Me.lblTriviaM.Font = New System.Drawing.Font("Calisto MT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriviaM.Location = New System.Drawing.Point(32, 53)
        Me.lblTriviaM.Name = "lblTriviaM"
        Me.lblTriviaM.Size = New System.Drawing.Size(186, 126)
        Me.lblTriviaM.TabIndex = 2
        Me.lblTriviaM.Text = "Que Instrumento para tocar Rock an Roll suele ejecutarse con movimientos precisos" &
    " y firmes del dedo pulgar?"
        '
        'bbTriviaM
        '
        Me.bbTriviaM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bbTriviaM.Image = CType(resources.GetObject("bbTriviaM.Image"), System.Drawing.Image)
        Me.bbTriviaM.Location = New System.Drawing.Point(235, 31)
        Me.bbTriviaM.Name = "bbTriviaM"
        Me.bbTriviaM.Size = New System.Drawing.Size(233, 228)
        Me.bbTriviaM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bbTriviaM.TabIndex = 3
        Me.bbTriviaM.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSalir.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.IndianRed
        Me.btnSalir.Location = New System.Drawing.Point(278, 281)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(117, 49)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblBajo
        '
        Me.lblBajo.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBajo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBajo.Location = New System.Drawing.Point(32, 179)
        Me.lblBajo.Name = "lblBajo"
        Me.lblBajo.Size = New System.Drawing.Size(61, 27)
        Me.lblBajo.TabIndex = 5
        Me.lblBajo.Text = "El bajo"
        Me.lblBajo.Visible = False
        '
        'frmTriviaMusical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(517, 353)
        Me.Controls.Add(Me.lblBajo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.bbTriviaM)
        Me.Controls.Add(Me.lblTriviaM)
        Me.Controls.Add(Me.btnResponder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmTriviaMusical"
        Me.Text = "Trivia Musical"
        CType(Me.bbTriviaM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnResponder As Button
    Friend WithEvents lblTriviaM As Label
    Friend WithEvents bbTriviaM As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblBajo As Label
End Class
