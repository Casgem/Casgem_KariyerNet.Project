using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_CoreLayer.CommonMessages.Constants
{
    public static class Messages
    {
        public static string RegisterSuccessfully { get; set; } = "Kullanıcının kaydı oluştu.";
        public static string RegisterFail { get; set; } = "Kullanıcı bir hata sebebiyle kayıt olamadı.";
        public static string LoginSuccessfully { get; set; } = "Kullanıcı login oldu.";
        public static string LoginFail { get; set; } = "Kullanıcı bir hata sebebiyle login olamadı.";
    }
}
