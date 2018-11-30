using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.Logic.Models;

namespace GameManage.Logic.Interfaces
{
    public interface ISpecializationCollection
    {
        List<Specialization> GetAll();
    }
}
