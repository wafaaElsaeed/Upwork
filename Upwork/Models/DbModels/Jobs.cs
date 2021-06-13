﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Upwork.Models.DbModels
{
    public class Jobs
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        [ForeignKey("subCategory")]
        public int? subCategoryId { get; set; }
        public SubCategory subCategory { get; set; }
        public string Scope { get; set; }
        public int? Duration { get; set; }
        public string LevelOfExperience { get; set; }
        public bool? TypeOfBudget { get; set; }

        public int? BudgetFrom { get; set; }
        public int? BudgetTo { get; set; }
        public string JobDescription { get; set; }
        public int? Language_ProficiencyId { get; set; }
        public Language_Proficiency Language_Proficiency { get; set; }
        public bool? TimeRequirement { get; set; }
        public bool? TalentType { get; set; }

        public DateTime CreateDate { get; set; }
        public List<JobsSkills> jobsSkills { get; set; }
    }
}