using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
        public List<CharacterDTO> GetCharacters()
        {
            List<CharacterDTO> characters = new List<CharacterDTO>();
            try
            {
                using (SqlConnection connection = Database.getConnection())
                {
                    using (SqlCommand command = new SqlCommand("ShowCharacters", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    })
                    {
                        connection.Open();
                        foreach (DbDataRecord record in command.ExecuteReader())
                        {
                            CharacterDTO user = new CharacterDTO(
                                record.GetInt32(record.GetOrdinal("CharacterId")),
                                record.GetString(record.GetOrdinal("CharacterName")),
                                record.GetDateTime(record.GetOrdinal("CreatedOn")),
                                record.GetString(record.GetOrdinal("SpecializationName")),
                                record.GetInt32(record.GetOrdinal("Score"))
                            );
                            characters.Add(user);
                        }

                        connection.Close();
                    }
                }

                return characters;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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
                        command.Parameters.AddWithValue("Specialization_Id", character.SpecializationId);
                        command.Parameters.AddWithValue("Score", character.Score);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
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