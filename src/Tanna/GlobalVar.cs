using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanna
{
    public static class GlobalVar
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int ID { get; set; }
        public static int Type { get; set; }

        public static void Logout(Home homeForm)
        {
            // Redefinir as variáveis globais para o estado de deslogado
            Username = null;
            Password = null;
            ID = 0;
            Type = 0;
        }
    }
}
