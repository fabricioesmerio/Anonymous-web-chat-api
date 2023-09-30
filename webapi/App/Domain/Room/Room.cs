using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.App.Domain.Room
{
    [Table("Room")]
    public class Room
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
