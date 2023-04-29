using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsSS_Server_Manager
{
    public class ScenarioType
    {
        public string scenarioLine;
        public scenarioCat scenarioCategory;

        public enum scenarioCat
        {
            Checkpoint_Security,
            Checkpoint_Insurgents,
            Hardcore_CP_Security,
            Hardcore_CP_Insurgents,
            Push_Security,
            Push_Insurgents,
            Firefight_East,
            Firefight_West,
            Frontline,
            Skirmish,
            Team_Deathmatch,
            Outpost,
            Domination,
            Survival
        }

        public ScenarioType(string scenario, scenarioCat category)
        {
            scenarioLine = scenario;
            scenarioCategory = category;
        }
    }
}
