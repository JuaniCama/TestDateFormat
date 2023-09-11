namespace Ucu.Poo.TestDateFormat;

public class Fecha
    {
        public static bool VerificarFecha(int day, int month, int year)
            {
            try
            {
                DateTime fecha = new DateTime(year, month, day);
                return true;
            }
            catch(ArgumentOutOfRangeException)
            {
                return false;
            }
        }
}