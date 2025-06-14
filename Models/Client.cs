namespace ProjetCrud.Models;

public class Client
{
    public int Id { get; set; }          // Cl� primaire AUTO_INCREMENT
    public string? Nom { get; set; }     // Nullable
    public string? Prenom { get; set; }  // Nullable
    public string? Contact { get; set; } // Nullable
}