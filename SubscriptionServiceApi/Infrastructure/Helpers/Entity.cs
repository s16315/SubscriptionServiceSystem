using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubscriptionServiceApi.Infrastructure
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DefaultValue(true)] public bool Available { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfUpdate { get; set; }
    }
}