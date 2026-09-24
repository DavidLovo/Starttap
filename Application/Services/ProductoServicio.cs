using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ProductoServicio
    {
        private readonly IProductosRepository _productsRepository;

        public ProductoServicio(IProductosRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async Task<IEnumerable<ProductoDto>> ListarProductos()
        {
            var olist = await _productsRepository.ListarProductosAsyncs();

            return olist.Select(p => new ProductoDto 
            {
            Id_Producto = p.Id_Producto,
            Codigo_Producto = p.Codigo_Producto,
            Nombre_Producto = p.Nombre_Producto,
            Descripcion = p.Descripcion,
            Presentacion = p.Presentacion,
            Lote = p.Lote,
            Fecha_Caducidad = p.Fecha_Caducidad,
            Costo_Unitario = p.Costo_Unitario,
            Precio_Venta = p.Precio_Venta,
            Estado = p.Estado,
            Categoria = p.Categoria,
            Id_Proveedor = p.Id_Proveedor,
            Fecha_Ingreso = p.Fecha_Ingreso,
            });
        }

        public async Task NuevoProducto(ProductoDto oProductoDto)
        {
            var oProducto = new Productos
            {
                Codigo_Producto = oProductoDto.Codigo_Producto,
                Nombre_Producto = oProductoDto.Nombre_Producto,
                Descripcion = oProductoDto.Descripcion,
                Presentacion = oProductoDto.Presentacion,
                Lote = oProductoDto.Lote,
                Fecha_Caducidad = oProductoDto.Fecha_Caducidad,
                Costo_Unitario = oProductoDto.Costo_Unitario,
                Precio_Venta = oProductoDto.Precio_Venta,
                Estado = oProductoDto.Estado,
                Categoria = oProductoDto.Categoria,
                Id_Proveedor = oProductoDto.Id_Proveedor,
                Fecha_Ingreso = oProductoDto.Fecha_Ingreso,
            };
            await _productsRepository.NuevoProductoAsync(oProducto);
        }

        public async Task EditarProducto(ProductoDto oProductoDto)
        {
            var oProducto = new Productos
            {
                Id_Producto = oProductoDto.Id_Producto,
                Codigo_Producto = oProductoDto.Codigo_Producto,
                Nombre_Producto = oProductoDto.Nombre_Producto,
                Descripcion = oProductoDto.Descripcion,
                Presentacion = oProductoDto.Presentacion,
                Lote = oProductoDto.Lote,
                Fecha_Caducidad = oProductoDto.Fecha_Caducidad,
                Costo_Unitario = oProductoDto.Costo_Unitario,
                Precio_Venta = oProductoDto.Precio_Venta,
                Estado = oProductoDto.Estado,
                Categoria = oProductoDto.Categoria,
                Id_Proveedor = oProductoDto.Id_Proveedor,
                Fecha_Ingreso = oProductoDto.Fecha_Ingreso,
            };
        }
    }
}
