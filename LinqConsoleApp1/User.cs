using System.Data.Linq.Mapping;

namespace LinqConsoleApp2
{
    [Table(Name = "Users")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string FirstName { get; set; }

        [Column]
        public int Age { get; set; }
    }

}
