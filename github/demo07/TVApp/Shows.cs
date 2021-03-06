﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApp
{
    [Serializable]
    class Shows
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public double Start { get; set; }
        public double End { get; set; }
        public string Info { get; set; }

        public Shows()
        { 
        }

        public override string ToString()
        {
            return Name + " " + Channel + " " + Start + " " + End + " " + Info;
        }


    }
}
