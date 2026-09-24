using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    internal interface IDetalleIngresoRepository
    {
        Task<IEnumerable<Detalle_Ingreso>> ListarDetalleIngresoAsync();
        Task NuevoDetalleIngresoAsync(Detalle_Ingreso odetalle);
        Task EditarDetalleIngresoAsync(Detalle_Ingreso odetalle);
    }
}
