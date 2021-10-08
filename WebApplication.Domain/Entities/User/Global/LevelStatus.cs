﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Enums;

namespace WebApplication.Domain.Entities.User.Global
{
    public class LevelStatus
    {
        public URole Level { get; set; }
        public DateTime SessionTime { get; set; }
    }
}
