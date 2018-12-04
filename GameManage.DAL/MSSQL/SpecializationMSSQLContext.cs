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
        public List<SpecializationDTO> GetAll()
        {
            List<SpecializationDTO> specializations = new List<SpecializationDTO>();
            string query = "SELECT * FROM Specialization";

            try
            {
                using (SqlConnection connection = Database.getConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    foreach (DbDataRecord record in cmd.ExecuteReader())
                    {
                        var specialization = new SpecializationDTO
                        (
                            record.GetInt32(record.GetOrdinal("id")),
                            record.GetString(record.GetOrdinal("name")),
                            record.GetString(record.GetOrdinal("description")),
                            record.GetInt32(record.GetOrdinal("healthPoints")),
                            record.GetInt32(record.GetOrdinal("attackPoints"))
                        );
                        specializations.Add(specialization);
                    }

                    connection.Close();
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
                using (SqlConnection connection = Database.getConnection())
                {
                    SqlCommand cmd = new SqlCommand("GetSpecializationById", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    connection.Open();
                    cmd.Parameters.AddWithValue("@specializationID", id);

                    foreach (DbDataRecord record in cmd.ExecuteReader())
                    {
                        SpecializationDTO specialization = new SpecializationDTO
                        (
                            record.GetInt32(record.GetOrdinal("id"))
                        );
                        specializations.Add(specialization);
                    }

                    connection.Close();
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