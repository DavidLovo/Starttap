using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    internal interface IIngresoProductoRepository
    {
        Task<IEnumerable<Ingreso_Producto>> LustarIngresoProductoAsync();

        Task NuevoIngresoProductoAsync(Ingreso_Producto oingreso);

        Task AnularIngresoProductoAsync(Ingreso_Producto oingreso);

        //Task<IEnumerable<Ingreso_Producto>> BuscarIngresoProductoProveedorAsync(string buscar);

        //Task<IEnumerable<Ingreso_Producto>> BuscarIngresoProductoFechaAsync(string buscar);

        //Task<IEnumerable<Ingreso_Producto>> BuscarIngresoProductoComprobanteAsync(string buscar);

    }
}
