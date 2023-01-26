using System;
namespace MyfirstAPI.Models
{
        public class Email
        {
            public int EmailId { get; set; }
            public string? EmailAddress { get; set; }
            public bool IsSubscribed { get; set; }
        }
}
