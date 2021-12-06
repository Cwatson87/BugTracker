﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace BugTracker.Models.ViewModels
{
    public class AddProjectWithPMViewModel
    {
        public Project Project { get; set; }

        public SelectList PMList { get; set; }

        public string PmId { get; set; }

        public SelectList Prority { get; set; }
    }
}