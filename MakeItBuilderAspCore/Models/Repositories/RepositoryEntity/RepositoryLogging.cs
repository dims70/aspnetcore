﻿
using MakeItBuilderAspCore.Models.DatabaseEngine;
using MakeItBuilderAspCore.Models.Entities;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories.RepositoryEntity
{
    public class RepositoryLogging : RepositoryCRUD<LoggingEntity.LoggingEntity>
    {
        public RepositoryLogging() : base(nameCollection:"LogTarget") { /*пустой*/ }
        public void AddScopeLogTarget(LoggingEntity.LoggingEntity scope) 
            => CreateAsync(scope);
    }
}