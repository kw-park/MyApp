<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tagEnv = New System.Windows.Forms.TabPage()
        Me.tagMenu = New System.Windows.Forms.TabPage()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tagEnv.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tagMenu)
        Me.TabControl1.Controls.Add(Me.tagEnv)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 0
        '
        'tagEnv
        '
        Me.tagEnv.Controls.Add(Me.btnInit)
        Me.tagEnv.Location = New System.Drawing.Point(4, 22)
        Me.tagEnv.Name = "tagEnv"
        Me.tagEnv.Padding = New System.Windows.Forms.Padding(3)
        Me.tagEnv.Size = New System.Drawing.Size(792, 424)
        Me.tagEnv.TabIndex = 0
        Me.tagEnv.Text = "Env"
        Me.tagEnv.UseVisualStyleBackColor = True
        '
        'tagMenu
        '
        Me.tagMenu.Location = New System.Drawing.Point(4, 22)
        Me.tagMenu.Name = "tagMenu"
        Me.tagMenu.Padding = New System.Windows.Forms.Padding(3)
        Me.tagMenu.Size = New System.Drawing.Size(792, 424)
        Me.tagMenu.TabIndex = 1
        Me.tagMenu.Text = "Menu"
        Me.tagMenu.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(9, 7)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(75, 23)
        Me.btnInit.TabIndex = 0
        Me.btnInit.Text = "Init(&I)"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        Me.TabControl1.ResumeLayout(False)
        Me.tagEnv.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tagEnv As TabPage
    Friend WithEvents tagMenu As TabPage
    Friend WithEvents btnInit As Button
End Class
