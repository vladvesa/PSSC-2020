using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.Inputs
{
    public class CreateReplyCmd
    {
        public string QuestionId { get; }
        public string AuthorId { get; }
        public string ReplyBody { get; }

        public CreateReplyCmd (string questionId, string authorId, string replyBody)
        {
            this.QuestionId = questionId;
            this.AuthorId = authorId;
            this.ReplyBody = replyBody;
        }
    }
}
