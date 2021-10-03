using StudentHub_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHub_API.Domain.Persistence.Repositories
{
    public interface IDocumentRepository
    {
        Task<IEnumerable<Document>> ListAsync();
        Task AddAsync(Document document);
        Task<Document> FindById(int id);
        void Update(Document document);
        void Remove(Document document);
    }
}
