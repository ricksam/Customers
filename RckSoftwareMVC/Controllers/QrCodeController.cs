using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DotNetOpenAuth.OpenId.Extensions.AttributeExchange.WellKnownAttributes;
using static System.Net.Mime.MediaTypeNames;

namespace RckSoftwareMVC.Controllers
{
    public class QrCodeController : Controller
    {
        //
        // GET: /QrCode/
        [HttpGet]
        public ActionResult Index(string text, int size = 0, bool drawQuietZone = false)
        {
            byte[] array = Helpers.QrCodeHelper.GenerateQRCode(text, drawQuietZone);
            System.Drawing.Image image = Helpers.ProcessImage.ByteArrayToImage(array);
            if (size!=0) {
                image = Helpers.ProcessImage.ResizeImage(image, size, size);
            }
            return File(Helpers.ProcessImage.ImageToByteArray(image), "image/png");
        }

        public static string GetNumbers(string s)
        {
            if (string.IsNullOrEmpty(s))
            { return ""; }

            string r = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsNumber(s[i]))
                { r += s[i]; }
            }
            return r;
        }

        [HttpGet]
        public ActionResult TestVCard()
        {
            return VCard("Person", "test", "1122223333", "11233334444", "account@email.com", 256, true);
        }

        [HttpGet]
        public ActionResult VCard(string name, string brand, string landline, string cellphone, string email, int size = 0, bool drawQuietZone = false)
        {
            string vcard = string.Format("BEGIN:VCARD\n" +
                "FN:{0}\n" +
            "TITLE:{1}\n" +
            "ORG:{1}\n" +
            "{2}" +
                "EMAIL:{3}\n" +
                "END:VCARD", name, brand.ToUpper(),
                (!string.IsNullOrEmpty(landline) ? "TEL;TYPE=work:" + GetNumbers(landline) + "\n" : "") +
                (!string.IsNullOrEmpty(cellphone) ? "TEL;TYPE=cell:" + GetNumbers(cellphone) + "\n" : ""),
            email);

            byte[] array = Helpers.QrCodeHelper.GenerateQRCode(vcard, drawQuietZone);
            System.Drawing.Image image = Helpers.ProcessImage.ByteArrayToImage(array);
            if (size != 0) { 
            }
            image = Helpers.ProcessImage.ResizeImage(image, size, size);

            return File(Helpers.ProcessImage.ImageToByteArray(image), "image/png");
        }

    }
}
