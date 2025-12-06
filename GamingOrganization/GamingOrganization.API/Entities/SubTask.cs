namespace GamingOrganization.API.Entities
{
    public class SubTask:EntityBase
    {
        public string Title { get; set; } =  string.Empty;
        public string Description { get; set; } = string.Empty ;
        public bool IsCompleted { get; set; }
        public int Order { get; set; }
        public DateOnly? CompletedDate { get; set; }
        public Guid UserTaskId { get; set; }
        public UserTask UserTask { get; set; } = null!;

    }
}
