﻿using System;

namespace SqlRepo.Abstractions
{
    public interface IEntityValueMemberMapper : IEntityMemberMapper
    {
        int ColumnIndex { get; }
        string ColumnName { get; }
        EntityValueMemberMappingStrategy MappingStrategy { get; }
    }
}