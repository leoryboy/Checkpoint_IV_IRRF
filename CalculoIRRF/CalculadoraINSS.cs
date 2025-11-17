public class CalculadoraINSS
{
    public decimal Calcular(decimal salario)
    {
        decimal total = 0m;

        if (salario <= 1518.00m)
            total = salario * 0.075m;

        else if (salario <= 2793.88m)
            total =
                (1518.00m * 0.075m) +
                ((salario - 1518.00m) * 0.09m);

        else if (salario <= 4190.83m)
            total =
                (1518.00m * 0.075m) +
                ((2793.88m - 1518.00m) * 0.09m) +
                ((salario - 2793.88m) * 0.12m);

        else if (salario <= 8157.41m)
            total =
                (1518.00m * 0.075m) +
                ((2793.88m - 1518.00m) * 0.09m) +
                ((4190.83m - 2793.88m) * 0.12m) +
                ((salario - 4190.83m) * 0.14m);

        else
            total = 876.97m; // teto INSS 2025

        return Math.Round(total, 2);
    }
}