using Primitives.IO;
using Reply.Domain.Inputs;
using Reply.Domain.ReplyWorkflow;
using static PortExt;
using System;
using System.Collections.Generic;
using System.Text;
using Reply.Schema.Workflow;

namespace Reply.Domain
{
    public class ReplyDomain
    {
        public static Port<CreateReplyResult.ICreateReplyResult> ValidateReply(int questionId, int authorId, string replyBody)
            => NewPort<CreateReplyCmd, CreateReplyResult.ICreateReplyResult>(new CreateReplyCmd(questionId, authorId, replyBody));
        public static Port<LanguageCheckResult.ILanguageCheckResult> LanguageCheck(string textToCheck)
            => NewPort<LanguageCheckCmd, LanguageCheckResult.ILanguageCheckResult>(new LanguageCheckCmd(textToCheck));
        public static Port<AckToQuestionOwnerResult.IAckToQuestionOwnerResult> SendAckToQuestionOwner(int questionId, int replyId, string replyBody)
            => NewPort<AckToQuestionOwnerCmd, AckToQuestionOwnerResult.IAckToQuestionOwnerResult>(new AckToQuestionOwnerCmd(questionId, replyId, replyBody));
        public static Port<AckToReplyAuthorResult.IAckToReplyAuthorResult> SendAckToReplyAuthor(int questionId, int replyId, string replyBody)
            => NewPort<AckToReplyAuthorCmd, AckToReplyAuthorResult.IAckToReplyAuthorResult>(new AckToReplyAuthorCmd(questionId, replyId, replyBody));
    }
}
