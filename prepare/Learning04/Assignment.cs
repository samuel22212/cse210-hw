public class Assignment
{



    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    private string _studentName;
    private string _topic;

    public string GetSummary()
    {
        string summary = $"{_studentName} {_topic}";
        return summary;
    }


    public string GetTopic()
    {
        return _topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }


}


