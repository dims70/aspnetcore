using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MakeItBuilderAspCore.Models.Repositories
{
    interface IRepostitoryCRUD<T>
        where T:class
    {
        void CreateAsync(T item);
        Task<T> GetById(string objectId);
        Task<IEnumerable<T>> GetCollectionEntity();
        void UpdateAsync(ObjectId updateElement, T newElement);
        void DeleteAsync(string deleteId);

    }
}
