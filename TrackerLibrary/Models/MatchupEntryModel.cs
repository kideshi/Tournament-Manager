using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Представляет собой одну команду матчапа.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Представляет собой одну из команд, участвующую в матче.
        /// </summary>
        public TeamModel CompetingTeam { get; set; }
        
        /// <summary>
        /// Представляет собой счет команды.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Представляет собой предыдущий матч, откуда
        /// команда (CompetingTeam) вышла победителем.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
