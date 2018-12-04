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
    public class SpecializationMSSQLContext : ISpecializationContext
    {
        public List<CharacterDTO> GetCharacters(CharacterDTO characters)
        {
            throw new NotImplementedException();
        }

        private readonly string _connectionstring;

        public SpecializationMSSQLContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public List<SpecializationDTO> GetAll()
        {
            List<SpecializationDTO> specializations = new List<SpecializationDTO>();
            SpecializationDTO specialization;
            string query = "SELECT * FROM Specialization";

            try
            {
                using (SqlConnection connection = Database.getConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    foreach (DbDataRecord record in cmd.ExecuteReader())
                    {
                        specialization = new SpecializationDTO
                        (
                            record.GetInt32(record.GetOrdinal("id")),
                            record.GetString(record.GetOrdinal("name")),
                            record.GetString(record.GetOrdinal("description")),
                            record.GetInt32(record.GetOrdinal("healthPoints")),
                            record.GetInt32(record.GetOrdinal("attackPoints"))
                        );
                        specializations.Add(specialization);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return specializations;
        }

        public SpecializationDTO GetById(int id)
        {
            List<SpecializationDTO> specializations = new List<SpecializationDTO>();

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("GetSpecializationById", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    con.Open();
                    cmd.Parameters.AddWithValue("@specializationID", id);

                    foreach (DbDataRecord record in cmd.ExecuteReader())
                    {
                        SpecializationDTO specialization = new SpecializationDTO
                        (
                            record.GetInt32(record.GetOrdinal("id"))
                        );
                        specializations.Add(specialization);
                    }
                }
                return specializations[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}