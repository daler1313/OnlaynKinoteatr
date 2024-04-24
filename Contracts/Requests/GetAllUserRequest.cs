
namespace Contracts.Requests.User
{
    public class GetAllUserRequest 
    {
        public IEnumerable<Domain.Entities.User> Items { get; set; } = Enumerable.Empty<Domain.Entities.User>();
    }

}