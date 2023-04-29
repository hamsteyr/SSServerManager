using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsSS_Server_Manager
{
    public class ModType
    {
        public int modID;
        public string modDesc;
        public MutatorType[] mutators;
        public MapType[] maps;

        public bool enabled;

        /* mutator type constructor */
        public ModType(int id, string desc, MutatorType[] mutatorList = null, MapType[] mapList = null, bool bEnabled = false)
        {
            modID = id;
            modDesc = desc;
            mutators = mutatorList;
            maps = mapList;
            enabled = bEnabled;
        }
    }
}
