Module Module1

    Sub Main()
        Do
            Do
                Console.WriteLine("Choose 1 or 2 Dice")
                Dim chosenDice = Console.ReadLine()

                If chosenDice = 1 Then
                    OneDie()
                    If chosenDice = 1 Then
                        Exit Do
                    End If
                ElseIf chosenDice = 2 Then
                    TwoDice()
                    If chosenDice = 2 Then
                        Exit Do
                    End If
                ElseIf chosenDice <> 1 <> 2 Then
                    Console.WriteLine("The value was incorrect.")
                    Console.WriteLine("You need to choose either 1 or 2.")
                End If
            Loop
            RestartYesOrNo()
        Loop

    End Sub

    Sub OneDie()
        Do
            Console.WriteLine("Please Select a Value between 1 and 6")
            Dim chosenValue = Console.ReadLine()
            Console.WriteLine("Chosen Value")
            Console.WriteLine(chosenValue)
            If chosenValue = 1 Then
                Exit Do
            ElseIf chosenValue = 2 Then
                Exit Do
            ElseIf chosenValue = 3 Then
                Exit Do
            ElseIf chosenValue = 4 Then
                Exit Do
            ElseIf chosenValue = 5 Then
                Exit Do
            ElseIf chosenValue = 6 Then
                Exit Do
            ElseIf chosenValue Then
            End If
        Loop

        Console.WriteLine("Press Enter to see the die role.")
        Console.ReadKey()
        Randomize()
        Dim totaldierole As Integer = CInt(Int((6 * Rnd()) + 1))
        Console.WriteLine("Die Role")
        Console.WriteLine(totaldierole)
        Console.ReadKey()

        If chosenValue = totaldierole Then
            Console.WriteLine("You Won")
            Console.ReadKey()
        ElseIf chosenValue <> totaldierole Then
            Console.WriteLine("You Lost")
            Console.ReadKey()
        End If

    End Sub

    Sub TwoDice()
        Do
            Console.WriteLine("Please Select a Value between 1 and 12.")
            Dim chosenValue = Console.ReadLine()
            Console.WriteLine("Chosen Value")
            Console.WriteLine(chosenValue)
            If chosenValue = 1 Then
                Exit Do
            ElseIf chosenValue = 2 Then
                Exit Do
            ElseIf chosenValue = 3 Then
                Exit Do
            ElseIf chosenValue = 4 Then
                Exit Do
            ElseIf chosenValue = 5 Then
                Exit Do
            ElseIf chosenValue = 6 Then
                Exit Do
            ElseIf chosenValue = 7 Then
                Exit Do
            ElseIf chosenValue = 8 Then
                Exit Do
            ElseIf chosenValue = 9 Then
                Exit Do
            ElseIf chosenValue = 10 Then
                Exit Do
            ElseIf chosenValue = 11 Then
                Exit Do
            ElseIf chosenValue = 12 Then
                Exit Do
            End If
        Loop

        Console.WriteLine("Press Enter to see the die roles.")
        Console.ReadKey()
        Randomize()
        Dim onesixsideddie As Integer = CInt(Int((6 * Rnd()) + 1))
        Dim twosixsideddie As Integer = CInt(Int((6 * Rnd()) + 1))
        Dim totaldierole As Integer
        totaldierole = onesixsideddie + twosixsideddie
        Console.WriteLine("Die Role")
        Console.WriteLine(totaldierole)
        Console.ReadKey()

        If chosenValue = totaldierole Then
            Console.WriteLine("You Won")
            Console.ReadKey()
        ElseIf chosenValue <> totaldierole Then
            Console.WriteLine("You Lost")
            Console.ReadKey()
        End If

    End Sub



    Sub RestartYesOrNo()
        Console.WriteLine("Do you want to start another game?")
        Console.WriteLine("Please type 1 to restart the game or 0 to end the game.")
        Dim ContinueYesOrNo = Console.ReadLine()
        If ContinueYesOrNo = 0 Then
            System.Environment.Exit(1)
        ElseIf ContinueYesOrNo <> 1 <> 0 Then
            Console.WriteLine("Please type 1 to restart the game or 0 to end the game.")
        Else : ContinueYesOrNo = 1
            Console.WriteLine("New Game Starting Now.")
        End If
    End Sub

End Module
