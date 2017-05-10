using System.Collections.Generic;
using Handmadeua.Data.Models.JoinedEntities;

namespace Handmadeua.Data.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<MaterialProduct> MaterialProducts { get; set; }

        public Material()
        {
            MaterialProducts = new List<MaterialProduct>();
        }
    }
}
