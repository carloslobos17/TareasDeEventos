using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericaFlagsClassLibrary
{
    public class AmericaFlags
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<AmericaFlags> GetAllFlags()
        {
            return new List<AmericaFlags>
            {
                new AmericaFlags { Id = 1, Name = "Aruba, Paraguay and Cuba" },
                new AmericaFlags { Id = 2, Name = "Aruba, Cuba and Paraguay" },
                new AmericaFlags { Id = 3, Name = "Cuba, Paraguay and Aruba" },
                new AmericaFlags { Id = 4, Name = "Cuba, Aruba and Paraguay" },
                new AmericaFlags { Id = 5, Name = "Paraguay, Aruba and Cuba" },
                new AmericaFlags { Id = 6, Name = "Paraguay, Cuba and Aruba" }

            };
        }
    }
}
