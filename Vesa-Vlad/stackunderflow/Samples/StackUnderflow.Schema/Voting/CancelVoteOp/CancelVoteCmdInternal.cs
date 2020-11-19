﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackUnderflow.Domain.Schema.Voting.CancelVoteOp
{
    public class CancelVoteCmdInternal : CancelVoteCmd
    {

        public CancelVoteCmdInternal(int tenantId, Guid userId, int questionId) : base(questionId)
        {
            TenantId = tenantId;
            UserId = userId;
        }

        public int TenantId { get; }
        public Guid UserId { get; }
    }
}
