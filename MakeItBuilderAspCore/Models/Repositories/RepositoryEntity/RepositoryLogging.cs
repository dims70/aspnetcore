
using MakeItBuilderAspCore.Models.DatabaseEngine;
using MakeItBuilderAspCore.Models.Entities;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories.RepositoryEntity
{
    public class RepositoryLogging : RepositoryCRUD<LoggingEntity.LoggingEntity>
    {
        public RepositoryLogging(IDbContext dbContext) : base(nameCollection:"LogTarget", dbContext) 
        { }
        public void AddScopeLogTarget(LoggingEntity.LoggingEntity scope) 
            => CreateAsync(scope);

        public async void AddErrorTarget(string error)
        {
            (await GetById(LoggingEntity.LoggingEntity.loggingEntity._id)).Error = error;
        }
    }
}
