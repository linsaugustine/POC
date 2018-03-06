using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChartNav.WaveIntegrationService.DataProvider.EFCore.Models
{
    public class ChartNavDBContext : DbContext
    {

        public readonly string connectionString;

        public virtual DbSet<TestDomainValue> TestDomainValues { get; set; }
        public ChartNavDBContext(string cnnString)
        {
            connectionString = cnnString;
        }
    }
}
