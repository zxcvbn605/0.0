using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a.DAL
{
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}