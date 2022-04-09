'4. Use Option Strict'
Option Strict On
Public Class Form1

    Dim selectedMovie As String
    Dim subtotal As Double
    Dim tax As Double
    Dim totalShipping As Double
    Dim distributorLocation As String
    Dim finalTotal As Double
    Dim amtPaid As Double
    Dim difference As Double

    '1. An Enum for quarters, dimes, nickels and pennies. Set the integer value to the coins value.'
    Enum coinValues
        quarter = 25
        dime = 10
        nickel = 5
        penny = 1
    End Enum

    '3. A function to determine the amount of quarters, dimes, nickels and pennies.'
    Private Function calculateExactChange(change As Double) As Double
        Dim quarters As Integer
        Dim dimes As Integer
        Dim nickels As Integer
        Dim pennies As Integer

        '4. Integer division (within each of the following 4 coin calculations)'
        lblQuarters.Text = (Convert.ToInt32(change * 100) \ Convert.ToInt32(coinValues.quarter)).ToString
        quarters = Convert.ToInt32(lblQuarters.Text)

        lblDimes.Text = ((Convert.ToInt32(change * 100) - (quarters * Convert.ToInt32(coinValues.quarter))) \ Convert.ToInt32(coinValues.dime)).ToString
        dimes = Convert.ToInt32(lblDimes.Text)

        lblNickels.Text = (((Convert.ToInt32(change * 100) - (quarters * Convert.ToInt32(coinValues.quarter))) - (dimes * Convert.ToInt32(coinValues.dime))) \ Convert.ToInt32(coinValues.nickel)).ToString
        nickels = Convert.ToInt32(lblNickels.Text)

        lblPennies.Text = ((((Convert.ToInt32(change * 100) - (quarters * Convert.ToInt32(coinValues.quarter))) - (dimes * Convert.ToInt32(coinValues.dime))) - (nickels * Convert.ToInt32(coinValues.nickel))) \ Convert.ToInt32(coinValues.penny)).ToString
        pennies = Convert.ToInt32(lblPennies.Text)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lstMovies.Items.Add("Finding Nemo")
        lstMovies.Items.Add("Cars")
        lstMovies.Items.Add("Spider Man (2002)")
        lstMovies.Items.Add("The Dark Knight")
        lstMovies.Items.Add("Avatar")
        lstMovies.Items.Add("Shrek 2")
        lstMovies.Items.Add("Frozen")
        lstMovies.Items.Add("The Little Mermaid")
        lstMovies.Items.Add("The Lion King")
        lstMovies.Items.Add("Shrek")
    End Sub

    Private Sub btnAdd_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAdd.MouseClick
        Dim price As Double
        Dim shipping As Double

        If lstMovies.SelectedIndex = -1 Then
            selectedMovie = ""
        Else
            selectedMovie = lstMovies.SelectedItem.ToString.Trim
        End If

        If selectedMovie = "Finding Nemo" Then
            price = 9.99
            distributorLocation = "North Carolina"
        ElseIf selectedMovie = "Cars" Then
            price = 21.5
            distributorLocation = "North Carolina"
        ElseIf selectedMovie = "Spider Man (2002)" Then
            price = 4.99
            distributorLocation = "North Carolina"
        ElseIf selectedMovie = "The Dark Knight" Then
            price = 19.99
            distributorLocation = "Wisconson"
        ElseIf selectedMovie = "Avatar" Then
            price = 8.5
            distributorLocation = "Wisconson"
        ElseIf selectedMovie = "Shrek 2" Then
            price = 2.99
            distributorLocation = "Wisconson"
        ElseIf selectedMovie = "Frozen" Then
            price = 12.99
            distributorLocation = "California"
        ElseIf selectedMovie = "The Little Mermaid" Then
            price = 13.75
            distributorLocation = "California"
        ElseIf selectedMovie = "The Lion King" Then
            price = 14.99
            distributorLocation = "California"
        ElseIf selectedMovie = "Shrek" Then
            price = 7.99
            distributorLocation = "Texas"
        End If

        If selectedMovie.ToString IsNot "" Then
            lstCart.Items.Add(selectedMovie.ToString.PadRight(36) & price.ToString("C2").PadLeft(6))
        End If


        If lstMovies.SelectedIndex = -1 Then
            MessageBox.Show("Can't add a product, nothing was selected from the DVD's list.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Error)
            distributorLocation = ""
        Else

            If distributorLocation.Contains("North Carolina") Then
                shipping = 1.0
            ElseIf distributorLocation.Contains("Wisconson") Then
                shipping = 2.5
            ElseIf distributorLocation.Contains("California") Then
                shipping = 4.0
            ElseIf distributorLocation.Contains("Texas") Then
                shipping = 5.0
            End If
        End If

        '2. Use += or *= operators.'
        If selectedMovie.ToString IsNot "" Then
            subtotal += price
            tax += price * 0.04
            totalShipping += shipping
            finalTotal += (price + (price * 0.04) + shipping)

            lblSubtotal.Text = subtotal.ToString("N2")
            lblTax.Text = tax.ToString("N2")
            lblShipping.Text = totalShipping.ToString("N2")
            lblFinalTotal.Text = finalTotal.ToString("C2")

        End If
    End Sub

    Private Sub btnRemove_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRemove.MouseClick
        Dim cartPrice As Double
        Dim cartShipping As Double

        If lstCart.SelectedIndex = -1 Then
            selectedMovie = ""
        Else
            selectedMovie = lstCart.SelectedItem.ToString.Trim
        End If

        If selectedMovie.ToString.Contains("Finding Nemo") Then
            cartPrice = 9.99
            distributorLocation = "North Carolina"
        ElseIf selectedMovie.ToString.Contains("Cars") Then
            cartPrice = 21.5
            distributorLocation = "North Carolina"
        ElseIf selectedMovie.ToString.Contains("Spider Man (2002)") Then
            cartPrice = 4.99
            distributorLocation = "North Carolina"
        ElseIf selectedMovie.ToString.Contains("The Dark Knight") Then
            cartPrice = 19.99
            distributorLocation = "Wisconson"
        ElseIf selectedMovie.ToString.Contains("Avatar") Then
            cartPrice = 8.5
            distributorLocation = "Wisconson"
        ElseIf selectedMovie.ToString.Contains("Shrek 2") Then
            cartPrice = 2.99
            distributorLocation = "Wisconson"
        ElseIf selectedMovie.ToString.Contains("Frozen") Then
            cartPrice = 12.99
            distributorLocation = "California"
        ElseIf selectedMovie.ToString.Contains("The Little Mermaid") Then
            cartPrice = 13.75
            distributorLocation = "California"
        ElseIf selectedMovie.ToString.Contains("The Lion King") Then
            cartPrice = 14.99
            distributorLocation = "California"
        ElseIf selectedMovie.ToString.Contains("Shrek") Then
            cartPrice = 7.99
            distributorLocation = "Texas"
        End If

        If selectedMovie.ToString IsNot "" Then
            lstCart.Items.Remove(selectedMovie)
        End If

        If (lstCart.SelectedIndex = -1) And (selectedMovie Is "") Then
            MessageBox.Show("Can't remove a product, nothing was selected from the shopping cart.", "Shopping Cart", MessageBoxButtons.OK, MessageBoxIcon.Error)
            distributorLocation = ""
        Else
            If distributorLocation.Contains("North Carolina") Then
                cartShipping = 1.0
            ElseIf distributorLocation.Contains("Wisconson") Then
                cartShipping = 2.5
            ElseIf distributorLocation.Contains("California") Then
                cartShipping = 4.0
            ElseIf distributorLocation.Contains("Texas") Then
                cartShipping = 5.0
            End If
        End If

        If selectedMovie.ToString IsNot "" Then
            subtotal -= cartPrice
            tax -= cartPrice * 0.04
            totalShipping -= cartShipping
            finalTotal -= (cartPrice + (cartPrice * 0.04) + cartShipping)

            lblSubtotal.Text = subtotal.ToString("C2")
            lblTax.Text = tax.ToString("C2")
            lblShipping.Text = totalShipping.ToString("C2")
            lblFinalTotal.Text = finalTotal.ToString("C2")
        End If
    End Sub

    Private Sub btnClearCart_MouseClick(sender As Object, e As MouseEventArgs) Handles btnClearCart.MouseClick
        lstCart.Items.Clear()

        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblShipping.Text = ""
        lblFinalTotal.Text = ""
        txtAmtPaid.Text = ""

        lblRctTotal.Text = ""
        lblRctPaid.Text = ""
        lblRctChange.Text = ""
        lblQuarters.Text = ""
        lblDimes.Text = ""
        lblNickels.Text = ""
        lblPennies.Text = ""

        lblCashOnly.Visible = False

        subtotal = 0.0
        tax = 0.0
        totalShipping = 0.0
        finalTotal = 0.0
        amtPaid = 0.0
        difference = 0.0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuyNow.Click
        amtPaid = Convert.ToDouble(txtAmtPaid.Text)
        difference = amtPaid - finalTotal

        '3. A function to determine the amount of quarters, dimes, nickels and pennies.'
        calculateExactChange(difference)

        lblRctTotal.Text = finalTotal.ToString("C2")
        lblRctPaid.Text = amtPaid.ToString("C2")
        lblRctChange.Text = difference.ToString("C2")
    End Sub

    Private Sub btnExit_MouseClick(sender As Object, e As MouseEventArgs) Handles btnExit.MouseClick
        Me.Close()
    End Sub

    Private Sub txtAmtPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmtPaid.TextChanged
        lblCashOnly.Visible = True
    End Sub
End Class
