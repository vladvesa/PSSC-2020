﻿using CSharp.Choices;
using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.ReplyWorkflow
{
    public class Reply
    {
        public string QuestionId { get; }
        public string AuthorId { get; }
        public string ReplyBody { get; }

        public Reply (string questionId, string authorId, string replyBody)
        {
            this.QuestionId = questionId;
            this.AuthorId = authorId;
            this.ReplyBody = replyBody;
        }
    }

    public class Question
    {
        public string Title { get; private set; }
        public string Body { get; private set; }
        public string Tags { get; private set; }

        public Question (string title, string body, string tags)
        {
            this.Title = title;
            this.Body = body;
            this.Tags = tags;
        }
    }
}
