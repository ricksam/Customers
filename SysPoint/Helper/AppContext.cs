using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysPoint.Helper
{
    public class AppContext
    {
        public static string ERRO_PADRAO = "Ocorreu um erro, tente acessar dentro de alguns minutos!";

        public static SysPoint.Models.Supervisor Usuario { get; set; }

        public static bool UsuarioLogado { get { return Usuario != null; } }
    }
}