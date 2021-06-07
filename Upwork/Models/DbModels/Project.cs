﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Upwork.Models.DbModels;

namespace Upwork.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Requierments { get; set; }
        [Required]
        public int SimultaneousProjects { get; set; }

        [ForeignKey("Freelancer")]
        public string FreelancerId { get; set; }
        public Freelancer Freelancer { get; set; }

        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        public List<ProjectImages> Images { get; set; }
        public List<ProjectSteps> Steps { get; set; }
        public List<ProjectQuestion> Questions { get; set; }
        public List<ProjectLevel> Levels { get; set; }
        public List<ProjectTags> Tags  { get; set; }
        public List<ProjectSkills> Skills  { get; set; }
    }
}