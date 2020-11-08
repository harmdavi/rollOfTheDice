
'David Harmon
'RCET0265
'Spring 2020
'Roll of the Dice
'https://github.com/harmdavi/rollOfTheDice.git

Option Strict On
Option Explicit On
Option Compare Text

Module rollOfTheDice ' PascalCase - TJR

    Sub Main()
        Dim diceArray(12) As Integer
        Dim randomNumber As Integer
        Dim value As Integer = 0
        Dim intI As Integer
        Dim iterations As Integer
        Dim userInput As String

        Do Until userInput = "q"

            Randomize()

            Console.WriteLine("This is a 1000 dice roll simulator. Press enter again to Re-Roll. Press q to exit.")

            'remove commented code - TJR

            For i = 0 To 1000
                randomNumber = CInt((12 - 2 + 1) * Rnd() + 2)

                ' The way that the randomizer equastion works, there need to be code in there to make sure that everthing is rounded up. 
                'This ensures that the random number always falls into working order. 

                If diceArray(randomNumber - 2) < 2 Then
                    i = 2
                ElseIf (randomNumber - 2) > 13 Then
                    i = 12
                End If

                diceArray(randomNumber - 2) += 1

            Next

            'This part of the code formats the code so that it is easy to understand by the user. 

            For i = 0 To 10
                Console.Write("--------")
            Next
            Console.WriteLine()

            For i = 2 To 12
                Console.Write($"{i} |{vbTab}") ' use pad left for consistent column width - TJR
            Next
            Console.WriteLine()

            For i = 0 To 10
                Console.Write("--------")
            Next
            Console.WriteLine()

            For i = 0 To 10
                'Console.Write(i)
                Console.Write($"{diceArray(i)} |{vbTab}")
            Next

            userInput = Console.ReadLine()
            If userInput = "q" Then
                Exit Sub
            Else
            End If

            Console.Clear()
            'This part clears the array to all 0's so that the ranomizer can load another 1000
            For intI = 0 To 12
                diceArray(intI) = 0
            Next

        Loop

    End Sub

End Module
