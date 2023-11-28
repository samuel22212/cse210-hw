using System.ComponentModel;

class Scripture{
// This class keeps track of the scripture reference and the text of the scripture. 
// This class has a method to hide word and displays the scripture with words hidden.

//list of words objects

//constructor
   private Reference _reference = new Reference();
   private List<Word> _words = new List<Word>(); 
public Scripture()
{

}
//Constructors with parameters
public Scripture(Reference reference, string text)
{
    _reference = reference;
    

}
    public void hideWords(int numberToHide)
    {   Random rand = new Random();
        for (int i = 0; i<numberToHide; i++)
        {
            _words[rand.Next(1,_words.Count-1)].Hide();
        }
    }

    public String displayAllText()
    {
        foreach(Word word in _words)
        {
            word.display()
        }
        }   
    }





