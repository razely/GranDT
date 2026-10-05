using Proyecto.Core.Models;
using Xunit;

namespace TestDapper;

public class TestEquipo
{
    readonly Equipo equipoEjemplo;

    public TestEquipo()
    {
        equipoEjemplo = new Equipo()
        {
            IdEquipo = 1,
            Nombre = "CK Angel"
        };
    }

    [Fact]
    public void CrearEquipoOK()
    {
        Assert.Equal(1, equipoEjemplo.IdEquipo);
        Assert.Equal("CK Angel", equipoEjemplo.Nombre);
    }
}