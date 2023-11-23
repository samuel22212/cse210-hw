using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Empty Constructor
    public Fraction()
    {
        // Default to 1/1   I wasn't sure what to set the values to for this empty constructor so I used the instructor solution. 
        _top = 1;
        _bottom = 1;
    }
    //constructor that takes an argument
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    //Constructor that takes multiple parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //this code is literally not needed
    public int GetTop()
    {
        return _top;
    }

    // this code also not needed
    public void SetTop(int top)
    {
        _top = top;
    }
    // exteraneous getter
    public int GetBottom()
    {
        return _bottom;
    }

    //another extraneous setter
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public String GetFractionString()
    {
        string stringy = $"{_top}/{_bottom}";
        return stringy;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }


}