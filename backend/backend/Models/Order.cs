using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public List<Status> StatusHistory { get; set; }

        public string TracingId { get; set; }
    }
}