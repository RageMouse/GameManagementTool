using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManage.DAL.Interfaces.DTOs;
using GameManage.DAL.Interfaces.Interfaces;
using GameManage.Logic.Interfaces;

namespace GameManage.Logic.Models
{
    public class SpecializationCollection : ISpecializationCollection
    {
        //Properties
        public List<Specialization> Specializations { get; private set; }

        private ISpecializationContext specializationContext;

        //Constructors
        public SpecializationCollection(List<Specialization> specializations)
        {
            Specializations = GetSpecializations();
        }

        public SpecializationCollection(ISpecializationContext context)
        {
            specializationContext = context;
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

        public List<Specialization> GetAll()
        {
            List<SpecializationDTO> SpecializationDTO = specializationContext.GetAll();
            List<Specialization> AllSpecializations = new List<Specialization>();
            foreach (SpecializationDTO specializationDto in SpecializationDTO)
            {
                Specialization specialization = new Specialization(specializationDto.Id, specializationDto.Name, specializationDto.Description, specializationDto.HealthPoints, specializationDto.AttackPoints);
                AllSpecializations.Add(specialization);
            }

            return AllSpecializations;
        }
    }
}