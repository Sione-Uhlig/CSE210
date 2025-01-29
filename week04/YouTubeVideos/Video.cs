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

    public int CommentCount()
    {
        return _comments.Count;
    }

    public override string ToString()
    {
        string videoInfo = $"\nTitle: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nComments: {CommentCount()}\n";
        string commentsContent = string.Join("\n",_comments);
        
        return $"{videoInfo}\n{commentsContent}";
    }


}