using BestFindsApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFindsApi.Data
{
    public class PopulateData
    {
        public static void PopulateTableData(ModelBuilder builder)
        {
            builder.Entity<Category>()
                  .HasData(new
                  {
                      Id = 1,
                      Name = "Men's"
                  },
                  new
                  {
                      Id = 2,
                      Name = "Women's"
                  },
                  new
                  {
                      Id = 3,
                      Name = "Electronics"
                  },
                  new
                  {
                      Id = 4,
                      Name = "Outdoors"
                  }
                  );

            builder.Entity<Seller>()
            .HasData(new
            {
                Id = 1,
                Name = "Hepsiburada",
                WebSite = "www.hepsiburada.com"
            },
            new
            {
                Id = 2,
                Name = "Trendyol",
                WebSite = "www.trendyol.com"
            },
            new
            {
                Id = 3,
                Name = "Morhipo",
                WebSite = "www.morhipo.com"
            },
            new
            {
                Id = 4,
                Name = "ModaCruz",
                WebSite = "www.modacruz.com"
            }
            );

            builder.Entity<Product>()
            .HasData(new
            {
                Id = 1,
                SellerId = 1,
                CategoryId = 1,
                Name = "Koton Erkek Slim Pantolon",
                Price = 70.39m,
                Description = "Koton Erkek Slim Pantolon",
                URL = "https://www.hepsiburada.com/koton-erkek-slim-pantolon-p-HBV00000DI558",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 2,
                SellerId = 1,
                CategoryId = 1,
                Name = "Lc Waikiki Erkek Polo Yaka Tshirt",
                Price = 29.99m,
                Description = "Lc Waikiki Erkek Polo Yaka Tshirt",
                URL = "https://www.hepsiburada.com/lc-waikiki-erkek-polo-yaka-tshirt-p-HBV00000GR2VA",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 3,
                SellerId = 2,
                CategoryId = 2,
                Name = "Kadın Siyah Pantolon",
                Price = 164.50m,
                Description = "Kadın Siyah Pantolon IW6180003108 IW6180003108",
                URL = "https://www.trendyol.com/ipekyol/kadin-siyah-pantolon-iw6180003108-p-3603675?boutiqueId=309730&merchantId=968",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 4,
                SellerId = 2,
                CategoryId = 2,
                Name = "Kadın Bej Etek",
                Price = 420.00m,
                Description = "Kadın Bej Etek (18805)",
                URL = "https://www.trendyol.com/burberry/kadin-bej-etek-18805-p-3224783?boutiqueId=307783&merchantId=4421",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 5,
                SellerId = 3,
                CategoryId = 2,
                Name = "Jean Pantolon",
                Price = 149.90m,
                Description = "Jean Pantolon | Sophie - Skinny",
                URL = "https://www.morhipo.com/kampanya/detay/15359570/80621/tommy-hilfiger-jean-pantolon-sophie-skinny",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 6,
                SellerId = 3,
                CategoryId = 2,
                Name = "Ceket",
                Price = 904.90m,
                Description = "Ceket",
                URL = "https://www.morhipo.com/kampanya/detay/20712902/80613/emporio-armani-ss1600001979-ceket",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 7,
                SellerId = 1,
                CategoryId = 3,
                Name = "Samsung 40J5270 40\" 102 Ekran Uydu Alıcılı Full HD Smart LED TV",
                Price = 2191.50m,
                Description = "Samsung 40J5270 40\" 102 Ekran Uydu Alıcılı Full HD Smart LED TV",
                URL = "https://www.hepsiburada.com/samsung-40j5270-40-102-ekran-uydu-alicili-full-hd-smart-led-tv-p-EVTVSAM40J5270",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 8,
                SellerId = 3,
                CategoryId = 2,
                Name = "Nine West Çanta",
                Price = 459m,
                Description = "Nine West Çanta",
                URL = "https://www.morhipo.com/nine-west-canta/22312953/detay",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 9,
                SellerId = 1,
                CategoryId = 3,
                Name = "Huawei Mate 10 Lite",
                Price = 1799.90m,
                Description = "Huawei Mate 10 Lite (Huawei Türkiye Garantili)",
                URL = "https://www.hepsiburada.com/huawei-mate-10-lite-huawei-turkiye-garantili-p-HBV0000093BZC",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 10,
                SellerId = 1,
                CategoryId = 3,
                Name = "Huawei Watch GT Classic Akıllı Saat - Kahverengi",
                Price = 1299m,
                Description = "Huawei Watch GT Classic Akıllı Saat - Kahverengi",
                URL = "https://www.hepsiburada.com/huawei-watch-gt-classic-akilli-saat-kahverengi-p-HBV00000FSSWW",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 11,
                SellerId = 1,
                CategoryId = 4,
                Name = "Salcano Ng 650 27.5 Jant Hd Bisiklet 18 inç Kadro",
                Price = 1840m,
                Description = "Salcano Ng 650 27.5 Jant Hd Bisiklet 18 inç Kadro, Siyah - Kırmızı",
                URL = "https://www.hepsiburada.com/salcano-ng-650-27-5-jant-hd-bisiklet-18-inc-kadro-siyah-kirmizi-p-HBV00000BH262",
                CreateDate = new DateTime(2019, 03, 24)
            },
            new
            {
                Id = 12,
                SellerId = 1,
                CategoryId = 4,
                Name = "The North Face - Mountain 25 - 2 kişilik Çadır Sarı",
                Price = 3801.85m,
                Description = "The North Face - Mountain 25 - 2 kişilik Çadır Sarı",
                URL = "https://www.hepsiburada.com/the-north-face-mountain-25-2-kisilik-cadir-sari-p-HBV0000021PGK?magaza=NORADRENAL%C4%B0N",
                CreateDate = new DateTime(2019, 03, 24)
            }
            );
        }
    }

}
