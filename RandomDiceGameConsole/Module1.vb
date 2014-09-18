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

                Console.WriteLine("Press Enter to see the die role.")
                Console.ReadKey()
                Randomize()
                Dim totaldierole As Integer = CInt(Int((6 * Rnd()) + 1))
                Console.WriteLine("Die Role")
                Console.WriteLine(totaldierole)
                Console.ReadKey()

                If chosenValue = totaldierole Then
                    Console.WriteLine("You Won!")
                    Console.ReadKey()
                ElseIf chosenValue <> totaldierole Then
                    Console.WriteLine("You Lost!")
                    Console.ReadKey()
                End If

            ElseIf chosenDice = 2 Then

                Console.WriteLine("Please Select a Value between 1 and 12.")
                Dim chosenValue = Console.ReadLine()
                Console.WriteLine("Chosen Value")
                Console.WriteLine(chosenValue)

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
            ElseIf chosenDice <> 1 <> 2 Then
                Console.WriteLine("The value was incorrect.")
                Console.WriteLine("You need to choose either 1 or 2.")
            End If

            'Console.WriteLine("Do you want to start another game?")
            'Console.WriteLine("Please select Y or N.")
            'Dim ContinueYesOrNo = Console.ReadLine()
            'Dim Y As Single
            'Dim N As Single
            'If ContinueYesOrNo = Y Then
            'Console.WriteLine("New Game Starting Now.")
            'ElseIf ContinueYesOrNo = N Then
            'System.Environment.Exit(1)
            'ElseIf ContinueYesOrNo <> Y <> N Then
            'Console.WriteLine("You need to choose either Y or N.")
            'End If

            Console.WriteLine("Restarting Game")
            Console.WriteLine()
            Console.WriteLine()
        Loop

    End Sub


End Module
