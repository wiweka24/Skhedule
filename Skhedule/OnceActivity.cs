using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skhedule
{
    class OnceActivity : Activity
    {
        public OnceActivity(string Name, string Type, string Desc) : base (Name, Type, Desc)
        {
            this.Name = Name;
            this.Type = Type;
            this.Desc = Desc;
        }
    }
}
