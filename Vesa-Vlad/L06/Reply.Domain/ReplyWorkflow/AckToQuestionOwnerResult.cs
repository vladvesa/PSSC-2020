using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyWorkflow
{
    public class AckToQuestionOwnerResult
    {
        public interface IAckToQuestionOwnerResult { }

        public class ValidReplyRecieved : IAckToQuestionOwnerResult
        {
            public string ValidAck { get; private set; }
            public ValidReplyRecieved(string validAck)
            {
                this.ValidAck = validAck;
            }
        }

        public class InvalidReplyRecieved : IAckToQuestionOwnerResult
        {
            public string ErrorMsg { get; private set; }
            public InvalidReplyRecieved(string errorMsg)
            {
                this.ErrorMsg = errorMsg;
            }
        }
    }
}
