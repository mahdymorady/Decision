﻿using System;
using Decision.DomainClasses.ApplicantInfo;

namespace Decision.DomainClasses.Evaluations
{
    public class EntireEvaluation : BaseEntity
    {
        #region Properties

        public string Content { get; set; }

        public DateTime EvaluationDate { get; set; }

        public string Foible { get; set; }

        public string StrongPoint { get; set; }

        #endregion

        #region NavigationProperties

        public Guid ApplicantId { get; set; }

        public Applicant Applicant { get; set; }

        #endregion
    }
}