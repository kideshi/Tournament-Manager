using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO: Сделать метод CreatePrize сохранять объект в БД.
        /// <summary>
        /// Сохраняет новый приз в базу данных.
        /// </summary>
        /// <param name="model">Модель приза с информацией о ней.</param>
        /// <returns>Обновленная информация о призе.
        /// </returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
