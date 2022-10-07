﻿using ElUniversidad.Application.Programs.Results;
using ElUniversidad.Domain.SeedWork;

namespace ElUniversidad.Application.Programs.Queries
{
    public record GetOfferQuery(Guid Id) : IQuery<OfferResult>;
}
