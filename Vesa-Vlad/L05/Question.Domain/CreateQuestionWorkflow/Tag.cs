using CSharp.Choices;
using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    [AsChoice]
    public static partial class Tag
    {
        public interface ITag { }
        public class UnverifiedTag : ITag
        {
            public string Tag { get; private set; }
            private UnverifiedTag(string tag)
            {
                Tag = tag;
            }

            private static bool IsTagValid(string tags)
            {
                if (tags.Length >= 1)
                {
                    return true;
                }
                return false;
            }

            public static Result<UnverifiedTag> Create(string tags)
            {
                if (IsTagValid(tags))
                {
                    return new UnverifiedTag(tags);
                }
                else
                {
                    return new Result<UnverifiedTag>(new InvalidTagException(tags));
                }
            }
        }

        public class VerifiedTag : ITag
        {
            public string Tag { get; private set; }
            internal VerifiedTag(string tag)
            {
                Tag = tag;
            }
        }
    }
}
