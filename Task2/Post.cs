public class Post
{
    public string Text {get; set;}
    public int Likes {get; set;}
    public List<string> Comments = new();
    public void SetPost(string text)
    {
        Text = text;
    }

    public void AddLike()
    {
        Likes++;
    }

    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public string GetInfo()
    {
        foreach(var s in Comments)
        {
            System.Console.WriteLine(s);
        }
        return $"{Text} - {Likes}";
    }
}
    