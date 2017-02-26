﻿using System.Data.Entity.ModelConfiguration;
using Decision.DomainClasses.Applicants;

namespace Decision.DataLayer.Mappings.Applicants
{
    public class EducationalBackgroundMap : TrackableEntityMap<EducationalBackground, long>
    {
        public EducationalBackgroundMap()
        {

            Property(e => e.Description).IsMaxLength().IsOptional();
            Property(e => e.Supervisor).HasMaxLength(50).IsOptional();
            Property(e => e.Advisor).HasMaxLength(50).IsOptional();
            Property(e => e.ThesisTopic).IsMaxLength().IsRequired();
            
            Property(e => e.GPA).IsRequired().HasPrecision(7, 2);
            Property(e => e.ThesisScore).IsRequired().HasPrecision(7, 2);
        }
    }
}