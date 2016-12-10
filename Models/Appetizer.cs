namespace TeamProject2_Part1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appetizer")]
    public partial class Appetizer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerName { get; set; }

        [Required]
        [StringLength(100)]
        public string AppetizerDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerImage { get; set; }
    }
}
