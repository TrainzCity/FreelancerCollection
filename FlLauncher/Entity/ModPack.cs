using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlLauncher.Entity
{
    public partial class ModPack
    {
        public ModPack()
        {
            this.Mod = new HashSet<Mod>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Mod> Mod { get; set; }

    }
}
