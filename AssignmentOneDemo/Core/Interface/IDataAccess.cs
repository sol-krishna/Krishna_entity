using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IDataAccess
    {
        Guid CreateRecord<T>(T entity) where T : BaseEntity;
        void DeleteRecord<T>(Guid idToDelete) where T : BaseEntity;
        List<T> GetAllRecords<T>() where T : BaseEntity;
        T GetRecordById<T>(Guid id) where T : BaseEntity;
        void UpdateRecord<T1, T2>(T1 dto) where T2 : BaseEntity where T1: IDto;
    }
}
