﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBox
{
    public interface ITrayController
    {
        void ShowBalloonTip(string title, string msg);
    }
}
