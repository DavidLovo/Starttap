using Application.Interfaces;
using Domain.Entities;
using InfraStruture.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace InfraStruture.Repository
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly DBConectionFactory _dBConectionFactory;
        public ProveedorRepository(DBConectionFactory dBConectionFactory)
        {
            _dBConectionFactory = dBConectionFactory;
        }
        public async Task<IEnumerable<Proveedor>> LustarProveedorAsync()
        {
            using var conexion = _dBConectionFactory.CreateConnection();
            await conexion.OpenAsync();

            var olis = new List<Proveedor>();
            using var cmd = new SqlCommand("ListarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            using var dr = await cmd.ExecuteReaderAsync();

            while (await dr.ReadAsync())
            {              

                olis.Add(new Proveedor
                {
                    Id_Proveedor = Convert.ToInt32(dr["id_Proveedor"]),
                    Codigo_Proveedor = dr["Codigo_Proveedor"].ToString(),
                    Nombre_Proveedor = dr["Nombre_Proveedor"].ToString(),
                    Telefono = dr["Telefono"].ToString(),
                    Direccion = dr["Direccion"].ToString(),
                    Identificacion = dr["Identificacion"].ToString(),
                    Correo = dr["Correo"].ToString(),
                    Estado = dr["Estado"].ToString(),
                    Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"])
                });
              
            }
            return olis;
        }

        public async Task NuevoproveedorAsync(Proveedor oproveedor)
        {
            using var conexion = _dBConectionFactory.CreateConnection();
            await conexion.OpenAsync();

            using var cmd = new SqlCommand("AgregarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Nombre_Proveedor", oproveedor.Nombre_Proveedor));
            cmd.Parameters.Add(new SqlParameter("@Telefono", oproveedor.Telefono));
            cmd.Parameters.Add(new SqlParameter("@Direccion", oproveedor.Direccion));
            cmd.Parameters.Add(new SqlParameter("@Identificacion", oproveedor.Identificacion));
            cmd.Parameters.Add(new SqlParameter("@Correo", oproveedor.Correo));
            cmd.Parameters.Add(new SqlParameter("@Estado", oproveedor.Estado));
            cmd.Parameters.Add(new SqlParameter("@Fecha_Ingreso", oproveedor.Fecha_Ingreso));

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task EditarproveedorAsync(Proveedor oproveedor)
        {
            using var conexion = _dBConectionFactory.CreateConnection();
            await conexion.OpenAsync();

            using var cmd = new SqlCommand("EditarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id_Proveedor", oproveedor.Id_Proveedor));
            cmd.Parameters.Add(new SqlParameter("@Nombre_Proveedor", oproveedor.Nombre_Proveedor));
            cmd.Parameters.Add(new SqlParameter("@Telefono", oproveedor.Telefono));
            cmd.Parameters.Add(new SqlParameter("@Direccion", oproveedor.Direccion));
            cmd.Parameters.Add(new SqlParameter("@Identificacion", oproveedor.Identificacion));
            cmd.Parameters.Add(new SqlParameter("@Correo", oproveedor.Correo));
            cmd.Parameters.Add(new SqlParameter("@Estado", oproveedor.Estado));

            await cmd.ExecuteNonQueryAsync();
        }

        public Task EliminarproveedorLogicoAsync(Proveedor oproveedor)
        {
            throw new NotImplementedException();
        }


    }
}
