using System.Collections.Generic;
using TrackerLibrary.Models;

namespace ManagerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Список участников данной команды.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        
        /// <summary>
        /// Название команды.
        /// </summary>
        public string TeamName { get; set; }
    }
}
