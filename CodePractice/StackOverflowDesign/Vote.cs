
namespace CodePractice.StackOverflowDesign
{
    public class Vote
    {
        public User User { get; set; }

        public VoteType VoteType { get; set; }

        public Vote(User user, VoteType voteType) 
        {
            User = user;
            VoteType = voteType;
        }
    }
}
