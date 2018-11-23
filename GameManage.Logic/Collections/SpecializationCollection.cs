using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.Logic.Interfaces;

namespace GameManage.Logic.Models
{
    public class SpecializationCollection : ISpecializationCollection
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

        public void AddSpecialization(Specialization specialization)
        {
            Specializations.Add(specialization);
        }

        public void RemoveSpecialization(Specialization specialization)
        {
            Specializations.Remove(specialization);
        }
    }
}
