using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.Interfaces;
using GameManage.DAL.Memory;
using GameManage.DAL.MSSQL;
using GameManage.Logic.Interfaces;
using GameManage.Logic.Models;
using Microsoft.Extensions.Configuration;

namespace GameManage.DAL.Factory
{
    public class SpecializationFactory
    {
        private readonly string _context;
        private readonly string _connectionString;

        public SpecializationFactory(IConfiguration configuration)
        {
            _context = configuration.GetSection("Database").GetSection("Type").Value;
            _connectionString = configuration.GetConnectionString(_context);
        }

        public ISpecializationContext GetSpecializationContext()
        {
            switch (_context)
            {
                case "MSSQL":
                    return new SpecializationMSSQLContext(_connectionString);
                default:
                    throw new NotImplementedException();
            }
        }

        public ISpecializationCollection SpecializationCollection() => new SpecializationCollection(GetSpecializationContext());

    }
}
