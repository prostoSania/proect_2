using DurableTask.Core.Common;
using proect_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace proect_2.Core
{
    internal static class CoreConnection
    {
        public static Frame CoreFrame { get; set; }

        public static Entities1 DB { get; set; }
    }
}
