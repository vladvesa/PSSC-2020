using Question.Domain.CreateQuestionWorkflow;
using System;
using System.Collections.Generic;
using System.Text;
using static Question.Domain.CreateQuestionWorkflow.CreateQuestionResult;
using static Question.Domain.CreateQuestionWorkflow.CreateQuestionResult.QuestionCreated;

namespace QuestionTest.App
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var cmdQuestion = new CreateQuestionCmd("Titlu", "Descriere intrebare", "C/C++");
            var resultQuestion = CreateQuestion(cmdQuestion);
            resultQuestion.Match(
                    ProcessQuestionCreated,
                    ProcessQuestionNotCreated,
                    ProcessInvalidQuestion
                );
            Console.ReadLine();
        }

        private static ICreateQuestionResult ProcessQuestionCreated(QuestionCreated question)
        {
            Console.WriteLine($"Question {question.QuestionId}");
            return question;
        }

        private static ICreateQuestionResult ProcessQuestionNotCreated(QuestionNotCreated questionNotCreated)
        {
            Console.WriteLine($"Question not created: {questionNotCreated.Reason}");
            return questionNotCreated;
        }

        private static ICreateQuestionResult ProcessInvalidQuestion(QuestionValidationFailed validationFailed)
        {
            Console.WriteLine("Question validation failed: ");
            foreach (var error in validationFailed.ValidationErrors)
            {
                Console.WriteLine(error);
            }
            return validationFailed;
        }
        public static ICreateQuestionResult CreateQuestion(CreateQuestionCmd createQuestionCommand)
        {
            if (string.IsNullOrWhiteSpace(createQuestionCommand.Title) || string.IsNullOrWhiteSpace(createQuestionCommand.Description))
            {
                var errors = new List<string>() { "Invalid title or description" };
                return new QuestionValidationFailed(errors);
            }
            if (new Random().Next(10) > 1)
            {
                return new QuestionNotCreated("Question could not be verified");
            }
            var questionId = Guid.NewGuid();
            var results = new QuestionCreated(questionId, createQuestionCommand.Title, createQuestionCommand.Description, createQuestionCommand.Tag);
            return results;
        }
    }
}
