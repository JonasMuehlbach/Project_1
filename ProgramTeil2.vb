Module Program
    'Getting al the Users from the csv file 
    'Dim Users() As String = Files.ReadAllLines("/Users/jonasmuhlbach/Programs_VB/Project_Bib/library_users.csv")
    Dim User As String =
                        "U001,Max Johnson|" &
                        "U002,Emily Smith|" &
                        "U003,Daniel Brown|" &
                        "U004,Laura Wilson|" &
                        "U005,Michael Taylor|" &
                        "U006,Sarah Anderson|" &
                        "U007,James Miller|" &
                        "U008,Anna Davis|" &
                        "U009,Robert Clark|" &
                        "U010,Linda Moore|" &
                        "U011,Thomas Martin|" &
                        "U012,Jessica Thompson|" &
                        "U013,Kevin White|" &
                        "U014,Rachel Harris|" &
                        "U015,Steven Lewis"
    Dim Users() As String = User.Split("|")
    'Getting al the Books from the csv file 
    'Dim Books() As String = Files.ReadAllLines("/Users/jonasmuhlbach/Programs_VB/Project_Bib/library_books.csv")
    Dim LibaryData As String =
                                "978-0-13-110362-7,Introduction to Programming,John Smith,available|" &
                                "978-0-201-03801-9,Data Structures Basics,Alice Brown,available|" &
                                "978-0-262-03384-8,Algorithms Explained,Thomas White,available|" &
                                "978-0-321-48681-3,Software Engineering Fundamentals,Emily Johnson,available|" &
                                "978-1-491-94600-8,Learning VB.NET,Michael Green,available|" &
                                "978-0-596-52068-7,Clean Code,Robert Martin,available|" &
                                "978-0-13-235088-4,Agile Development,James Wilson,available|" &
                                "978-1-59327-584-6,Programming Logic,Sarah Miller,available|" &  
                                "978-0-201-70073-2,Computer Systems,David Lee,available|" &
                                "978-0-321-12742-6,Object-Oriented Design,Laura Clark,available|" &
                                "978-0-07-352332-3,Engineering Mathematics,Peter Adams,available|" &
                                "978-0-262-16209-8,Discrete Mathematics,Brian Scott,available|" &
                                "978-1-118-09387-9,Introduction to Databases,Kevin Turner,available|" &
                                "978-0-596-15806-4,Operating Systems Concepts,Nancy Hall,available|" &
                                "978-0-13-468599-1,Modern Software Testing,Richard Young,available|" &
                                "978-1-4842-0077-9,Beginning Algorithms,Steven King,available|" &    
                                "978-0-321-35668-0,System Analysis and Design,Angela Moore,available|" &     
                                "978-0-07-337622-6,Technical Communication,Mark Taylor,available|" &
                                "978-1-491-94729-6,Programming Basics,Rachel Evans,available|" &
                                "978-0-13-708107-3,Introduction to Networks,Daniel Harris,available|" &
                                "978-0-262-53205-1,Artificial Intelligence Basics,Helen Brooks,available|" &
                                "978-1-59327-282-1,Problem Solving with Computers,Chris Baker,available|" &
                                "978-0-596-51774-8,Linux Fundamentals,Paul Walker,available|" &
                                "978-0-13-187325-4,Computer Architecture,Andrew Collins,available|" &
                                "978-1-491-94618-3,Programming in Practice,Olivia Reed,available|" &
                                "978-0-321-99278-8,Human Computer Interaction,Jason Turner,available|" &
                                "978-0-07-180855-2,Information Systems,Rebecca Lewis,available|" &
                                "978-1-59327-599-0,Software Development Tools,Matthew Perez,available|" &
                                "978-0-596-52067-0,Coding Standards,Benjamin Foster,available|" &
                                "978-0-13-117705-5,Fundamentals of Computing,Sophia Anderson,available|" 
        Dim Libary() As String = LibaryData.Split("|")

    Sub Main(args As String())
        Dim Choice As Integer = 0
        ' loop until the user chooses to exit (7)
        Do
            ' display menu
            Console.Clear()
            Console.WriteLine("Please choose one of the options")
            Console.WriteLine("(1) New user")
            Console.WriteLine("(2) Book variety")
            Console.WriteLine("(3) All Users")
            Console.WriteLine("(4) Borrow a book (ISBN)")
            Console.WriteLine("(5) Give Back (ISBN)")
            Console.WriteLine("(6) Close")
            Console.Write("input: ")

            Dim input As String = Console.ReadLine()
            If Not Integer.TryParse(input, Choice) Then
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.")
                Pause()
                'as long as non of the Cases between 1 and 7 is chosen, the console is not going to continue and will ask for a valid input
                Continue Do
            End If

            Select Case Choice
                Case 1
                    AddUser()
                Case 2
                    'display all the books in the library, trough an Intiger loop, that goes trough the array and prints out all the books same as the users in case 3
                    For i As Integer = 0 To Libary.Length - 1
                        Console.WriteLine(Libary(i))
                    Next
                Case 3
                    For i As Integer = 0 To Users.Length - 1
                        Console.WriteLine(Users(i))
                    Next
                Case 4
                    BorrowBook()
                Case 5
                    ReturnBook()
                Case 6
                    Console.WriteLine("Goodbye!")
                    ' leave immediately without waiting for key
                    Exit Sub
                Case Else
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 7.")
            End Select

            If Choice <> 6 Then Pause()
        Loop While Choice <> 6
        'Loop will continue until the user chooses to exit with (6)
    End Sub

    'Sub after a Chase walked trough  to get back to menu
    Sub Pause()
        Console.WriteLine("Press any key to go back to the menu...")
        Console.ReadKey()
    End Sub

    ' adds a new user with ID of format UXXX 
    Sub AddUser()
        ' check capacity if it below 999 users
        If Users.Length >= 999 Then
            Console.WriteLine("To many users. Please contact the libary staff for further assistance :)")
            Return
        End If

        Console.Write("First name: ")
        Dim first As String = Console.ReadLine().Trim()
        Console.Write("Last name: ")
        Dim last As String = Console.ReadLine().Trim()
        If first = "" OrElse last = "" Then
            Console.WriteLine("First or/and last name cannot be empty.")
            ' Saftey from empty inputs
            Return
        End If

        ' find highest existing numeric ID and using it for new user
        Dim maxNum As Integer = 0
        For Each entry As String In Users
            Dim parts() As String = entry.Split(","c)
            If parts.Length > 0 AndAlso parts(0).StartsWith("U") Then
                Dim numStr As String = parts(0).Substring(1)
                Dim n As Integer
                If Integer.TryParse(numStr, n) Then
                    If n > maxNum Then maxNum = n
                End If
            End If
        Next

        Dim newNum As Integer = maxNum + 1
        If newNum > 999 Then
            Console.WriteLine("To many users. Please contact the libary staff for further assistance :)")
            Return
        End If

        Dim newId As String = "U" & newNum.ToString("D3")
        Dim newEntry As String = newId & "," & first & " " & last
        User &= "|" & newEntry
        Users = User.Split("|"c)

        Console.WriteLine("Added New User: " & newEntry)
    End Sub

    ' A Sub for Borrowing a book, over the ISBN and the User ID
    Sub BorrowBook()
        Console.Write("ISBN: ")
        Dim isbn As String = Console.ReadLine()
        Console.Write("User ID (Imput with U): ")
        Dim userId As String = Console.ReadLine()

        ' checks if user even exists, if not return to the menu
        Dim userEntry As String = Users.FirstOrDefault(Function(u) u.StartsWith(userId & ","))
        If userEntry Is Nothing Then
            Console.WriteLine("User ID not found.")
            Return
        End If
        Dim userName As String = ""
        Dim userParts() As String = userEntry.Split(","c)
        If userParts.Length > 1 Then userName = userParts(1)

        ' find book over the ISBN, if not back to menu
        Dim bookIndex As Integer = -1
        For i As Integer = 0 To Libary.Length - 1
            Dim parts() As String = Libary(i).Split(","c)
            If parts.Length >= 4 AndAlso parts(0) = isbn Then
                bookIndex = i
                Exit For
            End If
        Next
        If bookIndex = -1 Then
            Console.WriteLine("ISBN not found in library.")
            Return
        End If

        Dim bookParts() As String = Libary(bookIndex).Split(","c)
        If bookParts.Length < 4 Then
            Console.WriteLine("Invalid book record.")
            Return
        End If

        If Not bookParts(3).Equals("available", StringComparison.OrdinalIgnoreCase) Then
            Console.WriteLine("Book is not available for lending. for further information please contact the libary staff, thank you :-)")
            Return
        End If

        ' mark as lent in LibaryData 
        bookParts(3) = "lend"
        Libary(bookIndex) = String.Join(",", bookParts)
        LibaryData = String.Join("|", Libary)

        Console.WriteLine($"Book '{bookParts(1)}' (ISBN {isbn}) has been lent to {userName} ({userId}).")
        'Question should i implement a abillity that it is showing me all the books so it i easyier to type the ISBN

    End Sub

    Sub returnBook()
        Console.Write("ISBN: ")
        Dim isbn As String = Console.ReadLine()

        ' find book over the ISBN, if not back to menu
        Dim bookIndex As Integer = -1
        For i As Integer = 0 To Libary.Length - 1
            Dim parts() As String = Libary(i).Split(","c)
            If parts.Length >= 4 AndAlso parts(0) = isbn Then
                bookIndex = i
                Exit For
            End If
        Next
        If bookIndex = -1 Then
            Console.WriteLine("ISBN not found in library.")
            Return
        End If

        Dim bookParts() As String = Libary(bookIndex).Split(","c)
        If bookParts.Length < 4 Then
            Console.WriteLine("Invalid book record.")
            Return
        End If

        If Not bookParts(3).Equals("lend", StringComparison.OrdinalIgnoreCase) Then
            Console.WriteLine("Book is not currently lent out.")
            Return
        End If

        ' mark as available in LibaryData 
        bookParts(3) = "available"
        Libary(bookIndex) = String.Join(",", bookParts)
        LibaryData = String.Join("|", Libary)

        Console.WriteLine($"Book '{bookParts(1)}' (ISBN {isbn}) has been returned and is now available.")
    End Sub

End Module
