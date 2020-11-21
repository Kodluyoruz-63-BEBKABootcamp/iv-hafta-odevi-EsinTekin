using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestForm.Models
{
    public class CreateNewUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Properties[] Properties { get; set; }
        public Operations Operations { get; set; }
    }

    public enum Properties
    {
        Artist,
        Artlovers,
        // ...
    }

    public enum Operations
    {
        Create,
        Update,
        // ...
    }
}

