using System;

class Comments
{
    public string CommentersName;
    public string CommentersText;

    public Comments (string commenterName, string Commenterstext)
    {
        CommentersName = commenterName;
        CommentersText = Commenterstext;
    }

    public override string ToString()
    {
        return $"{CommentersName}: {CommentersText}";
    }
}