using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedor>> LustarProveedorAsync();
        Task NuevoproveedorAsync(Proveedor oproveedor);
        Task EditarproveedorAsync(Proveedor oproveedor);
        Task EliminarproveedorLogicoAsync(Proveedor oproveedor);
    }
}
