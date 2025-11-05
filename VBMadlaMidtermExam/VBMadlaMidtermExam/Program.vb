Imports System

Module Program
    Sub Main()
        Dim name As String
        Dim pass As String
        Dim attempt As Integer
        Dim i As Integer

        Dim log As Boolean = True

        While log

            Do While attempt < 3
                Console.WriteLine("Enter username")
                name = Console.ReadLine()
                Console.WriteLine("Enter password")
                pass = Console.ReadLine()

                If name = "celdrick" And pass = "@admin123" Then
                    Console.WriteLine("Access granted.")

                    For i = 2 To 100 Step 2
                        Console.WriteLine(i.ToString())
                    Next

                    Console.WriteLine("program end.")
                    Console.ReadLine()
                    log = False

                    Exit While
                Else
                    attempt += 1
                    Console.WriteLine("Access Denied.")
                    log = True
                End If
            Loop
            Console.WriteLine("The log-in attempt is only 3 times then the program will close.")
            Console.ReadLine()
            Exit While

        End While

    End Sub
End Module
