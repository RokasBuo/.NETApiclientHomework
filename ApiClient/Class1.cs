using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient
{
    public class ApiHelper
    {

        private static readonly string baseAddress = "https://dog.ceo/api/";

        public static BreedsResponse GetDogs()
        {
            using (HttpClient ApiClient = new HttpClient())
            {
            
                string s = ApiClient.GetStringAsync(baseAddress + "breeds/list/all").Result;
                var list = JsonConvert.DeserializeObject<BreedsResponse>(s);

                return list;
            }
        }

        public static SubBreedsResponse GetSubBreeds(string breedname)
        {
            using (HttpClient ApiClient = new HttpClient())
            {

                string s = ApiClient.GetStringAsync(baseAddress + "breed/"+breedname+"/list").Result;
                var list = JsonConvert.DeserializeObject<SubBreedsResponse>(s);

                return list;
            }
        }

        public static ImageResponse GetBreedImage(string breedname)
        {
            using (HttpClient ApiClient = new HttpClient())
            {

                string s = ApiClient.GetStringAsync(baseAddress + "breed/"+breedname+"/images/random").Result;
                var list = JsonConvert.DeserializeObject<ImageResponse>(s);

                return list;
            }
        }

        public static ImageResponse GetRandomImage()
        {
            using (HttpClient ApiClient = new HttpClient())
            {

                string s = ApiClient.GetStringAsync(baseAddress + "breeds/image/random").Result;
                var list = JsonConvert.DeserializeObject<ImageResponse>(s);

                return list;
            }
        }
    }
}