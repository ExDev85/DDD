﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanResource.Domain.Repositories;
using HumanResource.Domain.Entities;
using HumanResource.Domain.Specifications;
using HumanResource.Domain.ValueObjects;

namespace HumanResource.Infrastructure
{
    public class JobApplicationFileRepository : IJobApplicationRepository
    {
        public void Save(JobApplication jobApplication)
        {
            Console.Write("Using {0} to save\n", this.GetType().ToString());
        }

        public IList<JobApplication> Find(ISpecification spec)
        {
            Console.Write("Using {0} to find unhandled job applications\n", this.GetType().ToString());
            spec.ToString();
            return new List<JobApplication>();
        }

        public void Delete(JobApplication jobApplication)
        {
            Console.Write("Using {0} to delete\n", this.GetType().ToString());
        }

        public void Delete(IList<JobApplication> jobApplications)
        {
            Console.Write("Using {0} to delete\n", this.GetType().ToString());
        }

        #region IJobApplicationRepository Members


        public JobApplication Find(JobApplicationKey key)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
