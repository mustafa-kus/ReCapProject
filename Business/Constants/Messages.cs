using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

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
        internal static string AuthorizationDenied="Yetkiniz Yok";
    }
}
