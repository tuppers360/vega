using System.ComponentModel.DataAnnotations;

namespace vega.Core.Models
{
    /// <summary>
    /// Model class for the features of the vehicles.
    /// </summary>
    public class Feature
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}