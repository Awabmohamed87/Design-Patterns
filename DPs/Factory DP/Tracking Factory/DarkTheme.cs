﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Tracking_Factory
{
    internal class DarkTheme : ITheme
    {
        public string TextColor => "White";

        public string BackgroundColor => "Black";
    }
}
