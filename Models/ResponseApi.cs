using Microsoft.AspNetCore.Mvc;

namespace lab2.Models
{
        [Route("api/[controller]")]
        [ApiController]
        public class ResponseApi
        {
            public bool IsSuccess { get; set; } = true;
            public string Notification { get; set; }
            public object Data { get; set; }
        }
    
}
