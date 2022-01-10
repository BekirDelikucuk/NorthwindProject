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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride 15 adet ürün olabilir";
        public static string ProductNameAlreadyExists="Aynı isme sahip başka bir ürün var";
        internal static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
