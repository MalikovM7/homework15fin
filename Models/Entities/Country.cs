using System.ComponentModel.DataAnnotations.Schema;

namespace WebIntroEmpty.Models.Entities
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Code { get; set; }
    }
}
