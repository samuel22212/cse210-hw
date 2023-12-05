public class MathAssignment : Assignment
{

    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textbookSection, string problems)
        : base(name, topic)

    {
        _textbookSection = textbookSection;
        _problems = problems;


    }
    public string GetHomeworkList()
    {
        string homework = $"Section {_textbookSection} Problems {_problems}";
        return homework;
    }
}



public class WritingAssignment : Assignment
{
    private string _title;


    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {

        _title = title;
    }

    public string GetWritingInformation()
    {

        string studentName = GetStudentName();

        string writinginfo =  $"{_title} by {studentName}";
        return writinginfo;
    }
}