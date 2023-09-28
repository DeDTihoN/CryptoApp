using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models
{

    // Класс для отображения данных в таблице
    public class CoinViewModel
    {
        public string Id { get; set; }              // Уникальный идентификатор монеты
        public string Rank { get; set; }              // Рейтинг монеты по рыночной капитализации
        public string Symbol { get; set; }         // Символ монеты (например, BTC)
        public string Name { get; set; }           // Название монеты
        public string MarketCapUsd { get; set; }  // Рыночная капитализация в USD (supply x price)
        public string ChangePercent24Hr { get; set; } // Изменение цены за последние 24 часа в процентах
        public string PriceUsd { get; set; }      // Цена в USD (взвешенная по объему торгов)
        public string ImageUrl { get; set;} // Ссылка на изображение монеты

    }
}
