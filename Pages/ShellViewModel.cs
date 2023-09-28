using Stylet;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using CryptoApp.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Windows.Markup;

namespace CryptoApp.Pages
{
    public class ShellViewModel : Screen
    {
        private readonly string apiKey = "c859789e-6e55-4896-a0c6-566b1f62b4b6";
        private readonly HttpClient httpClient;

        public ObservableCollection<Coin> AllCoins { get; } = new ObservableCollection<Coin>();
        public ObservableCollection<CoinViewModel> Top10Coins { get; } = new ObservableCollection<CoinViewModel>();

        public ShellViewModel()
        {
            httpClient = new HttpClient();
        }

        protected override async void OnActivate()
        {
            base.OnActivate();

            await LoadAllCoins();
            UpdateTop10Coins();
            NotifyOfPropertyChange(() => Top10Coins);
        }

        private async Task LoadAllCoins()
        {
            string apiUrl = "https://api.coincap.io/v2/assets";
            try
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
             //   httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();

                    CoinData coinData = JsonConvert.DeserializeObject<CoinData>(jsonstring);
                    List<Coin> coins = coinData.Data;

                    if (coins != null)
                    {
                        foreach (Coin coin in coins)
                        {
                            AllCoins.Add(coin);
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                // Обработка исключений
            }
        }
        private void UpdateTop10Coins()
        {
            // Сортируйте монеты по рангу и выбирайте топ-10
            IEnumerable<Coin> topCoins = AllCoins.OrderBy(c => c.Rank).Take(10);

            // Очищайте и обновляйте коллекцию Top10Coins
            Top10Coins.Clear();
            foreach (Coin coin in topCoins)
            {
                CoinViewModel CoinView = new CoinViewModel
                {
                    Id = Convert.ToString(coin.Id),
                    Rank = "#" + Convert.ToString(coin.Rank),
                    Symbol = coin.Symbol,
                    Name = coin.Name,
                    MarketCapUsd = Convert.ToString(Math.Round(coin.MarketCapUsd)) + "$",
                    ChangePercent24Hr = (coin.ChangePercent24Hr >= 0 ? "+" : "-") + " " + Convert.ToString(Math.Abs(Math.Round(coin.ChangePercent24Hr * 100,3))) + '%',
                    PriceUsd = Convert.ToString(Math.Round(coin.PriceUsd,5)) + "$",
                    ImageUrl = $"https://coinicons-api.vercel.app/api/icon/{coin.Symbol.ToLower()}"
                };
                Top10Coins.Add(CoinView);
            }
        }
    }
}

