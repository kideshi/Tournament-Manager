using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Уникальный идентификатор для приза.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Занятое в турнире место.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// "Название" занятого в турнире места.
        /// </summary>
        public string PlaceName { get; set; }
        
        /// <summary>
        /// Призовые.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        
        /// <summary>
        /// Процент призовых от вступительного взноса.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
