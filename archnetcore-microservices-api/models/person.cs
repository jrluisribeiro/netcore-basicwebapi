using Microsoft.AspNetCore.Mvc;

namespace archnetcore_microservices_api.models;

public class Person
{
    public string? id { get; set; }
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public DateTime birthDate { get; set; }
}