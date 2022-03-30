using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestIngWebApp.Client.Services
{
    public abstract class ServiceBase
    {
        public ApiService ApiService { get; set; }
        public ILogger<ServiceBase> Logger { get; set; }
        public abstract string ControllerPath { get; }
        public ServiceBase(ApiService apiService, ILogger<ServiceBase> logger)
        {
            Logger = logger;
            ApiService = apiService;
        }
    }
}
