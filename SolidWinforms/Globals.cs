﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPractice;
using Microsoft.Practices.Unity;

namespace SolidWinforms
{
    public class Globals
    {
        public static readonly IList<IArea> iArea = new List<IArea>();
        public static readonly IUnityContainer container = new UnityContainer();
    }
}
