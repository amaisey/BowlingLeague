﻿using System;
using System.Collections.Generic;

namespace BowlingLeague.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Bowlers> Bowlers { get; set; }
        public PageNumberInfo PageNumberInfo { get; set; }
        public string TeamName { get; set; }
    }
}
