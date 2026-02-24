Imports System

Module Program
    Sub Main(args As String())
        'Creating a Var. that has all the books in
         Dim LibraryData As String =
                            "978-3-16-148410-0;Einführung in die Informatik; Müller; verfügbar|" & vbCrLf &
                            "978-0-13-110362-7;Programmieren mit VB.NET; Schneider; verfügbar|" & vbCrLf &
                            "978-3-540-69006-6;Grundlagen der Softwaretechnik;Meier; ausgeleiehen|" & vbCrLf &
                            "978-3-642-05445-3;Datenstrukturen und Algorithmen;Klein; verfügbar|"
        'Creating a Var. that has all the Users in
        Dim User As String =
                            "U001; Max Mustermann|" & vbCrLf &
                            "U002; Erika Musterfrau|" & vbCrLf &
                            "U003; Hans Meier|" & vbCrLf &
                            "U004; Laura Schmidt|"
        'The user is given the opportunity to choose from various options
        Console.Writeline("Please choose on of the options")
        Console.Writeline("(1) New user") 
        Console.Writeline("(2) Book variety ") 
        Console.Writeline("(3) All Users")
        Console.Writeline("(4) Borrow a book (ISBN)")
        Console.Writeline("(5) Give Back (ISBN)")
        Console.Writeline("(6) Borrowed books by user")
        Console.Writeline("(7) Close")
        Console.Write("imput: ")
            'Imput gets read prep for further steps 
            Dim imput As String = Console.ReadLine()

            Select Case imput
                    Case "1"
                        Console.Writeline("imput was 1")
                    Case "2"
                        Console.Writeline(LibraryData)
                    Case "3"
                        Console.Writeline(User)
                    Case "4"
                        Console.Writeline("imput was 4")
                    Case "5"
                        Console.Writeline("imput was 5")
                    Case "6"
                        Console.Writeline("imput was 6")
                    Case "7"
                        Console.Writeline("imput was 7")
            'can get extendet till case 7 wit the programm that should get run under that case
            End Select      
    End Sub
End Module
