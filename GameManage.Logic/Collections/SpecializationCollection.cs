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
        private List<Specialization_Id> Specializations { get; set; }

        private readonly ISpecializationContext _specializationContext;

        //Constructors
        public SpecializationCollection(List<Specialization_Id> specializations)
        {
            Specializations = GetSpecializations();
        }

        public SpecializationCollection(ISpecializationContext context)
        {
            _specializationContext = context;
        }

        //Methods
        private List<Specialization_Id> GetSpecializations()
        {
            throw new NotImplementedException();
        }

        public void AddSpecialization(Specialization_Id specialization)
        {
            Specializations.Add(specialization);
        }

        public void RemoveSpecialization(Specialization_Id specialization)
        {
            Specializations.Remove(specialization);
        }

        public List<Specialization_Id> GetAll()
        {
            List<SpecializationDTO> SpecializationDTO = _specializationContext.GetAll();
            List<Specialization_Id> AllSpecializations = new List<Specialization_Id>();
            foreach (SpecializationDTO specializationDto in SpecializationDTO)
            {
                Specialization_Id specialization = new Specialization_Id(specializationDto.Id, specializationDto.Name, specializationDto.Description, specializationDto.HealthPoints, specializationDto.AttackPoints);
                AllSpecializations.Add(specialization);
            }

            return AllSpecializations;
        }

        public Specialization_Id GetById(int id)
        {
            SpecializationDTO specialization = _specializationContext.GetById(id);
            return new Specialization_Id(specialization.Id, specialization.Name);
        }
    }
}