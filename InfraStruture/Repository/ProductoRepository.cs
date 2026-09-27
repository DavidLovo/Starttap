using Application.Interfaces;
using Domain.Entities;
using InfraStruture.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InfraStruture.Repository
{
    public class ProductoRepository : IProductosRepository
    {
        private readonly DBConectionFactory _dBConectionFactory;

        public ProductoRepository(DBConectionFactory dBConectionFactory)
        {
            _dBConectionFactory = dBConectionFactory;
        }

        public async Task<IEnumerable<Productos>> ListarProductosAsyncs()
        {
            using var con = _dBConectionFactory.CreateConnection();
            await con.OpenAsync();

            var olis = new List<Productos>();
            
            using var cmd = new SqlCommand("ListarProductos", con);
            cmd.CommandType = CommandType.StoredProcedure;
             
            using var dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {
                olis.Add(new Productos
                {
                    Id_Producto = Convert.ToInt32(dr["Id_Producto"]),
                    Codigo_Producto = dr["Codigo_Producto"].ToString(),
                    Nombre_Producto = dr["Nombre_Producto"].ToString(),
                    Descripcion = dr["Descripcion"].ToString(),
                    Presentacion = dr["Presentacion"].ToString(),
                    Lote = dr["Lote"].ToString(),
                    Fecha_Caducidad = Convert.ToDateTime(dr["Fecha_Caducidad"]),
                    Costo_Unitario = Convert.ToDecimal(dr["Costo_Unitario"]),
                    Precio_Venta = Convert.ToDecimal(dr["Precio_Venta"]),
                    Estado = dr["Estado"].ToString(),
                    Categoria = dr["Categoria"].ToString(),
                    Id_Proveedor = Convert.ToInt32(dr["Id_Proveedor"]),
                    Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"])
                });
            }
            return olis;            
        }

        public async Task NuevoProductoAsync(Productos oproductos)
        {
            using var con = _dBConectionFactory.CreateConnection();
            await con.OpenAsync();

            using var cmd = new SqlCommand("InsertarProductos", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Nombre_Producto", oproductos.Nombre_Producto));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", oproductos.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Presentacion", oproductos.Presentacion));
            cmd.Parameters.Add(new SqlParameter("@Lote", oproductos.Lote));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Caducidad", oproductos.Fecha_Caducidad));
            cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", oproductos.Costo_Unitario));
            cmd.Parameters.Add(new SqlParameter("@Precio_Venta", oproductos.Precio_Venta));
            cmd.Parameters.Add(new SqlParameter("@Estado", oproductos.Estado));
            cmd.Parameters.Add(new SqlParameter("@Categoria", oproductos.Categoria));
            cmd.Parameters.Add(new SqlParameter("@id_Proveedor", oproductos.Id_Proveedor));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", oproductos.Fecha_Ingreso));

           await cmd.ExecuteNonQueryAsync();
        }
        public async Task EditarProductoAsync(Productos oproductos)
        {
            using var con = _dBConectionFactory.CreateConnection();
            await con.OpenAsync();

            using var cmd = new SqlCommand("EditarProductos", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id_Producto", oproductos.Id_Producto));
            cmd.Parameters.Add(new SqlParameter("@Nombre_Producto", oproductos.Nombre_Producto));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", oproductos.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@Presentacion", oproductos.Presentacion));
            cmd.Parameters.Add(new SqlParameter("@Lote", oproductos.Lote));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Caducidad", oproductos.Fecha_Caducidad));
            cmd.Parameters.Add(new SqlParameter("@Costo_Unitario", oproductos.Costo_Unitario));
            cmd.Parameters.Add(new SqlParameter("@Precio_Venta", oproductos.Precio_Venta));
            cmd.Parameters.Add(new SqlParameter("@Estado", oproductos.Estado));
            cmd.Parameters.Add(new SqlParameter("@Categoria", oproductos.Categoria));
            cmd.Parameters.Add(new SqlParameter("@id_Proveedor", oproductos.Id_Proveedor));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", oproductos.Fecha_Ingreso));

            await cmd.ExecuteNonQueryAsync();
        }

        public Task EliminarProductoLogicoAsync(Productos oproductos)
        {
            throw new NotImplementedException();
        }


    }
}
