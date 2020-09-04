<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Check
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Check))
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btngames = New System.Windows.Forms.Button()
        Me.btnpathfile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtb
        '
        Me.rtb.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb.Location = New System.Drawing.Point(3, 71)
        Me.rtb.Name = "rtb"
        Me.rtb.ReadOnly = True
        Me.rtb.Size = New System.Drawing.Size(526, 267)
        Me.rtb.TabIndex = 0
        Me.rtb.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter game path:"
        '
        'txtpath
        '
        Me.txtpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpath.Location = New System.Drawing.Point(8, 33)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(193, 26)
        Me.txtpath.TabIndex = 6
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Blue
        Me.btnadd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.Yellow
        Me.btnadd.Location = New System.Drawing.Point(207, 27)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(80, 38)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnexit.Location = New System.Drawing.Point(407, 344)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(122, 46)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btngames
        '
        Me.btngames.BackColor = System.Drawing.Color.DodgerBlue
        Me.btngames.Enabled = False
        Me.btngames.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngames.ForeColor = System.Drawing.Color.SpringGreen
        Me.btngames.Location = New System.Drawing.Point(3, 344)
        Me.btngames.Name = "btngames"
        Me.btngames.Size = New System.Drawing.Size(120, 46)
        Me.btngames.TabIndex = 10
        Me.btngames.Text = "GAMES"
        Me.btngames.UseVisualStyleBackColor = False
        Me.btngames.Visible = False
        '
        'btnpathfile
        '
        Me.btnpathfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnpathfile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpathfile.ForeColor = System.Drawing.Color.Yellow
        Me.btnpathfile.Location = New System.Drawing.Point(306, 27)
        Me.btnpathfile.Name = "btnpathfile"
        Me.btnpathfile.Size = New System.Drawing.Size(181, 38)
        Me.btnpathfile.TabIndex = 11
        Me.btnpathfile.Text = "Open Path.txt"
        Me.btnpathfile.UseVisualStyleBackColor = False
        '
        'Check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 397)
        Me.Controls.Add(Me.btnpathfile)
        Me.Controls.Add(Me.btngames)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpath)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.rtb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Check"
        Me.Text = "Gaming Checkpost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtb As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpath As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btngames As Button
    Friend WithEvents btnpathfile As System.Windows.Forms.Button
End Class
