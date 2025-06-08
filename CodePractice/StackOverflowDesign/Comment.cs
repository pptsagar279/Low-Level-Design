
namespace CodePractice.StackOverflowDesign
{
    public class Comment
    {
        public User Poster { get; set; }

        public string Content   { get; set; }

        public List<Comment> Comments { get; set; }

        public Comment(User poster, string content)
        {
            Poster = poster;
            Content = content;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
    }
}
