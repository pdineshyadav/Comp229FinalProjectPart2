namespace TeamProject2_Part1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dessert
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DessertName { get; set; }

        [Required]
        [StringLength(100)]
        public string DessertDescription { get; set; }

        [StringLength(50)]
        public string DessertPrice { get; set; }

        [StringLength(250)]
        public string DessertImage { get; set; }
    }
}
