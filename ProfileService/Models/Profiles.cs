﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProfileService.Models;

public class Profiles
{
    [Key]
    [JsonIgnore]
    public int ProfileId { get; set; }


    public string Description { get; set; } = "Empty";
    public int UserId { get; set; }
    public byte[] Photo{ get; set; }
    public string LastName { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }

    public string UniversityName { get; set; }
    public  byte[] BackgroundProfile{ get; set; }

    public List<Projects> Projects { get; set; }
    public List<Skills>  Skills{ get; set; }


}
