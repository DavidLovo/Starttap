using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> LustarClienteAsync();
        Task NuevoClienteAsync(Cliente ocliente);
        Task EditarClienteAsync(Cliente ocliente);
        Task EliminarClienteLogicoAsync(Cliente ocliente);
    }
}
