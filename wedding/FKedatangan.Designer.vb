﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKedatangan
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
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TextBoxScanBarcode = New System.Windows.Forms.TextBox()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.LabelGreeting = New System.Windows.Forms.Label()
        Me.LabelBarcode = New System.Windows.Forms.Label()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.LabelFont = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(179, 220)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(55, 23)
        Me.LblNama.TabIndex = 1
        Me.LblNama.Text = "Nama"
        '
        'TextBoxScanBarcode
        '
        Me.TextBoxScanBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxScanBarcode.Location = New System.Drawing.Point(240, 216)
        Me.TextBoxScanBarcode.Multiline = True
        Me.TextBoxScanBarcode.Name = "TextBoxScanBarcode"
        Me.TextBoxScanBarcode.Size = New System.Drawing.Size(244, 32)
        Me.TextBoxScanBarcode.TabIndex = 2
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(504, 216)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(81, 32)
        Me.ButtonEnter.TabIndex = 3
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'LabelGreeting
        '
        Me.LabelGreeting.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGreeting.Location = New System.Drawing.Point(12, 38)
        Me.LabelGreeting.Name = "LabelGreeting"
        Me.LabelGreeting.Size = New System.Drawing.Size(717, 117)
        Me.LabelGreeting.TabIndex = 4
        Me.LabelGreeting.Text = "--"
        Me.LabelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelBarcode
        '
        Me.LabelBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBarcode.Location = New System.Drawing.Point(12, 281)
        Me.LabelBarcode.Name = "LabelBarcode"
        Me.LabelBarcode.Size = New System.Drawing.Size(717, 98)
        Me.LabelBarcode.TabIndex = 5
        Me.LabelBarcode.Text = "--"
        Me.LabelBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(591, 216)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(81, 32)
        Me.ButtonPrint.TabIndex = 6
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        Me.ButtonPrint.Visible = False
        '
        'LabelFont
        '
        Me.LabelFont.BackColor = System.Drawing.Color.White
        Me.LabelFont.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFont.ForeColor = System.Drawing.Color.Black
        Me.LabelFont.Location = New System.Drawing.Point(678, 218)
        Me.LabelFont.Name = "LabelFont"
        Me.LabelFont.Size = New System.Drawing.Size(39, 29)
        Me.LabelFont.TabIndex = 7
        Me.LabelFont.Text = "--"
        Me.LabelFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelFont.Visible = False
        '
        'FKedatangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelFont)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.LabelBarcode)
        Me.Controls.Add(Me.LabelGreeting)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.TextBoxScanBarcode)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "FKedatangan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TextBoxScanBarcode As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEnter As System.Windows.Forms.Button
    Friend WithEvents LabelGreeting As System.Windows.Forms.Label
    Friend WithEvents LabelBarcode As System.Windows.Forms.Label
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents LabelFont As System.Windows.Forms.Label
End Class
