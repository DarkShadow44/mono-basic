Module ExplicitConversionDecimalToLong1
    Function Main() As Integer
        Dim result As Boolean
        Dim value1 As Decimal
        Dim value2 As Long
        Dim const2 As Long

        value1 = 90.09D
        value2 = CLng(value1)
        const2 = CLng(90.09D)

        result = value2 = const2

        If result = False Then
            System.Console.WriteLine("FAIL ExplicitConversionDecimalToLong1")
            Return 1
        End If
    End Function
End Module
