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
            Console.WriteLine("(6) Borrowed books by user")
            Console.WriteLine("(7) Close")
            Console.Write("input: ")

            Dim input As String = Console.ReadLine()
            If Not Integer.TryParse(input, Choice) Then
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.")
                Pause()
                'as long as non of the Cases between 1 and 7 is chosen, the console is not going to continue and will ask for a valid input
                Continue Do
            End If

            Select Case Choice
                Case 1
                    Console.WriteLine("input was 1")
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
                    Console.WriteLine("input was 4")
                Case 5
                    Console.WriteLine("input was 5")
                Case 6
                    Console.WriteLine("input was 6")
                Case 7
                    Console.WriteLine("Goodbye!")
                    ' leave immediately without waiting for key
                    Exit Sub
                Case Else
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 7.")
            End Select

            If Choice <> 7 Then Pause()
        Loop While Choice <> 7
        'Loop will continue until the user chooses to exit with (7)
    End Sub

    Sub Pause()
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
        ' The "Pause" subroutine is used to show the user what he needs to do to loop back to the menu.
    End Sub
End Module
