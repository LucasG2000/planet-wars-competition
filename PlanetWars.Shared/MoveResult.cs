﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetWars.Shared
{
    public class MoveResult : BaseResult<MoveResult>
    {
        public Fleet Fleet { get; set; }
    }
}
