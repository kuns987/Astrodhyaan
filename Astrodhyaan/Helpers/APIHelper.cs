using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Astrodhyaan.Models;
namespace Astrodhyaan.Helpers
{
    public class APIHelper
    {
        private string url = string.Empty;
        HttpClient client = new HttpClient();
        public AdminPageEntity GetAdminPage(long PageId, long LanguageId)
        {
            AdminPageRequest adminpagerequest = new AdminPageRequest();
            adminpagerequest.PageId = PageId;
            adminpagerequest.LanguageId = LanguageId;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://astrodhaam.com/astrodhaamwebapi/api/page/GetAdminPage");
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(adminpagerequest), Encoding.UTF8, "application/json");
            client.Timeout = TimeSpan.FromSeconds(200);
            HttpResponseMessage response = client.PostAsync(this.url, contentPost).Result;
            AdminPageEntity data = null;
            if (response.IsSuccessStatusCode)
            {
                string strResult = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<AdminPageResponse>(response.Content.ReadAsStringAsync().Result).adminPageList;
            }

            return data;
        }
        public MobileHomeResponse GetHomePage(long PageId,long LanguageId,long UserId)
        {
            MobileHomeRequest mobilehomerequest = new MobileHomeRequest();
            mobilehomerequest.PageId = PageId;
            mobilehomerequest.LanguageId = LanguageId;
            mobilehomerequest.UserId = UserId;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://astrodhaam.com/astrodhaamwebapi/api/Mobile/Home");
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(mobilehomerequest), Encoding.UTF8, "application/json");
            client.Timeout = TimeSpan.FromSeconds(200);
            HttpResponseMessage response = client.PostAsync(this.url, contentPost).Result;
            MobileHomeResponse data = null;
            if (response.IsSuccessStatusCode)
            {
                string strResult = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<MobileHomeResponse>(response.Content.ReadAsStringAsync().Result);
            }

            return data;
        }
    }
}