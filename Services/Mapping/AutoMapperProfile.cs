using AutoMapper;
using Dtos;
using Entities.Models;
using Entities.Models.View;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {

            CreateMap<Articulo, ArticuloDto>().ReverseMap();
                   CreateMap<Tienda, TiendaDto>().ReverseMap();
                   CreateMap<RelacionArticuloTienda, RelacionArticuloTiendaDto>().ReverseMap();
                   CreateMap<RelacionClienteArticulo, RelacionClienteArticuloDto>().ReverseMap();
        }
    }
}
