using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.Logic.Models;

namespace GameManage.Logic.Interfaces
{
    public interface ISpecializationCollection
    {
        List<Specialization_Id> GetAll();
        Specialization_Id GetById(int Id);
    }
}
