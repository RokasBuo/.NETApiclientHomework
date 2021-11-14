using System.Collections.Generic;

namespace ApiClient
{
    public class Response
    {
        public Dictionary<string, List<string>> Message { get; set; } 
    }

    public class ImageResponse
    {
        public string message { get; set; }
    }
    
}