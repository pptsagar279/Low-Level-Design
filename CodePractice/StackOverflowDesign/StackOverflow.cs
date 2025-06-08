using System.Collections.Concurrent;

namespace CodePractice.StackOverflowDesign
{
    public class StackOverflow
    {
        private ConcurrentBag<Question> _questions;
        private ConcurrentBag<Answer> _answers;
        private ConcurrentBag<User> _users;

        public StackOverflow()
        {
            _questions = new ConcurrentBag<Question>();
            _answers = new ConcurrentBag<Answer>();
            _users = new ConcurrentBag<User>();
        }

        public User CreateUser(string userName, string mailId)
        {
            User user = new User(userName, mailId, 0);
            _users.Add(user);
            return user;
        }

        public Question AskQuestion(string title, string content, User user, List<String> tags)
        {
            Question question = new Question(user, title, content, tags);

            _questions.Add(question);

            return question;
        }

        public Answer AddAnswer(string content, Question question, User user)
        {
            Answer answer = new Answer(user, content, question);
            question.AddAnswer(answer);
            _answers.Add(answer);

            return answer;
        }

        public void AcceptAnswer(Answer answer)
        {
            answer.Question.AcceptAnswer(answer);
            answer.IsAccpeted = true;
        }

        public void GiveVote(IVotable voting, User user, VoteType voteType)
        {
            voting.AddVote(new Vote(user, voteType));
        }

        public void AddComment(string comment, User user, ICommentable commentable)
        {
            commentable.AddComment(new Comment(user, comment));
        }
    }
}
