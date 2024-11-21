using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Brand

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string MaintenanceTime = "Sistem bakımda.";


        //Car

        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string CarDetailsListed = "Araba detayları listelendi.";
        public static string CarByBrandListed = "Markalara göre arabalar listelendi.";
        public static string CarByColorListed = "Renklere göre arabalar listelendi.";

        //Color

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorsListed = "Renkler listelendi.";

        //Customer

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";

        //Rental

        public static string RentalAdded = "Kiralama eklendi.";
        public static string RentalDeleted = "Kiralama silindi.";
        public static string RentalUpdated = "Kiralama güncellendi.";
        public static string RentalsListed = "Kiralamalar listelendi.";

        //User

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";

        //CarImage

        public static string CarImageAdded = "Araba resmi eklendi.";
        public static string CarImageDeleted = "Araba resmi silindi.";
        public static string CarImageUpdated = "Araba resmi güncellendi.";
        public static string CarImageListed = "Araba resmi listelendi.";
        public static string CarImageLimit = "Maksimum araba resmi sayısını ulaşıldı.";

        //Authorization

        public static string AuthorizationDenied = "Marka ekleme yetkiniz bulunmamaktadır.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserFound = "Kullanıcı bulundu.";
        public static string UserRegistered = "Kayıt olundu.";
        public static string PasswordError = "Hatalı şifre.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Access Token oluşturuldu.";
        public static string ClaimsListed = "Claimlar listelendi.";
    }
}