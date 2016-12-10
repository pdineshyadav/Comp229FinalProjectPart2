namespace TeamProject2_Part1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Soup")]
    public partial class Soup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string SoupName { get; set; }

        [StringLength(100)]
        public string SoupDescription { get; set; }

        [StringLength(50)]
        public string SoupPrice { get; set; }

        [StringLength(50)]
        public string SoupImage { get; set; }
    }
}
