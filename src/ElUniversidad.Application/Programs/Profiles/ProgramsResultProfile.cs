﻿using AutoMapper;
using ElUniversidad.Application.Programs.Results;
using ElUniversidad.Domain.Programs;

namespace ElUniversidad.Application.Programs.Profiles
{
    public class ProgramsResultProfile : Profile
    {
        public ProgramsResultProfile()
        {
            CreateMap<Program, ProgramResult>()
                .ForMember(dest => dest.Code, opts => opts.MapFrom(src => src.Code))
                .ForMember(dest => dest.Title, opts => opts.MapFrom(src => src.Title));

            CreateMap<IEnumerable<ProgramResult>, ProgramsResult>()
                .ForMember(dest => dest.Programs, c => c.MapFrom(src => src));
        }
    }
}