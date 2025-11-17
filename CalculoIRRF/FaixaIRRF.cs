public class FaixaIRRF
{
    public double Min { get; set; }
    public double Max { get; set; }
    public double Aliquota { get; set; }
    public double Deducao { get; set; }

    public bool Pertence(double salario)
    {
        return salario >= Min && salario <= Max;
    }
}
