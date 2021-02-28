using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string ProductsListed = "Urunler listelendi";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductCountOfcategoryError = "Bir kategoride en fazla 10 urun olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten baska bir urun var";
        public static string CategoryLimitExceded = "Kategori limiti asildigi icin yeni urun eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

    }
}
