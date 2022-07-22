
namespace ManagerLibrary.Models
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
        /// Призовые, которые команда получает за полученное место. Равно нулю, если
        /// данное свойство не используется.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        
        /// <summary>
        /// Процент призовых от вступительного взноса в виде десятичного числа.
        /// Равно нулю, если данное свойство не используется.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;
            
            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
