﻿using ElUniversidad.Domain.SeedWork;

namespace ElUniversidad.Domain.Programs
{
    public class Offer : Entity
    {
        public Offer() { }

        public Guid Id { get; private set; }
        public Guid ProgramId { get; private set; }
        public DateTime AvailableAt { get; private set; }

        public int AdmissionsQuota { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }

        public virtual Program Program { get; private set; }
    }
}