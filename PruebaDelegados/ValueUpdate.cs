using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDelegados
{
    public delegate void Delegado(object sender, ValueUpdate e);
    public class ValueUpdate
    {
        public string newValue;
        public ValueUpdate(string newValue)
        {
            this.newValue = newValue;
        }

        public string NewValue
        {
            get
            {
                return newValue;
            }
        }
    }
}
