using System.Collections.Generic;

namespace PulsarTestTask.Models
{
    public class ShopContent
    {
        private List<ShopItem> _items;

        public ShopContent()
        {
            _items = CreateContent();
        }

        private List<ShopItem> CreateContent()
        {
            return
            [
                new ()
                {
                    Name = "Бананы",
                    Count = 10,
                    Url = "http://organicmarket.ru/files/images/product/large_image/0/3399/banani-spelie_6333fc8346a4d.jpeg"
                },
                new ()
                {
                    Name = "Яблоки",
                    Count = 20,
                    Url = "https://eda.show/content/images/2022/09/scale_1200--9--7.jpg"
                },
                new ()
                {
                    Name = "Груши",
                    Count = 30,
                    Url = "https://images.thesymbol.ru/upload/img_cache/93f/93f6cb03d210477b4a82ba2617e6fbd4_cropped_510x378.webp"
                },
                new()
                {
                    Name = "Помидоры",
                    Count = 40,
                    Url = "https://s1.1zoom.ru/big0/359/Tomatoes_Wicker_basket_497082.jpg"
                }
            ];
        }

        public List<ShopItem> GetContent()
        {
            return _items;
        }
    }
}
