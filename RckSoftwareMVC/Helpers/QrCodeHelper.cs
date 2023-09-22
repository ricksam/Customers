using System;
using QRCoder;

namespace RckSoftwareMVC.Helpers
{
    public class QrCodeHelper
    {
        public static byte[] GenerateQRCode(string payloadString, bool drawQuietZones)
        {
            QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.L;
            SupportedImageFormat imageFormat = SupportedImageFormat.Png;
            int pixelsPerModule = 8;
            string foregroundColor = "#000000";
            string backgroundColor = "#FFFFFF";

            return GenerateQRCode(payloadString, eccLevel, imageFormat, pixelsPerModule, foregroundColor, backgroundColor, drawQuietZones);
        }

        private static byte[] GenerateQRCode(string payloadString, QRCodeGenerator.ECCLevel eccLevel, SupportedImageFormat imgFormat, int pixelsPerModule, string foreground, string background, bool drawQuietZones)
        {
            using (var generator = new QRCodeGenerator())
            {
                using (var data = generator.CreateQrCode(payloadString, eccLevel))
                {
                    switch (imgFormat)
                    {
                        case SupportedImageFormat.Png:
                        case SupportedImageFormat.Jpg:
                        case SupportedImageFormat.Gif:
                        case SupportedImageFormat.Bmp:
                        case SupportedImageFormat.Tiff:
                            using (var code = new QRCode(data))
                            {
                                using (var bitmap = code.GetGraphic(pixelsPerModule, foreground, background, drawQuietZones))
                                {
                                    var actualFormat = new OptionSetter().GetImageFormat(imgFormat.ToString());
                                    string base64 = ProcessImage.ImageToString(bitmap);
                                    return Convert.FromBase64String(base64);
                                    //bitmap.Save(outputFileName, actualFormat);
                                }
                            }
                        /*case SupportedImageFormat.Svg:
                            using (var code = new SvgQRCode(data))
                            {
                                var test = code.GetGraphic(pixelsPerModule, foreground, background, true);
                                using (var f = File.CreateText(outputFileName))
                                {
                                    f.Write(test);
                                    f.Flush();
                                }
                            }
                            break;
                        case SupportedImageFormat.Xaml:
                            using (var code = new QRCoder.XamlQRCode(data))
                            {
                                var test = XamlWriter.Save(code.GetGraphic(pixelsPerModule, foreground, background, true));
                                using (var f = File.CreateText(outputFileName))
                                {
                                    f.Write(test);
                                    f.Flush();
                                }
                            }
                            break;
                        case SupportedImageFormat.Ps:
                        case SupportedImageFormat.Eps:
                            using (var code = new PostscriptQRCode(data))
                            {
                                var test = code.GetGraphic(pixelsPerModule, foreground, background, true,
                                    imgFormat == SupportedImageFormat.Eps);
                                using (var f = File.CreateText(outputFileName))
                                {
                                    f.Write(test);
                                    f.Flush();
                                }
                            }
                            break;*/
                        default:
                            throw new ArgumentOutOfRangeException(nameof(imgFormat), imgFormat, null);
                    }

                }
            }
        }
    }
}