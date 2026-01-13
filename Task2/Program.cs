using System.Data.Common;
Post post = new Post();
post.Likes = 1;
post.AddLike();
post.AddLike();
post.SetPost("It is Post");
post.AddComment("Good");
post.AddComment("Great");
post.AddComment("Awesome");
System.Console.WriteLine(post.GetInfo());

