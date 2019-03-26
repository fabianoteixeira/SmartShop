using SmartShop.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartShop.Domain.Entities
{
    public class Street : Entity
    {

        
        public virtual District District { get; set; }        

        public string Name { get; set; }

        public string ZipCode { get; set; }

    }
}
