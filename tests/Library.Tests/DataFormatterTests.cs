using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class DataFormatterTests
{
    
    [Test]
    public void Correcto()
    {
        string date = "15/06/2000";
        string RespuestaEsperada = "2000-6-15";
        string prueba = DateFormatter.ChangeFormat(date);
        Assert.That(prueba, Is.EqualTo(RespuestaEsperada));
    }
    [Test]
    public void Vacio()
    {
        string date = "";
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            string actual = DateFormatter.ChangeFormat(date);
        });       
    }
    [Test]
    public void Incorrecto()
    {
        string date = "02/25/2000";
        string prueba = DateFormatter.ChangeFormat(date);
        Assert.That(prueba, Is.EqualTo("La fecha es inválida"));

    }
}
