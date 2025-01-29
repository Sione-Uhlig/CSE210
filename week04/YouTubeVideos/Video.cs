using System;


class Video
{
    public string Title;
    public string Author;
    public int Length; 
    private List<Comments> _comments;


    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        _comments = new List<Comments>();
    }

    public void AddComment(Comments comments)
    {
        _comments.Add(comments);
    }

    public override string ToString()
    {
        string videoInfo = $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\n";
        string commentsContent = string.Join("\n",_comments);
        
        return $"{videoInfo}\n{commentsContent}";
    }


}