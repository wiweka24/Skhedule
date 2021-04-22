using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skhedule
{
    class Activity
    {
        //Instance
        private string actName;
        private string actDesc;
        private DateTime actDL;
        private string actType;

        //Property
        public string Name
        {
            get { return actName; }
            set { actName = value; }
        }

        public string Desc
        {
            get { return actDesc; }
            set { actDesc = value; }
        }

        public DateTime DL
        {
            get { return actDL; }
            set { actDL = value; }
        }

        public string Type
        {
            get { return actType; }
            set { actType = value; }
        }
    }
}
