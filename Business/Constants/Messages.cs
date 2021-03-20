using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Entities.DTOs;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AddedOK = "Eklendi";
        public static string UpdatedOK = "Güncellendi";
        public static string DeletedOK = "Silindi";
        public static string ListedOK = "Listelendi";

        public static string AddedErr = "Eklenemedi";
        public static string UpdatedErr = "Güncellenemedi";
        public static string DeletedErr = "Silinemedi";
        public static string ListedErr = "Listelenemedi";

        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarImageLimitExceeded="Bir Arababa için maksimum 5 resim ekleyebilirsiniz.";
        
        

        //Car
        public static string AddCarMessage = "Araç başarıyla eklendi.";

        public static string AddErrorCarMessage = "Araba açıklaması en az 2 karakterden oluşmalıdır ve günlük fiyatı da 0 liradan büyük olmalıdır.";
        public static string DeleteCarMessage = "Araç başarıyla silindi.";
        public static string EditCarMessage = "Araç başarıyla düzenlendi.";
        public static string GetSuccessCarMessage = "Araç bilgisi / bilgileri getirildi.";
        public static string GetErrorCarMessage = "Araç bilgisi / bilgileri getirilemedi.";
        public static string ErrorCarFKMessage = "Renk ve Marka alanlarını tekrar kontrol ediniz..";

        //Brand
        public static string AddBrandMessage = "Marka başarıyla eklendi.";

        public static string DeleteBrandMessage = "Marka başarıyla silindi.";
        public static string EditBrandMessage = "Marka başarıyla güncellendi.";
        public static string GetSuccessBrandMessage = "Marka bilgisi / bilgileri getirildi.";
        public static string GetErrorBrandMessage = "Marka bilgisi / bilgileri getirilemedi.";

        //Color
        public static string AddColorMessage = "Renk başarıyla eklendi.";

        public static string DeleteColorMessage = "Renk başarıyla silindi.";
        public static string EditColorMessage = "Renk başarıyla güncellendi.";
        public static string GetSuccessColorMessage = "Renk bilgisi / bilgileri getirildi.";
        public static string GetErrorColorMessage = "Renk bilgisi / bilgileri getirilemedi.";

        //Customer
        public static string AddCustomerMessage = "Müşteri başarıyla eklendi.";

        public static string DeleteCustomerMessage = "Müşteri başarıyla silindi.";
        public static string EditCustomerMessage = "Müşteri başarıyla güncellendi.";
        public static string GetSuccessCustomerMessage = "Müşteri bilgisi / bilgileri getirildi.";
        public static string GetErrorCustomerMessage = "Müşteri bilgisi / bilgileri getirilemedi.";
        public static string ErrorCustomerFKMessage = "Kullanıcı alanını tekrar kontrol ediniz..";

        //Rental
        public static string AddRentalMessage = "Araç kiralama işlemi başarıyla eklendi.";

        public static string DeleteRentalMessage = "Araç kiralama işlemi başarıyla silindi.";
        public static string EditRentalMessage = "Araç kiralama işlemi başarıyla güncellendi.";
        public static string GetSuccessRentalMessage = "Araç kiralama işlemi bilgisi / bilgileri getirildi.";
        public static string GetErrorRentalMessage = "Araç kiralama işlemi bilgisi / bilgileri getirilemedi.";
        public static string CarAvaible = "Araç kiralanmaya uygundur.";
        public static string CarNotAvaible = "Araç kiralanmaya uygun değildir.";
        public static string CarNotDeliverTheCar = "Araç teslim almaya uygun değildir.";
        public static string CarDeliverTheCar = "Araç teslim alındı.";
        public static string ErrorRentalFKMessage = "Müşteri ve araba alanlarını tekrar kontrol ediniz..";

        //User
        public static string AddUserMessage = "Üye başarıyla eklendi.";

        public static string DeleteUserMessage = "Üye başarıyla silindi.";
        public static string EditUserMessage = "Üye başarıyla güncellendi.";
        public static string GetSuccessUserMessage = "Üye bilgisi / bilgileri getirildi.";
        public static string GetErrorUserMessage = "Üye bilgisi / bilgileri getirilemedi.";

        //CarImage

        public static string AddCarImageMessage = "Araç resmi başarıyla eklendi";
        public static string EditCarImageMessage = "Araç resmi başarıyla güncellendi";
        public static string DeleteCarImageMessage = "Araç resmi başarıyla silindi";
        public static string AboveImageAddingLimit = "Araç maksimum resim sayısına ulaştı. Resim ekleyemezsiniz";
        public static string IncorrectFileExtension = "Kabul edilmeyen dosya uzantısı";
        public static string ImageNotFound = "Resim dosyası bulunamadı.";
        public static string CarImageNotFound = "Değiştirilmek istenen resim bulunamadı.";

        public static string AuthorizationDenied = "Yetkilendirme reddedildi";
        public static string Registered = "Başarıyla kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string WrongPassword = "Yanlış parola";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAvailable = "Kullanıcı mevcut";
        public static string TokenCreated = "Token oluşturuldu.";

        public static string InsufficientBalance = "Yetersiz bakiye";

        public static string PaymentCompleted = "Ödeme yapıldı";
    }
}
