using System;

public class CalculadoraIRRF
{
    public decimal Calcular(decimal salarioBase)
    {
        if (salarioBase <= 2259.20m)
            return 0m;

        if (salarioBase <= 2826.65m)
            return (salarioBase * 0.075m) - 169.44m;

        if (salarioBase <= 3751.05m)
            return (salarioBase * 0.15m) - 381.44m;

        if (salarioBase <= 4664.68m)
            return (salarioBase * 0.225m) - 662.77m;

        return (salarioBase * 0.275m) - 896.00m;
    }
}