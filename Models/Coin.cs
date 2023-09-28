using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp.Models
{
    public class Coin
    {
        public string Id { get; set; }              // Уникальный идентификатор монеты
        public int Rank { get; set; }              // Рейтинг монеты по рыночной капитализации
        public string Symbol { get; set; }         // Символ монеты (например, BTC)
        public string Name { get; set; }           // Название монеты
        public decimal Supply { get; set; }        // Доступное количество монет для торговли
        public decimal? MaxSupply { get; set; }     // Общее количество выпущенных монет
        public decimal MarketCapUsd { get; set; }  // Рыночная капитализация в USD (supply x price)
        public decimal VolumeUsd24Hr { get; set; } // Торговый объем в USD за последние 24 часа
        public decimal PriceUsd { get; set; }      // Цена в USD (взвешенная по объему торгов)
        public decimal ChangePercent24Hr { get; set; } // Изменение цены за последние 24 часа в процентах
        public decimal? Vwap24Hr { get; set; }       // Средняя цена по объему торгов за последние 24 часа
        
    }
}
