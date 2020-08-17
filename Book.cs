namespace csharp_practice_02
{
  public class Book
  {
    public string title;
    public string author;
    public int pages;
    private string rating;

    public Book(string aTitle, string aAuthor, int aPages, string aRating)
    {
      title = aTitle;
      author = aAuthor;
      pages = aPages;
      Rating = aRating;
    }

    public string Rating
    {
      get { return rating; }
      set
      {
        if (value == "A" || value == "PG" || value == "PG-13" || value == "16" || value == "R" || value == "NR")
        {
          rating = value;
        }
        else
        {
          rating = "NR";
        }
      }
    }




  }
}