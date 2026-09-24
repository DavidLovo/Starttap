using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IProductosRepository
    {
        Task<IEnumerable<Productos>> ListarProductosAsyncs();
        Task NuevoProductoAsync(Productos oproductos);
        Task EditarProductoAsync(Productos oproductos);
        Task EliminarProductoLogicoAsync(Productos oproductos);

    }
}
