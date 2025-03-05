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
    public class DataAccess : IDataAccess
    {
        private DataContext context;
        public DataAccess()
        {
            context = new DataContext();
        }

        public virtual Guid CreateRecord<T>(T entity) where T : BaseEntity
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();

            return entity.EntityId;
        }

        public virtual void DeleteRecord<T>(Guid idToDelete) where T : BaseEntity
        {
            var foundEntity = GetRecordById<T>(idToDelete);
            context.Set<T>().Remove(foundEntity);
            context.SaveChanges();
        }

        public virtual List<T> GetAllRecords<T>() where T : BaseEntity
        {
            return context.Set<T>().ToList();
        }

        public virtual T GetRecordById<T>(Guid id) where T : BaseEntity
        {
            return context.Set<T>().FirstOrDefault(x => x.EntityId == id);
        }

        public virtual void UpdateRecord<T1, T2>(T1 dto)
            where T1 : IDto
            where T2 : BaseEntity
        {
            var foundEntity = GetRecordById<T2>(dto.Id);
            foreach (var property in typeof(T1).GetProperties())
            {
                foreach (var propertyB in typeof(T2).GetProperties())
                {
                    if (property.Name == propertyB.Name && property.PropertyType == propertyB.PropertyType)
                    {
                        propertyB.SetValue(foundEntity, property.GetValue(dto));
                    }
                }
            }

            context.SaveChanges();
        }
    }
}
