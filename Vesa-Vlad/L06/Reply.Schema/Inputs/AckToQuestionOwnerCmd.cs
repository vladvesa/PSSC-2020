using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.Inputs
{
    public class AckToQuestionOwnerCmd
    {
        public int QuestionId { get; private set; }
        public int ReplyId { get; private set; }
        public string ReplyBody { get; private set; }

        public AckToQuestionOwnerCmd(int questionId, int replyId, string replyBody)
        {
            this.QuestionId = questionId;
            this.ReplyId = replyId;
            this.ReplyBody = replyBody;
        }
    }
}
