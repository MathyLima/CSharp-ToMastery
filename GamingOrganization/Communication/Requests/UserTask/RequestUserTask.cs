

using GammingOrganization.Communication.Enums;

namespace GammingOrganization.Communication.Requests.UserTask
{
    public class RequestUserTask
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public UserTasksLevelEnum TaskLevel { get; set; }

    }
}
