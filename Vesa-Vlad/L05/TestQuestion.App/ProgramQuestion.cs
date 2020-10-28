using LanguageExt;
using Question.Domain.CreateQuestionWorkflow;
using System;
using System.Collections.Generic;
using static Question.Domain.CreateQuestionWorkflow.Question;

namespace TestQuestion.App
{
    public class ProgramQuestion
    {
        static void Main(string[] args)
        {
            List<string> tags = new List<string>()
            {
                "C#",
                "Coding",
                "Version"
            };

            var result = UnverifiedQuestion.Create("What will this do in C#?");


            result.Match(
                    Succ: question =>
                    {
                        EnableVoteQuestion(question);

                        Console.WriteLine("Question is available for voting.");
                        return Unit.Default;
                    },
                    Fail: ex =>
                    {
                        Console.WriteLine($"Question was not posted because: {ex.Message}");
                        return Unit.Default;
                    }
                );


            Console.ReadLine();
        }

        private static void EnableVoteQuestion(UnverifiedQuestion question)
        {
            var verifiedQuestionResult = new VerifyQuestionService().VerifyQuestion(question);
            verifiedQuestionResult.Match(
                    EnableVoteQuestion =>
                    {
                        new VerifyVotesService().VerifyVotes(EnableVoteQuestion).Wait();
                        return Unit.Default;
                    },
                    ex =>
                    {
                        Console.WriteLine("This question can't be voted");
                        return Unit.Default;
                    }
                );
        }

    }
}
