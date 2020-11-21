using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestForm.Models
{
    public class CreateOrUpdate
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Year { get; set; }
            public Genre[] Genres { get; set; }
            public bool IsInStore { get; set; }
            public Operation Operation { get; set; }
        }

        public enum Genre
        {
            Watercolor,
            Oilcolor,
            MixTechniques,
            // ...
        }

        public enum Operation
        {
            Create,
            Update,
            // ...
        }
    
}
