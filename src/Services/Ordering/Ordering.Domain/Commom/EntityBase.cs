﻿using Ordering.Domain.Common;

namespace Ordering.Domain.Commom;

public abstract class EntityBase: ValueObject
{
    public int Id { get; protected set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}