using System;
using System.Collections.Generic;
using System.Text;
using Presistencia;

namespace Dominio
{
    public class TarjetaServicio : ITarjetaServicio
    {
        private readonly ITarjetaRepositorio _tarjetaRepositorio;

        public TarjetaServicio(ITarjetaRepositorio tarjetaRepositorio)
        {
            _tarjetaRepositorio = tarjetaRepositorio;
        }

        public async Task<List<Tarjeta>> ObtenerTarjetasPorCategoriaAsync(string categoria)
        {
            return await _tarjetaRepositorio.ObtenerPorCategoriaAsync(categoria);
        }

        public async Task<List<Tarjeta>> ObtenerTodasLasTarjetasAsync()
        {
            return await _tarjetaRepositorio.ObtenerTodasAsync();
        }
    }
}
