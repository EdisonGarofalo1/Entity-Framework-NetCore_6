using AutoMapper;
using EntityFrameworkNetCore_6.Models.Dto.CategoriaDto;
using EntityFrameworkNetCore_6.Models.Entity;

namespace EntityFrameworkNetCore_6.Utilidades
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {

            CreateMap<CategoriaDTO, Categoria>();

        }
        }
}
