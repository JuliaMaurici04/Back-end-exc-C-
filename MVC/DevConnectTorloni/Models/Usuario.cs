using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectTorloni.Models;

[Index("NomeUsuario", Name = "UQ__Usuario__06940B9A00F961D9", IsUnique = true)]
[Index("Email", Name = "UQ__Usuario__A9D10534898B8454", IsUnique = true)]
public partial class Usuario
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    public string NomeUsuario { get; set; } = null!;

    [StringLength(30)]
    public string NomeCompleto { get; set; } = null!;

    [StringLength(255)]
    public string Email { get; set; } = null!;

    [StringLength(30)]
    public string Senha { get; set; } = null!;

    [StringLength(255)]
    public string? FotoPerfilUrl { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Comentario> Comentario { get; set; } = new List<Comentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Curtida> Curtida { get; set; } = new List<Curtida>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Publicacao> Publicacao { get; set; } = new List<Publicacao>();

    [ForeignKey("IdUsuarioSeguir")]
    [InverseProperty("IdUsuarioSeguir")]
    public virtual ICollection<Usuario> IdUsuarioSeguidor { get; set; } = new List<Usuario>();

    [ForeignKey("IdUsuarioSeguidor")]
    [InverseProperty("IdUsuarioSeguidor")]
    public virtual ICollection<Usuario> IdUsuarioSeguir { get; set; } = new List<Usuario>();
}
