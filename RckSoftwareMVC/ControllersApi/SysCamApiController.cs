using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RckSoftwareMVC.ControllersApi
{
    public class SysCamApiController : ApiController
    {
        public static System.Runtime.Caching.ObjectCache Cache { get { return System.Runtime.Caching.MemoryCache.Default; } }

        public List<RckSoftwareMVC.Models.SysCam.DataImage> Images {
            get {
                if (Cache["Images"] == null) {
                    Cache["Images"] = new List<RckSoftwareMVC.Models.SysCam.DataImage>();
                }
                return (List<RckSoftwareMVC.Models.SysCam.DataImage>)Cache["Images"];
            }
        }

        public int IncrementalId
        {
            get
            {
                if (Cache["IncrementalId"] == null)
                {
                    Cache["IncrementalId"] = 0;
                }
                return (int)Cache["IncrementalId"];
            }
            set { Cache["IncrementalId"] = value; }
        }

        [HttpGet]
        public string send_image(string[] image, string camera, string authenticate)
        {
            RckSoftwareMVC.Models.SysCam.DataImage data = new Models.SysCam.DataImage();
            data.image = string.Join("", image);
            data.camera = camera;
            data.id = IncrementalId++;
            Images.Add(data);
            return "";
        }

        [HttpGet]
        public string delete_image(string date, string authenticate) {
            RckSoftwareMVC.Models.SysCam.DataImage[] array = Images.Where(q => q.date != date).ToArray();
            Images.Clear();
            Images.AddRange(array);
            return "";
        }

        [HttpGet]
        public int count_frames(string camera, string authenticate) {
            return Images.Count(q=>q.camera == camera);
        }

        [HttpGet]
        public RckSoftwareMVC.Models.SysCam.DataImage[] list_image(string lastdate, string count, string code, string camera, string authenticate)
        {
            return Images.Where(q => q.date == lastdate && q.camera == camera && q.id == Convert.ToInt32(code)).Take(Convert.ToInt32(count)).ToArray();
        }

        [HttpGet]
        public string[] list_date(int count, string authenticate)
        {
            return Images.OrderByDescending(q=>q.date).Select(q => q.date).Take(count).ToArray();
        }

        [HttpPost]
        public string[] list_cameras(string authenticate) {
            return Images.Select(q=>q.camera).ToArray();
        }
        
        [HttpGet]
        public string last_image(string authenticate)
        {
            return Images.LastOrDefault()?.image;
        }
    }
}
