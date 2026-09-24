using Application.Dtos;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class InventarioServices
    {
        private readonly IInventarioRepository _inventarioRepository;

        public InventarioServices(IInventarioRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }

        public async Task<IEnumerable<InventarioDto>> ListarInventario()
        {
            var olis = await _inventarioRepository.ListarInventarioAsync();

            return olis.Select(i => new InventarioDto
            {
                Id_Inventario = i.Id_Inventario,
                Id_Producto = i.Id_Producto,
                Nombre_Producto = i.Nombre_Producto,
                Id_Proveedor = i.Id_Proveedor,
                Nombre_Proveedor = i.Nombre_Proveedor,
                Cantidad = i.Cantidad,                
            });
        }
    }
}
