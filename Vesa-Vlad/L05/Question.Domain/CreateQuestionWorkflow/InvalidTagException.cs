using System;
using System.Collections.Generic;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    [Serializable]
    public class InvalidTagException : Exception
    {
        public InvalidTagException() { }
        public InvalidTagException(string tags) : base($"The value \"{tags}\" is invalid.") { }
    }
}
