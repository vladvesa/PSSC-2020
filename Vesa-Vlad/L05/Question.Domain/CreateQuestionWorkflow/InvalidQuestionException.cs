using System;
using System.Collections.Generic;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    [Serializable]
    public class InvalidQuestionException : Exception
    {
        public InvalidQuestionException() { }
        public InvalidQuestionException(string question) : base($"The value \"{question}\" has an invalid format") { }
    }
}
