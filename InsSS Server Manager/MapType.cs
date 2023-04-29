using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsSS_Server_Manager
{
    public class MapType
    {
        public string mapName;
        public string scenarioName;
        public mapCat mapCategory;
        public List<ScenarioType> scenarioList;

        public enum mapCat
        {
            Official,
            Custom
        }

        public MapType()
        {
        }

        public MapType(string map, mapCat category, List<ScenarioType> scenarios, string scenario = null)
        {
            mapName = map;
            if (scenario == null)
                scenarioName = mapName;
            else
                scenarioName = scenario;
            mapCategory = category;
            scenarioList = scenarios;

        }

        public MapType(string map, mapCat category, string scenario)
        {
            mapName = map;
            mapCategory = category;
            scenarioName = scenario;
            scenarioList = new List<ScenarioType>();
            DefaultFill(scenarioName);

        }

        private void DefaultFill(string scenario)
        {
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Checkpoint_Security", ScenarioType.scenarioCat.Checkpoint_Security));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Checkpoint_Insurgents", ScenarioType.scenarioCat.Checkpoint_Insurgents));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_CheckpointHardcore_Security", ScenarioType.scenarioCat.Hardcore_CP_Security));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_CheckpointHardcore_Insurgents", ScenarioType.scenarioCat.Hardcore_CP_Insurgents));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Push_Security", ScenarioType.scenarioCat.Push_Security));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Push_Insurgents", ScenarioType.scenarioCat.Push_Insurgents));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Firefight_East", ScenarioType.scenarioCat.Firefight_East));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Firefight_West", ScenarioType.scenarioCat.Firefight_West));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Frontline", ScenarioType.scenarioCat.Frontline));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Skirmish", ScenarioType.scenarioCat.Skirmish));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Team_Deathmatch", ScenarioType.scenarioCat.Team_Deathmatch));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Outpost", ScenarioType.scenarioCat.Outpost));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Domination", ScenarioType.scenarioCat.Domination));
            scenarioList.Add(new ScenarioType("Scenario_" + scenario + "_Survival", ScenarioType.scenarioCat.Survival));
        }

        public void RemoveScenario(ScenarioType.scenarioCat scenarioCat)
        {
            int targetIndex = -1;

            for (int i = 0; i < scenarioList.Count; i++)
            {
                if (scenarioList[i].scenarioCategory == scenarioCat)
                    targetIndex = i;
            }
            scenarioList.RemoveAt(targetIndex);
        }

        public void SetScenario(ScenarioType.scenarioCat scenarioCat, string scenario)
        {
            foreach (ScenarioType type in scenarioList)
            {
                if (type.scenarioCategory == scenarioCat)
                    type.scenarioLine = scenario;
            }
        }
    }
}
