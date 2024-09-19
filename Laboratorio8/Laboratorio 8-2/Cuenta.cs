

namespace Laboratorio_8_2
{
    internal class Cuenta
    {
    }
}

public class Cuenta
{
    private string idCuenta;

    public Cuenta(string prtIdCuenta)
    {
        this.idCuenta = prtIdCuenta;
        System.Console.WriteLine("Constructor Clase Base para cuenta ({0})", prtIdCuenta);
    }

    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine(
            "Cuenta.CalcularIntereses() efectuado para la cuenta [{0}]",
            this.idCuenta);
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}

public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string prtIdCuenta) : base(prtIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine(
            "CuentaCorriente.CalcularIntereses() efectuado para " +
            "la cuenta ({0})", getIdCuenta());
    }
}

public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string prtIdCuenta) : base(prtIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine(
            "CuentaAhorro.CalcularIntereses() efectuado para " +
            "la cuenta [{0}]", getIdCuenta());
    }
}