using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden() => _isHidden;
    public void Hide() => _isHidden = true;
    public string Display() => _isHidden ? new string('_', _text.Length) : _text;
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    
}