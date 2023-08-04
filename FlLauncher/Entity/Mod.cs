using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlLauncher.Entity
{
    public partial class Mod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string InstallUri { get; set; }
        public virtual ModPack ModPack { get; set; }
    }
}
