
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodePractice.StackOverflowDesign
{
    public class Answer : IVotable, ICommentable
    {
        public User Author { get; set; }

        public List<Comment> Comments { get; set; }

        public string Content { get; set; }

        public bool IsAccpeted { get; set; }

        public List<Vote> Votes { get; set; }

        public Question Question { get; set; }

        public Answer(User author, string content, Question question)
        {
            Author = author;
            Content = content;
            Question = question;
            Votes = new List<Vote>();
            Comments = new List<Comment>();
            IsAccpeted = false;
        }

        public void AddComment(Comment comment)
        {
            if (!Comments.Contains(comment))
            {
                Comments.Add(comment);
            }
        }

        public void AddVote(Vote vote)
        {
            Votes.RemoveAll(v => v.User == vote.User);

            Votes.Add(vote);

            Author.UpdateReputation(5 * (vote.VoteType == VoteType.DOWNVOTE ? -1 : 1));
        }
        public List<Comment> GetComments()
        {
            return new List<Comment>(Comments);
        }
        public User GetAuthor() { return Author; }
        public Question GetQuestion() { return Question; }
        public string GetContent() { return Content; }
        public bool IsAccepted() { return IsAccpeted; }
    }
}
