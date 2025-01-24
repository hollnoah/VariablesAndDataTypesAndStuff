'Noah Holloway
'RCET2265
'Spring 2025
'VariablesAndDataTypesAndStuff

Option Explicit Off
Option Strict Off
Module VariablesAndDataTypesAndTypes

    Sub Main()

        Dim laffyTaffy As Integer 'assigns laffy taffy as a variable
        Dim money As Decimal 'assigns money as a variable
        Dim jellyBeans As Integer 'assigns jelly beans as a variable
        Dim studentName As String 'assigns student name as a variable
        Dim userInput As String

        Console.WriteLine(jellyBeans) 'writes it to console

        jellyBeans = 120 'assigns jelly beans a value of 120    
        Console.WriteLine(jellyBeans)

        jellyBeans = jellyBeans + 10 'adds 10 + 120 = 130
        Console.WriteLine(jellyBeans)

        jellyBeans += 10 'adds 10 to itself and remembers its new sum, 10 + 130 = 140
        Console.WriteLine(jellyBeans)

        jellyBeans += 10 '10 + 140 = 150
        Console.WriteLine(jellyBeans)

        laffyTaffy = 11 'laffy taffy new variable, allowed because option explicit off
        Console.WriteLine(laffyTaffy)

        money = 9.75742873482734
        jellyBeans = CInt(1.56)
        studentName = "7"

        jellyBeans = CInt(studentName)

        Console.WriteLine("Please enter a fruit")
        userInput = Console.ReadLine()

        'Console.WriteLine("You entered " & userInput & "!" & "A marvelous choice sir")
        Console.WriteLine($"You entered {userInput}!")

    End Sub

End Module
