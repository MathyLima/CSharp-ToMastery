namespace GammingOrganization.Communication.Responses.UserTask
{
    public class ResponseUserTaskJson
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
       
    }
}
