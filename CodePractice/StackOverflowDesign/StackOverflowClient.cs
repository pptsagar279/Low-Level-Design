
namespace CodePractice.StackOverflowDesign
{
    public class StackOverflowClient
    {
        public void Process()
        {
            StackOverflow system = new StackOverflow();

            User alice = system.CreateUser("Alice", "alice@example.com");
            User bob = system.CreateUser("Bob", "bob@example.com");
            User charlie = system.CreateUser("Charlie", "charlie@example.com");
            
            Question javaQuestion = system.AskQuestion("What is polymorphism in Java?",
                "Can someone explain polymorphism in Java with an example?", alice,
                new List<string> { "C#", "oop" });

            // Bob answers Alice's question
            Answer bobAnswer = system.AddAnswer("Polymorphism in Java is the ability of an object to take on many forms...", javaQuestion, bob);

            // Charlie comments on the question
            system.AddComment("Great question! I'm also interested in learning about this.", charlie, javaQuestion);

            // Alice comments on Bob's answer
            system.AddComment("Thanks for the explanation! Could you provide a code example?", alice, bobAnswer);

            // Charlie votes on the question and answer
            system.GiveVote(javaQuestion, charlie, VoteType.UPVOTE);  // Upvote
            system.GiveVote(bobAnswer, charlie, VoteType.UPVOTE);  // Upvote

            // Alice accepts Bob's answer
            system.AcceptAnswer(bobAnswer);

            // Print out the current state
            Console.WriteLine("Question: " + javaQuestion.GetTitle());
            Console.WriteLine("Asked by: " + javaQuestion.GetAuthor().GetUsername());

            Console.WriteLine("Comments: " + javaQuestion.GetComments().Count());
            Console.WriteLine("\nAnswer by " + bobAnswer.GetAuthor().GetUsername() + ":");
            Console.WriteLine(bobAnswer.GetContent());

            Console.WriteLine("Accepted: " + bobAnswer.IsAccepted());
            Console.WriteLine("Comments: " + bobAnswer.GetComments().Count());

            Console.WriteLine("\nUser Reputations:");
            Console.WriteLine("Alice: " + alice.GetReputation());
            Console.WriteLine("Bob: " + bob.GetReputation());
            Console.WriteLine("Charlie: " + charlie.GetReputation());
        }
    }
}
