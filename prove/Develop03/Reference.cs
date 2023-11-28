class Reference{

private string _book;
private int _chapter;
private int _startingVerse;
private int _endingVerse = 0;

public Reference(string book, int chapter, int verse)
{
    _book = book;
    _chapter = chapter;
    _startingVerse = verse;

}

public Reference(string book, int chapter, int startVerse, int endVerse)
{
    _book = book;
    _chapter = chapter;
    _startingVerse = startVerse;
    _endingVerse = endVerse;

}

public string Display()
{   
    String displayString = $"{_book} {_chapter}:{_startingVerse} ";
    if (_endingVerse > 0)
    {
        displayString = displayString + $"- {_endingVerse}";
    }
    return displayString;
}

}