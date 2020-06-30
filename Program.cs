using System;

namespace Lesson5_3StructDemo
{
    class Program
    {
        struct Actor 
        {
            public int actorID;
            public string firstName;
            public string lastName;
            public DateTime lastupdate;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Actor goodActor = new Actor();
            goodActor.actorID = 1;
            goodActor.firstName = "Brad";
            goodActor.lastName = "Pitt";
            goodActor.lastupdate = DateTime.Now;

            Actor badActor = new Actor 
            { 
                actorID = 2, 
                firstName = "John", 
                lastName = "Smith", 
                lastupdate = DateTime.Now 
            };

            string messageGoodActor;
            messageGoodActor = $"{goodActor.firstName} {goodActor.lastName} is a very good actor.";

            string messageBadActor;
            messageBadActor = $"{badActor.firstName} {badActor.lastName} is a very bad actor.";

            Console.WriteLine($"{messageGoodActor} {messageBadActor}");

        }
    }
}
