using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = ":( Sistem bakımda.";

        // Araba
        public static string CarAdded = "Araba eklendi.";
        public static string CarNameInvalid = "Araba adı geçersiz.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";

        //Customer
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomersDeleted = "Müşteri silindi.";
        public static string CustomersUpdated = "Müşteri güncellendi.";

        // Rental
        public static string AddedARentalCar = "Kiralık araçeklendi.";
        public static string RentalCarCannotBeAdded = "Kiralık araç eklenemez.";
        public static string RentalDeleted = "Kiralık araç kaldırıldı.";
        public static string RentalUpdated = "Kiralık araç güncellendi.";
        public static string RentalListed = "Araçlar listelendi.";

        // Brand
        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandDeleted = "Marka Silindi.";
        public static string BrandUpdated = "Marka Güncellendi.";
        public static string BrandListed = "Markalar Listelendi.";

        // Color
        public static string ColorAdded = "Renk Eklendi.";
        public static string ColorDeleted = "Renk Silindi.";
        public static string ColorUpdated = "Renk Güncellendi.";
        public static string ColorListed = "Renkler Listelendi.";

        // User
        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";
        public static string UserListed = "Kullanıcı Listelendi.";

    }
}
