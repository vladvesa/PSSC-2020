using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.Inputs
{
    public class AckToQuestionOwnerCmd
    {
        public string QuestionId { get; private set; }
        public string ReplyId { get; private set; }
        public string ReplyBody { get; private set; }

        public AckToQuestionOwnerCmd(string questionId, string replyId, string replyBody)
        {
            this.QuestionId = questionId;
            this.ReplyId = replyId;
            this.ReplyBody = replyBody;
        }
    }
}
