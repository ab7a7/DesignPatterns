﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var Single = DotNetLazySingleton.Instance;
        }
    }
}
