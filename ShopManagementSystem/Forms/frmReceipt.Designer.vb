<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceipt
    Inherits System.Windows.Forms.Form

    'Form/UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer. Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ppcReceipt = New System.Windows.Forms.PrintPreviewControl()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSavePdf = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmReceipt
        '
        Me.Controls.Add(Me.ppcReceipt)
        Me.Controls.Add(Me.pnlButtons)
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(420, 640)
        Me.MinimizeBox = False
        Me.ShowInTaskbar = False
        Me.Text = "Receipt"
        Me.Name = "frmReceipt"
        '
        'ppcReceipt
        '
        Me.ppcReceipt.AutoZoom = True
        Me.ppcReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ppcReceipt.Location = New System.Drawing.Point(0, 0)
        Me.ppcReceipt.Size = New System.Drawing.Size(420, 580)
        Me.ppcReceipt.UseAntiAlias = True
        Me.ppcReceipt.Name = "ppcReceipt"
        Me.ppcReceipt.TabIndex = 0
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnPrint)
        Me.pnlButtons.Controls.Add(Me.btnSavePdf)
        Me.pnlButtons.Controls.Add(Me.btnClose)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Size = New System.Drawing.Size(100, 60)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.TabIndex = 1
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(12, 11)
        Me.btnPrint.Size = New System.Drawing.Size(120, 38)
        Me.btnPrint.Text = "🖨  Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.TabIndex = 0
        '
        'btnSavePdf
        '
        Me.btnSavePdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnSavePdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavePdf.FlatAppearance.BorderSize = 0
        Me.btnSavePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePdf.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePdf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSavePdf.Location = New System.Drawing.Point(142, 11)
        Me.btnSavePdf.Size = New System.Drawing.Size(150, 38)
        Me.btnSavePdf.Text = "Save as PDF"
        Me.btnSavePdf.UseVisualStyleBackColor = False
        Me.btnSavePdf.Name = "btnSavePdf"
        Me.btnSavePdf.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(302, 11)
        Me.btnClose.Size = New System.Drawing.Size(100, 38)
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 2
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents ppcReceipt As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSavePdf As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
