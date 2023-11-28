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
        if (_isHidden == true)
        {
            _text = "";
            for (int i = 0; i < _text.Length; i++)
            {
                _text = _text + "_";
            }
            return _text;
        }
        else
        {
            return _text;
        }
    }

}