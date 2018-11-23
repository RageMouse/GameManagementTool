using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;

namespace GameManage.DAL.MSSQL
{
     public class CharacterMSSQLContext : ICharacterContext
    {
        public List<CharacterDTO> GetCharacters(CharacterDTO characters)
        {
            throw new NotImplementedException();
        }

        private readonly string _connectionstring;

        public CharacterMSSQLContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void AddCharacter(CharacterDTO character)
        {
                try
                {
                    using (SqlConnection connection = Database.getConnection())
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("dbo.AddCharacter", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("Name", character.Name);
                            command.Parameters.AddWithValue("CreatedOn", character.CreatedOn);
                            command.Parameters.AddWithValue("Specialization_Id", character.Specialization_Id);
                            command.Parameters.AddWithValue("Score", character.Score);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception e)
                {
                    //todo a good exception
                    Console.WriteLine(e);
                }
        }

        public void RemoveCharacter(CharacterDTO character)
        {
            //todo write code
            throw new NotImplementedException();
        }
    }
}
