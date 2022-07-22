using System.Collections.Generic;

namespace ManagerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Название турнира.
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// Вступительный взнос.
        /// </summary>
        public decimal EntryFee { get; set; }
        
        /// <summary>
        /// Записанные на участие в турнире команды.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        
        /// <summary>
        /// Список призов.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Представляет собой список раундов, каждый
        /// из которых является совокупностью матчей.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
