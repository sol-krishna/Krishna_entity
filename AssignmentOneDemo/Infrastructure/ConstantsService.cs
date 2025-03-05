using Core.Dto;
using Core.Entity;
using Core.Interface;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ConstantsService
    {
        private IDataAccess access;
        public ConstantsService() 
        {
            access = new DataAccess();
        }

        public void CreateNewConstant()
        {
            var newConstant = new Constants();
            newConstant.CreatedBy = "System";
            var name = ValidationHelper.CheckForEmpty("Please enter the name of the constant");
            var value = ValidationHelper.CheckForEmpty("Please enter the value of the constant");
            var description = ValidationHelper.CheckForMaxLength("Please enter a description 200 or less in length", 200);
            newConstant.Name = name;
            newConstant.Value = value;
            newConstant.Description = description;

            access.CreateRecord(newConstant);
        }

        public void UpdateConstant()
        {
            var constantToUpdate = ValidationHelper.CheckForGuidType("Please enter the id of an existing constant");
            var foundConstant = GetById(constantToUpdate);
            if(foundConstant != null)
            {
                var constant = new ConstantsDto();
                constant.Id = constantToUpdate;
                constant.Name = ValidationHelper.CheckForEmpty("Please enter the name of the constant");
                constant.Value = ValidationHelper.CheckForEmpty("Please enter the value of the constant");
                constant.Description = ValidationHelper.CheckForMaxLength("Please enter a description 200 or less in length", 200);

                access.UpdateRecord<ConstantsDto, Constants>(constant);
            }
            else
            {
                Console.WriteLine("No record with that id exists");
            }
        }

        public void DeleteConstant()
        {
            var constantToDelete = ValidationHelper.CheckForGuidType("Please enter the id of an existing constant");
            var foundConstant = GetById(constantToDelete);
            if(foundConstant != null )
            {
                access.DeleteRecord<Constants>(constantToDelete);
            }
        }

        public List<Constants> GetAllConstants()
        {
            return access.GetAllRecords<Constants>();
        }

        public Constants GetById(Guid id)
        {
            return access.GetRecordById<Constants>(id);
        }
    }
}
