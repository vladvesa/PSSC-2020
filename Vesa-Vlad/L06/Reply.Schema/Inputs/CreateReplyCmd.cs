using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.Inputs
{
    public class CreateReplyCmd
    {
        public int QuestionId { get; }
        public int AuthorId { get; }
        public string ReplyBody { get; }

        public CreateReplyCmd (int questionId, int authorId, string replyBody)
        {
            this.QuestionId = questionId;
            this.AuthorId = authorId;
            this.ReplyBody = replyBody;
        }
    }
}
