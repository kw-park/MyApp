<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitSetting
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
        Me.btnList = New System.Windows.Forms.Button()
        Me.dgvDataList = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvDataList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(13, 12)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 1
        Me.btnList.Text = "List(&L)"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'dgvDataList
        '
        Me.dgvDataList.AllowUserToOrderColumns = True
        Me.dgvDataList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataList.Location = New System.Drawing.Point(13, 42)
        Me.dgvDataList.Name = "dgvDataList"
        Me.dgvDataList.RowTemplate.Height = 21
        Me.dgvDataList.Size = New System.Drawing.Size(344, 171)
        Me.dgvDataList.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(95, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update(&U)"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'InitSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 225)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvDataList)
        Me.Controls.Add(Me.btnList)
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "InitSetting"
        Me.Text = "Initial setting"
        CType(Me.dgvDataList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnList As Button
    Friend WithEvents dgvDataList As DataGridView
    Friend WithEvents btnUpdate As Button
End Class
