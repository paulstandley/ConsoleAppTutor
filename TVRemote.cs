﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTutor
{
    class TVRemote
    {
        // Now we are modeling the action of
        // picking up the remote with our hand
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
