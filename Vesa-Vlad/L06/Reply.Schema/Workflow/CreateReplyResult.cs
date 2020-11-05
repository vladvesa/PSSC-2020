using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyWorkflow
{
    public static partial class CreateReplyResult
    {
        public interface ICreateReplyResult { }
        public interface IValidateReplyResult { }

        public class ValidReply : ICreateReplyResult
        {
            public UnvalidatedReply ReplyObj { get; private set; }
            
            public ValidReply(UnvalidatedReply replyObj)
            {
                this.ReplyObj = replyObj;
            }
        }

        public class InvalidReply : ICreateReplyResult
        {
            public string Reason { get; private set; }

            public InvalidReply (string reason)
            {
                this.Reason = reason;
            }
        }

        public class ErrorReply : IValidateReplyResult
        {
            public string ValidationErrors { get; private set; }

            public ErrorReply(string validationErrors)
            {
                this.ValidationErrors = validationErrors;
            }
        }
    }
}
