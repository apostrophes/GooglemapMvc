﻿using System;
using System.Collections.Generic;

namespace Jmelosegui.Mvc.Googlemap.Examples.App_Data
{
    public class RegionInfo
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Title { get; set; }
        public int zIndex { get; set; }
        public string ImagePath { get; set; }
        public string InfoWindowContent { get; set; }
        public double population { get; set; }
        public string Address
        {
            get { return Title + ", Spain"; }
        }
    }

    public class DataContext
    {
        public static IEnumerable<RegionInfo> GetRegions()
        {
            return new List<RegionInfo>
                       {
                           new RegionInfo
                               {
                                   Longitude = -4.57595074388866,
                                   Latitude = 37.4627044984297,
                                   Title = "Andalucia",
                                   zIndex = 15,
                                   ImagePath = "Andalucia.jpg",
                                   InfoWindowContent = @"<h2>Andalucia</h2>",
                                   population = 8370975
                               },
                           new RegionInfo
                               {
                                   Longitude = -0.660086412088428,
                                   Latitude = 41.5197712294221,
                                   Title = "Aragón",
                                   zIndex = 2,
                                   ImagePath = "Aragon.jpg",
                                   InfoWindowContent = @"<h2>Aragón</h2>",
                                   population = 1277471
                               },
                               new RegionInfo
                               {
                                   Longitude =-5.99303425068051,
                                   Latitude =  43.2926485100667,
                                   Title = "Asturias",
                                   zIndex = 4,
                                   ImagePath = "Asturias.jpg",
                                   InfoWindowContent = @"<h2>Asturias</h2>",
                                   population = 1076896
                               },
                               new RegionInfo
                               {
                                   Longitude =-4.02842943995642,
                                   Latitude =  43.1985460400007,
                                   Title = "Cantabria",
                                   zIndex = 5,
                                   ImagePath = "Cantabria.jpg",
                                   InfoWindowContent = @"<h2>Cantabria</h2>",
                                   population = 591886
                               },
                               new RegionInfo
                               {
                                   Longitude =-4.78304592487708,
                                   Latitude =  41.7558243397703,
                                   Title = "Castilla y León",
                                   zIndex = 6,
                                   ImagePath = "CastillayLeon.jpg",
                                   InfoWindowContent = @"<h2>Castilla y León</h2>",
                                   population = 2510849
                               },
                               new RegionInfo
                               {
                                   Longitude =-3.00561142377074,
                                   Latitude =  39.5823898383649,
                                   Title = "Castilla La Mancha",
                                   zIndex = 7,
                                   ImagePath = "CastillaLaMancha.jpg",
                                   InfoWindowContent = @"<h2>Castilla La Mancha</h2>",
                                   population = 2095855
                               },
                               new RegionInfo
                               {
                                   Longitude = 1.52942440762057,
                                   Latitude =  41.7984066910626,
                                   Title = "Cataluña",
                                   zIndex = 8,
                                   ImagePath = "Cataluña.jpg",
                                   InfoWindowContent = @"<h2>Cataluña</h2>",
                                   population = 7535251
                               },
                               new RegionInfo
                               {
                                   Longitude = -0.553479226106214,
                                   Latitude =  39.402980001699,
                                   Title = "Comunidad Valenciana",
                                   zIndex = 9,
                                   ImagePath = "ComunidadValenciana.jpg",
                                   InfoWindowContent = @"<h2>Comunidad Valenciana</h2>",
                                   population = 5111706
                               },
                               new RegionInfo
                               {
                                   Longitude = -6.14989834853003,
                                   Latitude =  39.1910300444204,
                                   Title = "Extremadura",
                                   zIndex = 10,
                                   ImagePath = "Extremadura.jpg",
                                   InfoWindowContent = @"<h2>Extremadura</h2>",
                                   population = 1097744
                               },
                               new RegionInfo
                               {
                                   Longitude = -7.91067418759005,
                                   Latitude =  42.7573334990542,
                                   Title = "Galicia",
                                   zIndex = 11,
                                   ImagePath = "Galicia.jpg",
                                   InfoWindowContent = @"<h2>Galicia</h2>",
                                   population = 2796089
                               },
                               new RegionInfo
                               {
                                   Longitude = 2.91228480711994,
                                   Latitude =  39.5743872767774,
                                   Title = "Islas Baleares",
                                   zIndex = 12,
                                   ImagePath = "baleares.jpg",
                                   InfoWindowContent = @"<h2>Islas Baleares</h2>",
                                   population = 1106049
                               },
                               new RegionInfo
                               {
                                   Longitude = -15.6695166804329,
                                   Latitude =  28.3414539671822,
                                   Title = "Islas Canarias",
                                   zIndex = 13,
                                   ImagePath = "Canarias.jpg",
                                   InfoWindowContent = @"<h2>Islas Canarias</h2>",
                                   population = 2098593
                               },
                               new RegionInfo
                               {
                                   Longitude = -2.51709503790131,
                                   Latitude =  42.2744050690317,
                                   Title = "La Rioja",
                                   zIndex = 14,
                                   ImagePath = "LaRioja.jpg",
                                   InfoWindowContent = @"<h2>La Rioja</h2>",
                                   population = 308968
                               },
                               new RegionInfo
                               {
                                   Longitude = -3.71723975865936,
                                   Latitude =  40.4943292450304, 
                                   Title = "Madrid",
                                   zIndex = 1,
                                   ImagePath = "Madrid.jpg",
                                   InfoWindowContent = @"<h2>Madrid</h2>",
                                   population = 6445499
                               },
                               new RegionInfo
                               {
                                   Longitude = -1.48298815055981,
                                   Latitude =  38.0016088590782, 
                                   Title = "Murcia",
                                   zIndex = 15,
                                   ImagePath = "Murcia.jpg",
                                   InfoWindowContent = @"<h2>Murcia</h2>",
                                   population = 1424063
                               },
                               new RegionInfo
                               {
                                   Longitude = -1.64758357483914,
                                   Latitude =  42.6673876299784,  
                                   Title = "Navarra",
                                   zIndex = 14,
                                   ImagePath = "Navarra.jpg",
                                   InfoWindowContent = @"<h2>Navarra</h2>",
                                   population = 620337
                               },
                               new RegionInfo
                               {
                                   Longitude = -2.61621650797752,
                                   Latitude =  43.0434435645489,  
                                   Title = "País Vasco",
                                   zIndex = 14,
                                   ImagePath = "PaisVasco.jpg",
                                   InfoWindowContent = @"<h2>País Vasco</h2>",
                                   population = 2155546
                               }
                       };
        }
        public static IEnumerable<RegionInfo> GetHugeAmountOfMarkers()
        {
            var result = new List<RegionInfo>();
            var random = new Random();
            foreach (var region in GetRegions())
            {
                var regionMarkers = random.Next(50, 1500);

                var latData = new RealDataEmulator(region.Latitude - 0.5d, region.Latitude + 0.5d, region.Latitude);
                var lngData = new RealDataEmulator(region.Longitude - 0.5d, region.Longitude + 0.5d, region.Longitude);

                var lat = 0d;
                var lng = 0D;
                for (int i = 0; i < regionMarkers; i++)
                {
                    if (i == 0)
                    {
                        lat = region.Latitude;
                        lng = region.Longitude;
                    }
                    else if (i % 2 == 0)
                    {
                        lat = latData.GetNextValue();
                    }
                    else
                    {
                        lng = lngData.GetNextValue();
                    }


                    result.Add(new RegionInfo { Latitude = lat, Longitude = lng });
                }
            }
            return result;
        }
    }
}
