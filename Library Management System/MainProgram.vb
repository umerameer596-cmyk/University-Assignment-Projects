Imports System

Module Program
    Sub Main()
        Console.Write("Enter Your Name:")
        Dim name As String = Console.ReadLine()
        Console.Write("Enter Your StudentId:")
        Dim StudentId As Integer = Console.ReadLine()
        Console.Clear()
        Dim student1 As New Student
        student1.Name = name
        student1.StudentID = StudentId

        Dim genreBooks As New Dictionary(Of String, List(Of Book)) From {
    {"Fiction", New List(Of Book) From {
        New Book With {.Title = "1984", .Author = "George Orwell"},
        New Book With {.Title = "The Great Gatsby", .Author = "F. Scott Fitzgerald"},
        New Book With {.Title = "Brave New World", .Author = "Aldous Huxley"}
    }},
    {"Science", New List(Of Book) From {
        New Book With {.Title = "A Brief History of Time", .Author = "Stephen Hawking"},
        New Book With {.Title = "The Selfish Gene", .Author = "Richard Dawkins"},
        New Book With {.Title = "Cosmos", .Author = "Carl Sagan"}
    }},
    {"Mystery", New List(Of Book) From {
        New Book With {.Title = "The Da Vinci Code", .Author = "Dan Brown"},
        New Book With {.Title = "Gone Girl", .Author = "Gillian Flynn"},
        New Book With {.Title = "The Girl with the Dragon Tattoo", .Author = "Stieg Larsson"}
    }}
}
        Console.Clear()

        Console.WriteLine("Available Genres:")
        Dim index As Integer = 1
        Dim genreList As New List(Of String)

        For Each genre In genreBooks.Keys
            Console.WriteLine(index & ". " & genre)
            genreList.Add(genre)
            index += 1
        Next


        Console.Write("Enter genre number: ")
        Dim genreChoice As Integer = Convert.ToInt32(Console.ReadLine())


        Dim selectedGenre As String = genreList(genreChoice - 1)
        Console.WriteLine("You selected genre: " & selectedGenre)

        Console.Clear()

        Dim booksInGenre As List(Of Book) = genreBooks(selectedGenre)

        Console.WriteLine("Books in " & selectedGenre & ":")
        index = 1
        For Each book In booksInGenre
            Console.WriteLine(index & ". " & book.Title & " by " & book.Author)
            index += 1
        Next


        Console.Write("Enter book number to select: ")
        Dim bookChoice As Integer = Convert.ToInt32(Console.ReadLine())
        Dim selectedBook As Book = booksInGenre(bookChoice - 1)

        Console.Clear()

        Console.WriteLine("You selected: " & selectedBook.Title & " by " & selectedBook.Author)

        Console.Clear()

        Dim issueDate As Date = Date.Now
        Dim dueDate As Date = issueDate.AddDays(14)

        Console.WriteLine("Name: " & name)
        Console.WriteLine("StudentId: " & StudentId)
        Console.WriteLine("You have borrowed:")
        Console.WriteLine("Title: " & selectedBook.Title)
        Console.WriteLine("Author: " & selectedBook.Author)
        Console.WriteLine("Issued on: " & issueDate.ToShortDateString())
        Console.WriteLine("Due date: " & dueDate.ToShortDateString())
        Console.WriteLine("Note: If returned after due date, a fine of 1 dollar per day will be charged.")

    End Sub
End Module
