using System.Collections.Generic;

namespace ApiClient
{
    public class BreedsResponse
    {
        public Dictionary<string, List<string>> Message { get; set; } 
    }

    public class SubBreedsResponse
    {
        public List<string> Message { get; set; }
    }

    public class ImageResponse
    {
        public string message { get; set; }
    }
    
}