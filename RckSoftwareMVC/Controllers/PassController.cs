using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
    public class PassController : Controller
    {
        //
        // GET: /Senhas/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Gerar(string site, string chave, bool maiuscula, bool minuscula, bool numeros, bool especial)
        {
            //lib.Class.Utils.GetTimeMap()
            string sha = lib.Class.Encryption.getSHA1Bytes(site + chave);
            long num = 0;
            int size = 9;
            while (sha.Length > 0) {
                if (sha.Length > size)
                {
                    num += Convert.ToInt64(sha.Substring(0, size));
                    sha = sha.Remove(0, size);
                }
                else {
                    num += Convert.ToInt64(sha.Substring(0, sha.Length));
                    sha = "";
                }
                
            }
            return Json(GenerateCode(num, maiuscula, minuscula, numeros, especial));
        }

        public static string GetResultFromCharacterMap(ushort[] v, string m)
        {
            string r = "";
            for (int i = (v.Length - 1); i >= 0; i--)
            { r += m[v[i]].ToString(); }
            return r;
        }

        public static ushort[] DecimalBaseForBase(ulong n, ushort b)
        {
            if (n == 0 || b == 0)
            { return new ushort[] { }; }

            List<ushort> rslt = new List<ushort>();
            uint digitPos = 1;

            while (n != 0)
            {
                ulong r = (n % b) * digitPos;
                if (digitPos != 0)
                { r /= digitPos; }
                rslt.Add((ushort)r);
                n /= b;
                digitPos *= 10;
            }
            return rslt.ToArray();
        }

        static int minSize = int.MaxValue;
        static int maxSize = 0;

        public static string GenerateCode(string char_map, long number)
        {
            ushort bs = (ushort)char_map.Length;

            ushort[] values = DecimalBaseForBase((ulong)number, bs);

            string code = GetResultFromCharacterMap(values, char_map);

            if (code.Length < minSize)
            {
                minSize = code.Length;
            }
            if (code.Length > maxSize)
            {
                maxSize = code.Length;
            }
            return code;
        }

        public static string GenerateCode(long number, bool upper, bool lower, bool numbers, bool special)
        {
            //         0=OQ 1=I 4=A 5=S 6=G 8=B U=V E=F
            string char_map_let = "abcdefghijklmnopqrstuvwxyz";
            string char_map_dig = "@&*";

            string letras = GenerateCode(char_map_let, number);
            string numero = number.ToString();
            string digito = GenerateCode(char_map_dig, number);

            string maiuscula = letras.Substring(0, 1).ToUpper();
            string minuscula = letras.Substring(letras.Length-2, 2);
            numero = numero.Substring(numero.Length - 4, 4);
            digito = digito.Substring(0, 1);

            if (number % 3 == 0) { return (upper ? maiuscula : "") + (lower? minuscula :"") + (numbers? numero:"") + (special?digito:""); }
            if (number % 3 == 1) { return (upper ? maiuscula : "") + (lower ? minuscula : "") + (special ? digito : "") + (numbers ? numero : ""); }
            if (number % 3 == 2) { return (upper ? maiuscula : "") + (special ? digito : "") + (lower ? minuscula : "") + (numbers ? numero : ""); }
            else {
                return (upper ? maiuscula : "") + (special ? digito : "") + (numbers ? numero : "") + (lower ? minuscula : "");
            }
        }

    }
}
