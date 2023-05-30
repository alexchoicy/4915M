using Quartz;
using System;
using System.Threading.Tasks;
using Server.Model.Entity;
using Server.Model;
using Microsoft.EntityFrameworkCore;

namespace Server.Helper.CornJob
{
    public class MappingJob : IJob
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly DataContext _dataContext;
        public MappingJob(IServiceProvider serviceProvider, DataContext dataContext)
        {
            _serviceProvider = serviceProvider;
            _dataContext = dataContext;
        }
        public Task Execute(IJobExecutionContext context)
        {
            // Resolve the required services
            using var scope = _serviceProvider.CreateScope();
            //var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            // Generate a new mapping ID
            int newMappingId = GenerateNewMappingId();

            // Save the new mapping in the database
            var newMapping = new Mapping { MappingId = newMappingId, Locked = false,status = "P"};
            _dataContext.mapping.Add(newMapping);
            _dataContext.SaveChanges();
            Console.WriteLine("i run");
            return Task.CompletedTask;
        }
        private int GenerateNewMappingId()
        { 
            var latestMapping = _dataContext.mapping.FromSqlRaw("SELECT * FROM mapping WHERE MappingID = (SELECT MAX(MappingID) FROM mapping)")
                .FirstOrDefault();
            latestMapping.Locked = true;
            _dataContext.mapping.Update(latestMapping);
            var newMappingID = latestMapping.MappingId + 1;

            return newMappingID;
        }
    }
}
