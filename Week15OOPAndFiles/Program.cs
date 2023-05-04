List<Movie> myMovies = new List<Movie>();

string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
    //Console.WriteLine("Temp array");
    //ReadDataFromArray(tempArray);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"D:\TKTK\VI Semester\Programmeerimise alused\Nädal 15. OOP ja failid\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}
class Movie
{
    string title;   //fields
    string year;

    //getter
    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    //constructor
    public Movie(string _title, string _year) 
    { 
        title = _title;
        year = _year;
    }
}