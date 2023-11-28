using System.ComponentModel;
using System.Diagnostics;

class Scripture{
// This class keeps track of the scripture reference and the text of the scripture. 
// This class has a method to hide word and displays the scripture with words hidden.

//list of words objects
    private bool allhidden = false;
//constructor
   private Reference _reference = new Reference("john",3,16);
   private List<Word> _words = new List<Word>(); 
   
public Scripture()
{

}
//Constructors with parameters
public Scripture(Reference reference, string text)
{
    _reference = reference;

    string [] parts = text.Split(" ");
    foreach(string part in parts)
    {
        _words.Add(new Word(part));
    }  

}
    public void hideWords(int numberToHide)
    {   Random rand = new Random();
        for (int i = 0; i<numberToHide; i++)
        {
            _words[rand.Next(0,_words.Count)].Hide();
        }
    }

    public string displayAllText()
    {    
        string displayText = "";
        foreach(Word word in _words)
        {   
          displayText = displayText +" "+ word.Display();
            
        }
        return displayText;
        }   
        public bool isCompletelyHidden(){
            allhidden = true;
            foreach (Word w in _words)
            {   
                bool hidden = w.getHidden();
                if (hidden == false)
                {
                    allhidden =false;
                } 
            }

         return allhidden;
        }

    }





