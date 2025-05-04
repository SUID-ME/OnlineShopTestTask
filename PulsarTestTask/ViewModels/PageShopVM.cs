using Avalonia.Media.Imaging;
using DynamicData;
using PulsarTestTask.Models;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reactive;
using System.Threading.Tasks;

namespace PulsarTestTask.ViewModels
{
    public class PageShopVM : ViewModelBase
    {
        #region Constructor
        public PageShopVM()
        {
            BuyCommand = ReactiveCommand.Create<ShopItem>(BuyLogic);

            ShopItems.AddRange(App.ShopContent.GetContent());
            LoadBitmaps();
        }
        #endregion Constructor

        #region Bindings
        public ObservableCollection<ShopItem> ShopItems { get; } = [];

        public ReactiveCommand<ShopItem, Unit> BuyCommand { get; set; }
        #endregion Bindings

        #region Methods
        public void BuyLogic(ShopItem item)
        {
            CartContent? content = App.CartList.FirstOrDefault(x => x.Name == item.Name);
            if (content != null)
            {
                content.Count++;
            }
            else
            {
                content = new CartContent(item);
                App.CartList.Add(content);
            }

        }

        private void LoadBitmaps()
        {
            foreach (var item in ShopItems)
            {
                if (item.Bitmap != null || string.IsNullOrEmpty(item.URL) == true)
                {
                    continue;
                }

                _ = FormBitmapLogic(item);
            }
        }

        private async Task FormBitmapLogic(ShopItem item)
        {
            try
            {
                var bitmap = await LoadImageFromUrl(item.URL);
                if (bitmap != null)
                {
                    item.Bitmap = bitmap;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return;
            }
        }

        private async Task<Bitmap?> LoadImageFromUrl(string url)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    // Добавляем User-Agent чтобы сервер не блокировал запрос
                    httpClient.DefaultRequestHeaders.Add("User-Agent", "AvaloniaUI App");

                    var response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    await using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        return new Bitmap(stream);
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        #endregion Methods
    }
}
