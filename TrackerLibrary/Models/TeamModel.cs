using System.Collections.Generic;

namespace ManagerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Уникальный идентификатор для приза.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название команды.
        /// </summary>
        public string TeamName { get; set; }
        
        /// <summary>
        /// Список участников данной команды.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
