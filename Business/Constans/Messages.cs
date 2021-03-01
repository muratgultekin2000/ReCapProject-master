using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public class Messages
    {
        public static string CarDelete="Araba silinmiştir.";
        public static string CarAdded = "Araba eklenmiştir.";
        public static string MaintenanceTime = "Bakım zamanı.";
        public static string DailyPriceZero = "Fiyat 0 olamaz.";
        public static string CarsListted = "Arabalar listelendi.";
        public static string CarsNotBeFound = "Fiyat 0 olamaz.";
        public static string CarUpdated="Araba güncellendi.";
        public static string BradNotBeFaund="Marka Bulunamadı";
        public static string RentalBeNotFound="Kayıt bulunamadı";
        public static string RentalUpdated="Kayıt güncellendi";
        public static string RentalDelete="Kayıt silindi";
        public static string RentalAdded="Kayıt eklendi";
        public static string RentalNoAdded="Kayıt eklenemedi";
        internal static string UserNoAdded="Kullanıcı Eklenemedi";
        internal static string UserAdded="Kullanıcı eklendi";
        internal static string UserDelete="Kullanıcı silindi";
        internal static string UserListted="kullanıcılar listelendi";
        internal static string UserUpdated="kullanıcı güncellendi";
        internal static object CustomerListed="Müşteriler listelendi";
        public static object ImageAdded="Resim Eklendi.";
        public static string ImageDeleted="Resim silindi.";
        internal static string ImageUpdated="Resim güncellendi.";
        internal static string FiveNumberOfPictures="Bir arabaya 5 den fazla resim yüklenemez.";
        internal static string CarImageNoAdd = "Resim bilgileri eklenemedi";
        internal static string CarImageAdd="REsim bilgileri eklendi.";
        public static string AuthorizationDenied = "yetkin yok";
        internal static string UserRegistered="kayıt yapıldı";
        internal static string PasswordError = "Parola hatalı.";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string SuccessfulLogin = "Başarılı giriş";
        internal static string UserAlreadyExists = "bu kullanıcı var.";
        internal static string AccessTokenCreated="token oluşturuldu.";
    }
}
