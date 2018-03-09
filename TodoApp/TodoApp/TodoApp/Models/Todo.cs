using SQLite;

namespace TodoApp.Models
{
    [Table("Todos")]
    public class Todo
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public int Importance { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
