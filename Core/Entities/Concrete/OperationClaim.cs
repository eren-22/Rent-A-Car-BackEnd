﻿using Core.Entities;

namespace Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int OperationClaimId { get; set; }
        public string Name { get; set; }
    }
}
