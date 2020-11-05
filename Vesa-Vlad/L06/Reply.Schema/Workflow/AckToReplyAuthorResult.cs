using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyWorkflow
{
    public class AckToReplyAuthorResult
    {
        public interface IAckToReplyAuthorResult { }

        public class ValidReplyPublished : IAckToReplyAuthorResult
        {
            public string ValidAck { get; private set; }

            public ValidReplyPublished (string validAck)
            {
                this.ValidAck = validAck;
            }
        }

        public class InvalidReplyPublished : IAckToReplyAuthorResult
        {
            public string ErrorMsg { get; private set; }

            public InvalidReplyPublished(string errorMsg)
            {
                this.ErrorMsg = ErrorMsg;
            }
        }
    }
}
