using System.IO;
public class Journal
{

    public List<Entry> _entries = new List<Entry>();


    public void AddEntry()
    {
        Entry newEntry = new Entry();
        _entries.Add(newEntry);
        newEntry._textPrompt = GeneratePrompt.RandomPrompt();
        Console.WriteLine(newEntry._textPrompt);
        newEntry._entryText = Console.ReadLine();
        newEntry._date = DateTime.Now.ToString();

    }

    public void DisplayAll()
    {
        //I think this needs to iterate through the _entries list and call the display method for each one. 
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine(" - ");
        }
    }
    public void Save(string file)
    {
        Console.WriteLine("Saving...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry E in _entries)
            {
                outputFile.WriteLine($"{E._date}~|~{E._textPrompt}~|~{E._entryText}");
                Console.WriteLine("entry saved");


            }

        }

    }
    public void Load(string file)
    {
        _entries.Clear();
        string filename = file;
        String[] lines = System.IO.File.ReadAllLines(filename);
        try
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");

                string date = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];
                Entry newEntry = new Entry();
                _entries.Add(newEntry);
                newEntry._date = date;
                newEntry._textPrompt = prompt;
                newEntry._entryText = entryText;

            }
            Console.WriteLine("Load sucessful");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("An error occured. Try removing any blank lines from the TXT file for the journal. ");
        }
    }
}