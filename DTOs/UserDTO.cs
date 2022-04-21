using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TwitterTask.DTOs;



public record UserDTO
{

    [Required]
    [JsonPropertyName("name")]
    [MinLength(3)]
    [MaxLength(255)]
    public string Name { get; set; }
    [Required]
    [JsonPropertyName("email")]
    [MinLength(3)]
    [MaxLength(255)]
    public string Email { get; set; }

    [Required]
    [JsonPropertyName("password")]
    [MaxLength(255)]
    public string Password { get; set; }
}


public record UserRegisterDTO
{

    [Required]
    [JsonPropertyName("name")]
    [MinLength(3)]
    [MaxLength(255)]
    public string Name { get; set; }
    [Required]
    [JsonPropertyName("email")]
    [MinLength(3)]
    [MaxLength(255)]
    public string Email { get; set; }

    [Required]
    [JsonPropertyName("password")]
    [MaxLength(255)]
    public string Password { get; set; }
}

public record UserLoginDTO
{
    [Required]
    [JsonPropertyName("email")]
    [MinLength(3)]
    [MaxLength(255)]
    public string Email { get; set; }

    [Required]
    [JsonPropertyName("password")]
    [MaxLength(255)]
    public string Password { get; set; }
}

public record UserLoginResDTO
{
    [JsonPropertyName("token")]
    public string Token { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
}


public record UserUpdateDTO
{


    [JsonPropertyName("name")]
    public string Name { get; set; }


}
