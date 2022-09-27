﻿using AutoMapper;
using ElUniversidad.Application.Programs.Queries;
using ElUniversidad.Application.Programs.Results;
using ElUniversidad.Domain.Programs;
using ElUniversidad.Domain.SeedWork;
using ElUniversidad.Infrastructure.Data.Contexts;
using EntityFrameworkCore.UnitOfWork.Interfaces;

namespace ElUniversidad.Application.Programs.QueryHandlers
{
    public class GetProgramsQueryCommandHandler : IQueryHandler<GetProgramsQueryCommand, ProgramsResult>, IDisposable
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProgramsQueryCommandHandler(
            IUnitOfWork<ElUniversidadContext> unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ProgramsResult> Handle(GetProgramsQueryCommand request, CancellationToken cancellationToken)
        {
            var repo = _unitOfWork.Repository<Program>();

            var query = repo.MultipleResultQuery();

            var programs = await repo.SearchAsync(query, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);

            var programsResult = _mapper.Map<ProgramsResult>(programs);

            return programsResult;
        }

        #region IDisposable Members

        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _unitOfWork?.Dispose();
                }
            }

            _disposed = true;
        }

        #endregion IDisposable Members
    }
}
