
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodePractice.StackOverflowDesign
{
    public class Question : IVotable, ICommentable
    {
        public User Author { get; set; }

        public string Title { get; set; }
        
        public string Content { get; set; }
        
        public List<Answer> Answers { get; set; }

        public List<Comment> Comments { get; set; }
        
        public Answer? AcceptedAnswer { get; set; }

        public List<Vote> Votes { get; set; }

        public List<Tag> Tags { get; set; }

        public Question(User user, string title, string content, List<string> tags)
        {
            Author = user;
            Title = title;
            Content = content;
            Answers = new List<Answer>();
            Comments = new List<Comment>();
            Votes = new List<Vote>();
            Tags = new List<Tag>();
            tags.ForEach(x => AddTag(new Tag(x)));
        }

        public void AddAnswer(Answer answer)
        {
            if(!Answers.Contains(answer))
                Answers.Add(answer);
        }

        public void AcceptAnswer(Answer answer)
        {
            this.AcceptedAnswer = answer;
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

            Author.UpdateReputation(5*(vote.VoteType == VoteType.DOWNVOTE ? -1 : 1));
        }

        public void AddTag(Tag tag)
        {
            if(!Tags.Contains(tag))
                Tags.Add(tag);
        }

        public User GetAuthor() { return Author; }
        public string GetTitle() { return Title; }
        public string GetContent() { return Content; }
        public List<Answer> GetAnswers() { return new List<Answer>(Answers); }
        public List<Tag> GetTags() { return new List<Tag>(Tags); }
        public List<Comment> GetComments()
        {
            return new List<Comment>(Comments);
        }
        public Answer? GetAcceptedAnswer()
        {
            return AcceptedAnswer;
        }
    }
}
