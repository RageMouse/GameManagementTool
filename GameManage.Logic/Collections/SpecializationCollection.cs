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
        public List<Specialization_Id> Specializations { get; private set; }

        private ISpecializationContext specializationContext;

        //Constructors
        public SpecializationCollection(List<Specialization_Id> specializations)
        {
            Specializations = GetSpecializations();
        }

        public SpecializationCollection(ISpecializationContext context)
        {
            specializationContext = context;
        }

        //Methods
        public List<Specialization_Id> GetSpecializations()
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
            List<SpecializationDTO> SpecializationDTO = specializationContext.GetAll();
            List<Specialization_Id> AllSpecializations = new List<Specialization_Id>();
            foreach (SpecializationDTO specializationDto in SpecializationDTO)
            {
                Specialization_Id specialization = new Specialization_Id(specializationDto.Id, specializationDto.Name, specializationDto.Description, specializationDto.HealthPoints, specializationDto.AttackPoints);
                AllSpecializations.Add(specialization);
            }

            return AllSpecializations;
        }

        public Specialization_Id GetById(int Id)
        {
            SpecializationDTO specialization = specializationContext.GetById(Id);
            return new Specialization_Id(specialization.Id, specialization.Name);
        }
    }
}