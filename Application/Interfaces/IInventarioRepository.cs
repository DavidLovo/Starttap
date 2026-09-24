using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IInventarioRepository
    {
        Task<IEnumerable<Inventario>> ListarInventarioAsync();
        Task NuevoInventarioAsync(Inventario oinventario);
        Task EditarInventarioAsync(Inventario oinventario);
        Task EliminarInventarioLogicoAsync(Inventario oinventario);
    }
}
