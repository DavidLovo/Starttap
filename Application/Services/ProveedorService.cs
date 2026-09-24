using Application.Dtos;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ProveedorService
    {
        private readonly IProveedorRepository _repository;
        public ProveedorService(IProveedorRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProveedorDto>> ListarProveedor()
        {
            var olist = await _repository.LustarProveedorAsync();

            return olist.Select(p => new ProveedorDto
            {
                Id_Proveedor = p.Id_Proveedor,
                Codigo_Proveedor = p.Codigo_Proveedor,
                Nombre_Proveedor = p.Nombre_Proveedor,
                Telefono = p.Telefono,
                Direccion = p.Direccion,
                Identificacion = p.Identificacion,
                Correo = p.Correo,
                Estado = p.Estado,
                Fecha_Ingreso = p.Fecha_Ingreso,
            });           
            
        }

        public async Task NuevoProveedor(ProveedorDto oproveedorDto)
        {
            var oproveedor = new Proveedor
            {             
              
                Nombre_Proveedor = oproveedorDto.Nombre_Proveedor,
                Telefono = oproveedorDto.Telefono,
                Direccion = oproveedorDto.Direccion,
                Identificacion = oproveedorDto.Identificacion,
                Correo = oproveedorDto.Correo,
                Estado = oproveedorDto.Estado,
                Fecha_Ingreso = oproveedorDto.Fecha_Ingreso,
            };
            await _repository.NuevoproveedorAsync(oproveedor);
        }

        public async Task EditarProveedor(ProveedorDto oproveedorDto)
        {
            var oEsitar = new Proveedor
            {
                Id_Proveedor = oproveedorDto.Id_Proveedor,
                Nombre_Proveedor = oproveedorDto.Nombre_Proveedor,
                Telefono = oproveedorDto.Telefono,
                Direccion = oproveedorDto.Direccion,
                Identificacion = oproveedorDto.Identificacion,
                Correo = oproveedorDto.Correo,
                Estado = oproveedorDto.Estado,
            };
            await _repository.EditarproveedorAsync(oEsitar);
        }
    }
}
