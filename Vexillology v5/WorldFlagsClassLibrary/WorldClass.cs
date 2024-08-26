using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldFlagsClassLibrary
{
    public class WorldClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<WorldClass> GetAllFlags()
        {
            return new List<WorldClass>
            {
                new WorldClass { Id = 1, Name = "New Zealand, Nigeria and Nepal" },
                new WorldClass { Id = 2, Name = "New Zealand, Nepal and Nigeria" },
                new WorldClass { Id = 3, Name = "Nigeria, New Zealand and Nepal" },
                new WorldClass { Id = 4, Name = "Nigeria, Nepal and New Zealand" },
                new WorldClass { Id = 5, Name = "Nepal, New Zealand and Nigeria" },
                new WorldClass { Id = 6, Name = "Nepal, Nigeria and New Zealand" }
            };
        }
    }
}
