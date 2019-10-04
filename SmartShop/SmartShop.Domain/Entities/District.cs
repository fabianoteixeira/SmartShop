using SmartShop.Domain.Core.Entities;

namespace SmartShop.Domain.Entities
{
    public class District: Entity
    {
        public virtual City City { get; set; } 

        public string Name { get; set; }

    }
}
