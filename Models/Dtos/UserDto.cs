using AgendaApi.Models.Enum;

namespace AgendaApi.Models.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public State State { get; set; }
        public Role Role { get; set; }
    }
}
