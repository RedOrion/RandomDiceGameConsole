 Module Module1

    Sub Main()
    	Do
    	Console.WriteLine("Choose 1 or 2 Dice")
    	Dim chosenDice = Console.ReadLine()
    	
    	If chosenDice = 1 Then
    
		Console.WriteLine("Please Select a Value between 1 and 6")
		Dim chosenValue = Console.ReadLine()
		Console.WriteLine("Chosen Value")
		Console.WriteLine(chosenValue)

		Console.ReadKey()
		Randomize()
		Dim sixsideddie As Integer = CInt(Int((6 * Rnd()) + 1))
		Console.WriteLine("Die Role")
		Console.WriteLine(sixsideddie)

		Console.WriteLine("Press Enter when you are ready to see results")
		Console.ReadKey()

		If chosenValue = sixsideddie Then
            		Console.WriteLine("You Won")
            		'Console.WriteLine(chosenValue "=" sixsideddie)
            		Console.ReadKey()
		Else
            		Console.WriteLine("You Lost")
            		'Console.WriteLine(chosenValue "≠" sixsideddie)
            		Console.ReadKey()
		End If
        
        ElseIf chosenDice = 2 Then
        	
		Console.WriteLine("Please Select a Value between 1 and 12")
		Dim chosenValue = Console.ReadLine()
		Console.WriteLine("Chosen Value")
		Console.WriteLine(chosenValue)

		Console.ReadKey()
            	Randomize()
		Dim onesixsideddie As Integer = CInt(Int((6 * Rnd()) + 1))
            	Dim twosixsideddie As Integer = CInt(Int((6 * Rnd()) + 1))
            	Dim totaldierole As Integer
            	totaldierole = onesixsideddie + twosixsideddie
            	Console.WriteLine("Die Role")
            	Console.WriteLine(totaldierole)

		Console.WriteLine("Press Enter when you are ready to see results")
		Console.ReadKey()

		If chosenValue = totaldierole Then
            		Console.WriteLine("You Won")
            		'Console.WriteLine(chosenValue "=" totaldierole)
            		Console.ReadKey()
		Else
            		Console.WriteLine("You Lost")
            		'Console.WriteLine(chosenValue "≠" totaldierole)
            		Console.ReadKey()
		End If
        
	End If
	Console.WriteLine("Restarting Game")
	Loop
        
    End Sub

End Module
