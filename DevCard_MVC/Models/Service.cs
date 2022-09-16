using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Service(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
