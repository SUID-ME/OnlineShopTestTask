using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace PulsarTestTask.Converters
{
    public class BitmapLoader<T> where T : IUrl
    {
        public void LoadBitmap(T item)
        {
            _ = FormBitmap(item);
        }

        public void LoadBitmaps(List<T> items)
        {
            if (items == null || items.Count == 0)
            {
                return;
            }

            foreach (var item in items)
            {
                if (item.Bitmap != null || string.IsNullOrEmpty(item.Url) == true)
                {
                    continue;
                }

                _ = FormBitmap(item);
            }
        }

        private async Task FormBitmap(IUrl item)
        {
            try
            {
                var bitmap = await LoadImageFromUrl(item.Url);
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
    }
}
