using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    internal interface IComprobanteRepository
    {
        Task<IEnumerable<Tipo_Comprobante>> LustarComprobanteAsync();
        Task NuevoComprobanteAsync(Tipo_Comprobante ocomprobante);
        Task EditarComprobanteAsync(Tipo_Comprobante ocomprobante);
        Task EliminarComprobanteAsync(Tipo_Comprobante ocomprobante);
    }
}
