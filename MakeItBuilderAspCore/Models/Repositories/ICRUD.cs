namespace MakeItBuilderAspCore.Models.Repositories
{
    interface ICRUD<T,TypeId>
        where T:class
    {
        void Create(T item);
        T GetById(TypeId objectId);
        void Update(TypeId updateElement, T newElement);
        void Delete(TypeId deleteId);
    }
}
