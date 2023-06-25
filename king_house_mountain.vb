Public Class GourmetChocolate
    Dim customerName as String
    Dim sweetType as String
    Dim occasion as String

    Public Sub GetCustomerName(ByVal inputName as String)
        customerName = inputName
    End Sub

    Public Sub GetSweetType(ByVal inputType as String)
        sweetType = inputType
    End Sub

    Public Sub GetOccasion(ByVal inputOccasion as String)
        occasion = inputOccasion
    End Sub

    Public Sub CreateGiftBasket()
        Dim giftBasket as String = "Gourmet Chocolate Gift Basket for " & customerName & " for " & occasion & ": " & sweetType
        Console.WriteLine(giftBasket)
    End Sub

    Public Sub GetOrderTotal (ByVal itemPrice as Double, ByVal itemQuantity as Integer)
        Dim orderTotal as Double 
        orderTotal = itemPrice * itemQuantity 
        Console.WriteLine("Order total for " & customerName & " is $" & orderTotal)
    End Sub

    Public Sub GetShippingAddress (ByVal shippingAddress as String)
        Console.WriteLine("Shipping address for " & customerName & " is " & shippingAddress)
    End Sub

    Public Sub PlaceOrder()
        Dim orderConfirmation as String = "Order placed for " & customerName & " for " & sweetType & " for " & occasion & "."
        Console.WriteLine(orderConfirmation)
    End Sub
End Class