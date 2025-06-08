
using System.Xml.Linq;

namespace CodePractice.StackOverflowDesign
{
    public class User
    {
        private const int questionRept = 5;
        private const int answerRept = 10;
        private const int commentRept = 2;

        public string UserName { get; set; }
        
        public string MailId { get; set; }
        
        public int Reputation {  get; set; }
       
        public List<Question> Questions {  get; set; }

        public List<Answer> Answers { get; set; }

        public List<Comment> Comments { get; set; }

        public User(string userName, string mailId, int reputation)
        {
            UserName = userName;
            MailId = mailId;
            Reputation = reputation;
            Questions = new List<Question>();
            Answers = new List<Answer>();
            Comments = new List<Comment>();
        }

        public void UpdateReputation(int value)
        {
            Reputation += value;
            if(Reputation < 0) Reputation = 0;
        }

        public void AskQuestion(string title, string content, List<string> tags)
        {
            Question question = new Question(this, title, content, tags);

            Questions.Add(question);

            UpdateReputation(questionRept);
        }

        public void AnswerQuestion(string content, Question question)
        {
            Answer answer = new Answer(this, content, question);

            Answers.Add(answer);

            UpdateReputation(questionRept);
        }

        public void WriteComment(string content)
        {
            Comment comment = new Comment(this, content);

            Comments.Add(comment);

            UpdateReputation(commentRept);
        }

        public String GetUsername() { return UserName; }
        public int GetReputation() { return Reputation; }
        public List<Question> GetQuestions() { return new List<Question>(Questions); }
        public List<Answer> GetAnswers() { return new List<Answer>(Answers); }
        public List<Comment> GetComments() { return new List<Comment>(Comments); }
    }
}

