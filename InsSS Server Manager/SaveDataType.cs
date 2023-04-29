using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsSS_Server_Manager
{
    public class SaveDataType
    {
        public struct stringDataStruct
        {
            public string serverDir;
            public string GLST;
            public string GameStat;
            public string password;
        }

        public stringDataStruct stringData;
        public MutatorType[] mutatorList;
        public ModType[] modList;
        public MapType[] mapList;

        public SaveDataType()
        {
            stringData = new stringDataStruct
            {
                serverDir = "",
                GLST = "",
                GameStat = "",
                password = ""
            };

            mutatorList = null;
            modList = null;
            mapList = null;
        }

        public SaveDataType (stringDataStruct dataStruct, MutatorType[] mutators, ModType[] mods, MapType[] maps)
        {
            stringData = dataStruct;
            mutatorList = mutators;
            modList = mods;
            mapList = maps;
        }
    }
}
