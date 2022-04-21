using TwitterTask.DTOs;

namespace TwitterTask.Models;

public record User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }



    public UserDTO asDto => new UserDTO
    {
        Name = Name,
        Email = Email,
        Password = Password,
    };
}