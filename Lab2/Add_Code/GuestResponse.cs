using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Add_Code
{
    public class GuestResponse
    {
        public int GuestResponseIdId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
        public DateTime Rdata { get; set; }
        public GuestResponse(string name, string email, string phone, bool? willattend) 
        { 
            Name = name; 
            Email = email; 
            Phone = phone; 
            WillAttend = willattend; 
            Rdata = DateTime.Now; 
        }
    }
}