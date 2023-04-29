using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsSS_Server_Manager
{
    public class MutatorType
    {
        public string mutatorName { get; set; }
        public string mutatorDescription { get; set; }
        public bool enabled { get; set; }

        public enum mutatorCat
        {
            Official,
            Custom
        }

        public mutatorCat category { get; set; }

        public MutatorType(string mutator, string mutatorDesc, mutatorCat mutatorCategory)
        {
            mutatorName = mutator;
            mutatorDescription = mutatorDesc;
            enabled = false;
            category = mutatorCategory;
        }
    }
}
