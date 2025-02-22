namespace LibraryManagementSystem
{

    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }


        public Book(int bookID, string title, string author)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            IsAvailable = true;
        }


        public void DisplayBookDetails()
        {
            Console.WriteLine($"BookID: {BookID}, Title: {Title}, Author: {Author}");
        }
    }
}