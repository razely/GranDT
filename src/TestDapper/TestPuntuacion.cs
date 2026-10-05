using Proyecto.Core.Models;
using Xunit;

namespace TestDapper;

public class TestPuntuacion
{
    readonly Puntuacion puntuacion;

    public TestPuntuacion()
    {
        puntuacion = new Puntuacion()
        {
            IdPuntuacion = 1,
            IdJugador = 1,
            NumFecha = 1,
            Nota = 8.5m
        };
    }

    [Fact]
    public void PuntuacionEsMayorOIgualAZero()
    {
        Assert.True(puntuacion.Nota >= 0);
    }
}