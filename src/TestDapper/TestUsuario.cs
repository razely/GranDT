using Proyecto.Core.Models;
using Xunit;

namespace TestDapper;

public class TestUsuario
{
    readonly Usuario usuario;

    public TestUsuario()
    {
        usuario = new Usuario()
        {
            IdUsuario = 1,
            Nombre = "Juan",
            Email = "juan@mail.com"
        };
    }

    [Fact]
    public void CrearUsuarioOK()
    {
        Assert.Equal(1, usuario.IdUsuario);
        Assert.Equal("Juan", usuario.Nombre);
    }

    [Fact]
    public void EmailTieneFormatoValido()
    {
        Assert.NotNull(usuario.Email);
        Assert.Contains("@", usuario.Email);
    }
}