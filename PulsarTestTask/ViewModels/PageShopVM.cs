using Avalonia.Media.Imaging;
using DynamicData;
using PulsarTestTask.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace PulsarTestTask.ViewModels
{
    public class PageShopVM : ViewModelBase
    {
        public PageShopVM()
        {
            ShopItems.AddRange(App.ShopContent.GetContent());
            LoadBitmaps();
        }

        public ObservableCollection<ShopItem> ShopItems { get; } = [];

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

        public async Task<Bitmap?> LoadImageFromUrl(string url)
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
                return null; // или вернуть заглушку
            }
        }
    }
}
