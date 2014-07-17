using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarParts.Models
{
    public class Parts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}