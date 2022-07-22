using System.Collections.Generic;

namespace ManagerLibrary.Models
{
    /// <summary>
    /// Представляет собой один матч турнира.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Представляет собой набор команд, участвующих в матче.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        
        /// <summary>
        /// Победитель матча.
        /// </summary>
        public TeamModel Winner { get; set; }
        
        /// <summary>
        /// Номер раунда текущего матча.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
