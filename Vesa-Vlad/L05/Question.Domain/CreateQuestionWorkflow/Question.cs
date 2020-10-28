using CSharp.Choices;
using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    [AsChoice]
    public static partial class Question
    {
        public interface IQuestion { }
        public class UnverifiedQuestion : IQuestion
        {
            public string Question { get; private set; }
            
            private UnverifiedQuestion(string question)
            {
                this.Question = question;
            }

            private static bool IsQuestionValid(string question)
            {
                if(question.Length <= 500)
                {
                    return true;
                }
                return false;
            }

            public static Result<UnverifiedQuestion> Create(string question)
            {
                if (IsQuestionValid(question))
                {
                    return new UnverifiedQuestion(question);
                }
                else
                {
                    return new Result<UnverifiedQuestion>(new InvalidQuestionException(question));
                }
            }
        }

        public class VerifiedQuestion : IQuestion
        {
            public string Question { get; private set; }
            internal VerifiedQuestion(string question)
            {
                Question = question;
            }
        }
    }
}
