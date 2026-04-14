namespace IMuDB.Domain.Entities
{
    public class BaseEntity
    {
        public string Id { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.MinValue;
        public DateTime UpdatedAt { get; set; } = DateTime.MinValue;
    }
}
