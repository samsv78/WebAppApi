using MediatR;

namespace WebApplication1.Commands;

public class DeleteUserCommand : IRequest
{
    public DeleteUserCommand(string username, string password)
    {
        Username = username;
        Password = password;
    }
    public string Username { get; set; }
    public string Password { get; set; }
}