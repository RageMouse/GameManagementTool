using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManage.Logic.Models
{
    class SpecializationCollection
    {
        //Properties
        public List<Specialization> Specializations { get; private set; }

        //Constructors
        public SpecializationCollection(List<Specialization> specializations)
        {
            Specializations = GetSpecializations();
        }

        //Methods
        public List<Specialization> GetSpecializations()
        {
            throw new NotImplementedException();
        }
    }
}
