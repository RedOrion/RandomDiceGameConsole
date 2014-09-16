Module Module1

    Sub Main()
    
    	Console.WriteLine("Choose 1 or 2 Dice")
    	Dim chosenDice = Console.ReadLine()
    	
    	If chosenDie = 1 Then
    
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
        
        ElseIf chosenDie = 2 Then
        	
        	Console.WriteLine("Please Select a Value between 1 and 12")
        	Dim chosenValue = Console.ReadLine()
        	Console.WriteLine("Chosen Value")
        	Console.WriteLine(chosenValue)

		Console.ReadKey()
       		Randomize()
        	Dim twosixsideddie As Integer = CInt(Int((12 * Rnd()) + 1))
        	Console.WriteLine("Die Role")
        	Console.WriteLine(sixsideddie)

        	Console.WriteLine("Press Enter when you are ready to see results")
        	Console.ReadKey()

        	If chosenValue = twosixsideddie Then
            		Console.WriteLine("You Won")
            		'Console.WriteLine(chosenValue "=" twosixsideddie)
            		Console.ReadKey()
        	Else
            		Console.WriteLine("You Lost")
            		'Console.WriteLine(chosenValue "≠" twosixsideddie)
            		Console.ReadKey()
        	End If
        
        Else
        	Console.WriteLine("Press Enter to choose 1 or 2")
        	Console.ReadKey()
        
    End Sub

End Module
