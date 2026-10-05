using Proyecto.Core.Models;
using Xunit;

namespace TestDapper;

public class TestJugador
{
    readonly Jugador jugador;

    public TestJugador()
    {
        jugador = new Jugador()
        {
            IdJugador = 1,
            Nombre = "Thiago Aponte",
            Posicion = "Delantero",
            Cotizacion = 67000000
        };
    }

    [Fact]
    public void CrearJugadorOK()
    {
        Assert.Equal("Thiago Aponte", jugador.Nombre);
        Assert.Equal("Delantero", jugador.Posicion);
    }

    [Fact]
    public void CotizacionEsMayorACero()
    {
        Assert.True(jugador.Cotizacion > 0);
    }
}