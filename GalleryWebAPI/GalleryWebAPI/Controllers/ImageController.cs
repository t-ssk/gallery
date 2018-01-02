//using GalleryWebAPI.Models;
using GalleryWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace GalleryWebAPI.Controllers
{
    /*NOT IMPLEMENTED*/

    public class ImageController : ApiController
    {
        ImageModel queriedImages;
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //[HttpGet]
        //[Route("{userName}")]
        //public IHttpActionResult GetImages()
        //{
        //    int[] userID = (from queriedUser in this.users
        //                    where queriedUser.UserName.Equals(userName)
        //                    select queriedUser.UserId).ToArray();
        //    if (userID.Count() != 1)
        //    {
        //        return InternalServerError();
        //    }
        //    else
        //    {
        //        var result = new HttpResponseMessage(HttpStatusCode.OK);

        //    }

        //    // where UserName.Equals(user));
        //    //this.queriedImages = images.Where(i => i.UserId = ;
        //}

        // GET api/values/5
        [HttpGet]
        [Route("image/{id}")]
        public HttpResponseMessage GetImage(int id)
        {
            string currentDir = System.AppDomain.CurrentDomain.BaseDirectory;
            string imageURL = currentDir + images.First(i => i.Id == id).Url;

            var result = new HttpResponseMessage(HttpStatusCode.OK);

            FileStream fileStream = new FileStream(imageURL, FileMode.Open);
            Image image = Image.FromStream(fileStream);
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);

            result.Content = new ByteArrayContent(memoryStream.ToArray());
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            return result;
        }
       // private User[] users = new Models.User[]
       //{
       //     new User { UserId = 1, UserName = "Sam"},
       //     new User { UserId = 2, UserName = "Sarah"}
       //};
        private ImageModel[] images = new ImageModel[]
        {
            new ImageModel { UserId = 1, Id = 1, Category = "Italy", Description = "Coliseum", Url = "Assets/Images/1_Sam/123.jpg"   },
            new ImageModel { UserId = 1, Id = 2, Category = "Food", Description = "Tomato", Url = "Assets/Images/1_Sam/234.jpg"   },
            new ImageModel { UserId = 1, Id = 3, Category = "Food", Description = "Beef", Url = "Assets/Images/1_Sam/IMG_20150311_201335314_HDR.jpg"   },
            new ImageModel { UserId = 1, Id = 4, Category = "Food", Description = "Saffron cream soup with tuna", Url = "Assets/Images/1_Sam/IMG_20150311_202205553_HDR.jpg"   },
            new ImageModel { UserId = 1, Id = 5, Category = "Food", Description = "Ceviche", Url = "Assets/Images/1_Sam/IMG_20160228_175046709_HDR.jpg"   },
            new ImageModel { UserId = 1, Id = 6, Category = "Food", Description = "Dessert", Url = "Assets/Images/1_Sam/IMG_20160722_200626.jpg"   },
            new ImageModel { UserId = 1, Id = 7, Category = "Scenary", Description = "Club House", Url = "Assets/Images/1_Sam/IMG_20160722_203424.jpg"   },
            new ImageModel { UserId = 1, Id = 8, Category = "Scenary", Description = "Winery", Url = "Assets/Images/1_Sam/IMG_20160910_160408.jpg"   },
            new ImageModel { UserId = 1, Id = 9, Category = "Food", Description = "Scallops", Url = "Assets/Images/1_Sam/IMG_20161230_144045.jpg"   },
            new ImageModel { UserId = 1, Id = 10, Category = "Food", Description = "Tuna tartar", Url = "Assets/Images/1_Sam/IMG_20161230_144054.jpg"   },
            new ImageModel { UserId = 1, Id = 11, Category = "Food", Description = "homemade", Url = "Assets/Images/1_Sam/IMG_20170115_185904.jpg"   },
            new ImageModel { UserId = 1, Id = 12, Category = "Food", Description = "pizzzaa", Url = "Assets/Images/1_Sam/IMG_20170421_184240.jpg"   },
            new ImageModel { UserId = 1, Id = 13, Category = "Italy", Description = "Coliseum2", Url = "Assets/Images/1_Sam/IMG_20170425_200835.jpg"   },
            new ImageModel { UserId = 1, Id = 14, Category = "Food", Description = "Tomator Shrimp", Url = "Assets/Images/1_Sam/IMG_20170426_133032.jpg"   },
            new ImageModel { UserId = 2, Id = 15, Category = "Italy", Description = "Vatican", Url = "Assets/Images/2_Sarah/IMG_20170426_210935.jpg"   },
            new ImageModel { UserId = 2, Id = 16, Category = "Italy", Description = "Rome", Url = "Assets/Images/2_Sarah/IMG_20170427_140538.jpg"   },
            new ImageModel { UserId = 2, Id = 17, Category = "Italy", Description = "Leaving Italy!", Url = "Assets/Images/2_Sarah/IMG_20170428_200407.jpg"   },
            new ImageModel { UserId = 2, Id = 18, Category = "Food", Description = "Traditional Croatian food", Url = "Assets/Images/2_Sarah/IMG_20170430_194504.jpg"   },
            new ImageModel { UserId = 2, Id = 19, Category = "Croatia", Description = "Night Sky", Url = "Assets/Images/2_Sarah/IMG_20170430_205540.jpg"   },
            new ImageModel { UserId = 2, Id = 20, Category = "Croatia", Description = "Water", Url = "Assets/Images/2_Sarah/IMG_20170501_191454.jpg"   },
            new ImageModel { UserId = 2, Id = 21, Category = "Croatia", Description = "Split", Url = "Assets/Images/2_Sarah/IMG_20170502_215920.jpg"   },
            new ImageModel { UserId = 2, Id = 22, Category = "Food", Description = "Fish", Url = "Assets/Images/2_Sarah/IMG_20170503_194424.jpg"   },
            new ImageModel { UserId = 2, Id = 23, Category = "DC", Description = "Eclipse!", Url = "Assets/Images/2_Sarah/IMG_20170821_143543.jpg"   },
            new ImageModel { UserId = 2, Id = 24, Category = "DC", Description = "Monument", Url = "Assets/Images/2_Sarah/IMG_20171224_180352.jpg"   }

        };
        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}

    }
}
