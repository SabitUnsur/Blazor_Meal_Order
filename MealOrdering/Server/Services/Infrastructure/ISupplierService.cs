using MealOrdering.Shared.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace MealOrdering.Server.Services.Infrastructure
{
    public interface ISupplierService
    {
        public Task<List<SupplierDTO>> GetSuppliers();

        public Task<SupplierDTO> CreateSupplier(SupplierDTO Order);

        public Task<SupplierDTO> UpdateSupplier(SupplierDTO Order);

        public Task DeleteSupplier(Guid SupplierId);

        public Task<SupplierDTO> GetSupplierById(Guid Id);
    }
}
