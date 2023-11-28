using System.Runtime.CompilerServices;

class Word
{

    // this class is meant to encapsulate the responsibilities of a word 
    //this class stores whether a word is shown or hidden

    private string _text;
    private bool _isHidden;

    public Word(String text)
    {
        _isHidden = false;
        _text = text;
    }


    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string Display()
    {   
        string underscorestext = "";
        if (_isHidden == true)
        {
           
            for (int i = 0; i < _text.Length; i++)
            {
                underscorestext = underscorestext + "_";
            }
            return underscorestext;
        }
        else
        {
            return _text;
        }
    }

    public bool getHidden()
    {
        return _isHidden;
    }
}