using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
   public class Horse:Animal
    {
        private string run;

        public string Run
        {
            get { return run; }
            set { run = value; }
        }
        
        public Horse(){ }

        public Horse(string nam, int wei, int ag):base(nam,wei,ag)
        {
            Run=run;
        }

      
        public override string State ()
        {
            return "how speed it run's:" + run;
        }
    }
}
