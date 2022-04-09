<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstMovies = New System.Windows.Forms.ListBox()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClearCart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.btnBuyNow = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmtPaid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblRctTotal = New System.Windows.Forms.Label()
        Me.lblRctPaid = New System.Windows.Forms.Label()
        Me.lblRctChange = New System.Windows.Forms.Label()
        Me.lblCashOnly = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMovies
        '
        Me.lstMovies.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMovies.FormattingEnabled = True
        Me.lstMovies.ItemHeight = 16
        Me.lstMovies.Location = New System.Drawing.Point(12, 25)
        Me.lstMovies.Name = "lstMovies"
        Me.lstMovies.Size = New System.Drawing.Size(199, 244)
        Me.lstMovies.Sorted = True
        Me.lstMovies.TabIndex = 0
        '
        'lstCart
        '
        Me.lstCart.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 16
        Me.lstCart.Location = New System.Drawing.Point(370, 25)
        Me.lstCart.MaximumSize = New System.Drawing.Size(345, 300)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(199, 244)
        Me.lstCart.Sorted = True
        Me.lstCart.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(217, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(147, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add to Cart >"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(217, 54)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(147, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "< Remove From Cart"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnClearCart
        '
        Me.btnClearCart.Location = New System.Drawing.Point(217, 83)
        Me.btnClearCart.Name = "btnClearCart"
        Me.btnClearCart.Size = New System.Drawing.Size(147, 23)
        Me.btnClearCart.TabIndex = 4
        Me.btnClearCart.Text = "Clear Cart"
        Me.btnClearCart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DVD's:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cart:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Subtotal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sales Tax:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Shipping:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Cost:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(760, 261)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(16, 40)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSubtotal.Size = New System.Drawing.Size(73, 23)
        Me.lblSubtotal.TabIndex = 12
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(95, 40)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTax.Size = New System.Drawing.Size(73, 23)
        Me.lblTax.TabIndex = 13
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblShipping
        '
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShipping.Location = New System.Drawing.Point(174, 40)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShipping.Size = New System.Drawing.Size(73, 23)
        Me.lblShipping.TabIndex = 14
        Me.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinalTotal.Location = New System.Drawing.Point(16, 82)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFinalTotal.Size = New System.Drawing.Size(73, 23)
        Me.lblFinalTotal.TabIndex = 15
        Me.lblFinalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBuyNow
        '
        Me.btnBuyNow.Location = New System.Drawing.Point(174, 83)
        Me.btnBuyNow.Name = "btnBuyNow"
        Me.btnBuyNow.Size = New System.Drawing.Size(73, 23)
        Me.btnBuyNow.TabIndex = 16
        Me.btnBuyNow.Text = "Buy Now"
        Me.btnBuyNow.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Cash Paid:"
        '
        'txtAmtPaid
        '
        Me.txtAmtPaid.Location = New System.Drawing.Point(94, 85)
        Me.txtAmtPaid.Name = "txtAmtPaid"
        Me.txtAmtPaid.Size = New System.Drawing.Size(73, 20)
        Me.txtAmtPaid.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblShipping)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAmtPaid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnBuyNow)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblFinalTotal)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Location = New System.Drawing.Point(574, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 117)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Checkout"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRctChange)
        Me.GroupBox2.Controls.Add(Me.lblRctPaid)
        Me.GroupBox2.Controls.Add(Me.lblRctTotal)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblPennies)
        Me.GroupBox2.Controls.Add(Me.lblNickels)
        Me.GroupBox2.Controls.Add(Me.lblDimes)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblQuarters)
        Me.GroupBox2.Location = New System.Drawing.Point(574, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 107)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reciept"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(56, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Paid:"
        '
        'lblPennies
        '
        Me.lblPennies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPennies.Location = New System.Drawing.Point(159, 29)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPennies.Size = New System.Drawing.Size(44, 23)
        Me.lblPennies.TabIndex = 21
        Me.lblPennies.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNickels
        '
        Me.lblNickels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNickels.Location = New System.Drawing.Point(109, 29)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNickels.Size = New System.Drawing.Size(44, 23)
        Me.lblNickels.TabIndex = 20
        Me.lblNickels.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDimes
        '
        Me.lblDimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDimes.Location = New System.Drawing.Point(59, 29)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDimes.Size = New System.Drawing.Size(44, 23)
        Me.lblDimes.TabIndex = 19
        Me.lblDimes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Quarters"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Dimes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(156, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Pennies"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(106, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Nickels"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(139, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 10
        '
        'lblQuarters
        '
        Me.lblQuarters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuarters.Location = New System.Drawing.Point(9, 29)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQuarters.Size = New System.Drawing.Size(44, 23)
        Me.lblQuarters.TabIndex = 12
        Me.lblQuarters.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(106, 61)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 13)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Change:"
        '
        'lblRctTotal
        '
        Me.lblRctTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRctTotal.Location = New System.Drawing.Point(9, 74)
        Me.lblRctTotal.Name = "lblRctTotal"
        Me.lblRctTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRctTotal.Size = New System.Drawing.Size(44, 23)
        Me.lblRctTotal.TabIndex = 24
        Me.lblRctTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRctPaid
        '
        Me.lblRctPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRctPaid.Location = New System.Drawing.Point(59, 74)
        Me.lblRctPaid.Name = "lblRctPaid"
        Me.lblRctPaid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRctPaid.Size = New System.Drawing.Size(44, 23)
        Me.lblRctPaid.TabIndex = 23
        Me.lblRctPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRctChange
        '
        Me.lblRctChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRctChange.Location = New System.Drawing.Point(109, 74)
        Me.lblRctChange.Name = "lblRctChange"
        Me.lblRctChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRctChange.Size = New System.Drawing.Size(44, 23)
        Me.lblRctChange.TabIndex = 23
        Me.lblRctChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCashOnly
        '
        Me.lblCashOnly.AutoSize = True
        Me.lblCashOnly.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCashOnly.Location = New System.Drawing.Point(610, 134)
        Me.lblCashOnly.Name = "lblCashOnly"
        Me.lblCashOnly.Size = New System.Drawing.Size(195, 13)
        Me.lblCashOnly.TabIndex = 23
        Me.lblCashOnly.Text = "Please Remember We Only Take Cash!"
        Me.lblCashOnly.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 287)
        Me.Controls.Add(Me.lblCashOnly)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClearCart)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.lstMovies)
        Me.Name = "Form1"
        Me.Text = "Shopping Cart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMovies As ListBox
    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClearCart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents btnBuyNow As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmtPaid As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblPennies As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblRctChange As Label
    Friend WithEvents lblRctPaid As Label
    Friend WithEvents lblRctTotal As Label
    Friend WithEvents lblCashOnly As Label
End Class
