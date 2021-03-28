using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted="Araba silindi.";
        public static string CarUpdated="Araba güncellendi.";
        public static string CarsListedByBrand="Arabalar markaya göre listelendi.";
        public static string CarsListedByColor="Arabalar renklere göre listelendi.";
        public static string CarsListedByDailyPrice="Arabalar günlük fiyatlarına göre listelendi.";

        public static string DailyPriceInvalid = "Günlük fiyat 0'dan büyük olmalıdır";
        public static string MaintenanceTime = "Bakım zamanı";
       
        public static string BrandsListed= "Markalar listelendi.";
        public static string BrandsListedById = "Markalar Id'ye göre listelendi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted= "Marka silindi.";
        public static string BrandUpdated= "Marka güncellendi.";


        public static string ColorsListedById= "Renkler ID'ye göre listelendi.";
        public static string ColorsListed="Renkler listelendi";
        public static string ColorAdded="Renk eklendi.";
        public static string ColorDeleted="Renk silindi";
        public static string ColorUpdated="Renk güncellendi";

        public static string CustomerIdAlreadyExists="Müşteri zaten kayıtlı!";
        public static string CustomerAdded="Müşteri eklendi.";
        public static string RentalNotAvailable="Araç kiralanmaya uygun değil.";
        public static string RentalAdded="Kiralama eklendi.";
    }
}
