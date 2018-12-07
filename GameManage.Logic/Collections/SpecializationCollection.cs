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
        private List<Specialization> Specializations { get; set; }

        private readonly ISpecializationContext _specializationContext;

        //Constructors
        public SpecializationCollection(List<Specialization> specializations)
        {
            Specializations = GetSpecializations();
        }

        public SpecializationCollection(ISpecializationContext context)
        {
            _specializationContext = context;
        }

        //Methods
        private List<Specialization> GetSpecializations()
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
            List<SpecializationDTO> SpecializationDTO = _specializationContext.GetAll();
            List<Specialization> AllSpecializations = new List<Specialization>();
            foreach (SpecializationDTO specializationDto in SpecializationDTO)
            {
                Specialization specialization = new Specialization(specializationDto.Id, specializationDto.Name, specializationDto.Description, specializationDto.HealthPoints, specializationDto.AttackPoints);
                AllSpecializations.Add(specialization);
            }

            return AllSpecializations;
        }

        public Specialization GetById(int id)
        {
            SpecializationDTO specialization = _specializationContext.GetById(id);
            return new Specialization(specialization.Id, specialization.Name);
        }
    }
}