using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL;
using GameManage.DAL.Interfaces.Interfaces;
using GameManage.DAL.Memory;
using GameManage.DAL.MSSQL;
using GameManage.Logic.Interfaces;
using GameManage.Logic.Models;
using Microsoft.Extensions.Configuration;

namespace GameManage.DAL.Factory
{
    public class CharacterFactory
    {
        private readonly string _context;

        public CharacterFactory(IConfiguration configuration)
        {
            _context = configuration.GetSection("Database").GetSection("Type").Value;
            configuration.GetConnectionString(_context);
        }

        private ICharacterContext GetCharacterContext()
        {
            switch (_context)
            {
                case "MSSQL":
                    return new CharacterMSSQLContext();
                case "MEMORY":
                    return new CharacterMemoryContext();
                default:
                    throw new NotImplementedException();
            }
        }

        public ICharacterCollection CharacterCollection() => new CharacterCollection(GetCharacterContext());
    }
}
