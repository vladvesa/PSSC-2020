using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Question.Domain.CreateQuestionWorkflow
{
    public static partial class Votes
    {
        public interface IVotes { }
        public class UnverifiedVotes : IVotes
        {
            public int Votes { get; private set; }
            private UnverifiedVotes(int votes)
            {
                Votes = votes;
            }

            private static bool IsVotesValid(int votes)
            {
                if (votes >= 0)
                {
                    return true;
                }
                return false;
            }

            public static Result<UnverifiedVotes> Create(int votes)
            {
                if (IsVotesValid(votes))
                {
                    return new UnverifiedVotes(votes);
                }
                else
                {
                    return new Result<UnverifiedVotes>(new InvalidVotesException(votes));
                }
            }
        }

        public class VerifiedVotes : IVotes
        {
            public int Votes { get; private set; }
            internal VerifiedVotes(int votes)
            {
                Votes = votes;
            }
        }
    }
}
