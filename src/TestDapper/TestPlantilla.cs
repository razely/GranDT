using Proyecto.Core.Models;
using Xunit;

namespace TestDapper;

public class TestPlantilla
{
    readonly Plantilla plantilla;

    public TestPlantilla()
    {
        plantilla = new Plantilla()
        {
            IdPlantilla = 5,
            IdUsuario = 1
        };
    }

    [Fact]
    public void CrearPlantillaOK()
    {
        Assert.Equal(5, plantilla.IdPlantilla);
        Assert.Equal(1, plantilla.IdUsuario);
    }
}