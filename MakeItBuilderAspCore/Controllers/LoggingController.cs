using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeItBuilderAspCore.Models.LoggingEntity;
using MakeItBuilderAspCore.Models.Repositories.RepositoryEntity;
using Microsoft.AspNetCore.Mvc;

namespace MakeItBuilderAspCore.Controllers
{
    public class LoggingController : Controller
    {
        private readonly RepositoryLogging repositoryLogging;
        public LoggingController(RepositoryLogging repositoryLogging)
        {
            this.repositoryLogging = repositoryLogging;
        }
        [HttpPost]
        public IActionResult AddLogVisit(LoggingEntity entity)
        {
            repositoryLogging.AddScopeLogTarget(entity);
            return StatusCode(200);
        }
    }
}
