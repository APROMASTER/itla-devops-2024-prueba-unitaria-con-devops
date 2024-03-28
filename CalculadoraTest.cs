namespace itla_devops_2024_prueba_unitaria_con_devops;

public class CalculadoraTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test(ExpectedResult = 15)]
    public double Sumar_DosNumerosPositivos_ResultadoCorrecto()
    {
        double num1 = 5;
        double num2 = 10;

        return Calculadora.Sumar(num1, num2);
    }

    [Test(ExpectedResult = -15)]
    public double Sumar_DosNumerosNegativos_ResultadoCorrecto()
    {
        double num1 = -5;
        double num2 = -10;

        return Calculadora.Sumar(num1, num2);
    }

    [Test(ExpectedResult = -5)]
    public double Sumar_UnNumeroPositivoYUnNumeroNegativo_ResultadoCorrecto()
    {
        double num1 = 5;
        double num2 = -10;

        return Calculadora.Sumar(num1, num2);
    }

    [Test(ExpectedResult = 5)]
    public double Restar_DosNumerosPositivos_ResultadoCorrecto()
    {
        double num1 = 10;
        double num2 = 5;

        return Calculadora.Restar(num1, num2);
    }

    [Test(ExpectedResult = -5)]
    public double Restar_DosNumerosNegativos_ResultadoCorrecto()
    {
        double num1 = -10;
        double num2 = -5;

        return Calculadora.Restar(num1, num2);
    }

    [Test(ExpectedResult = 15)]
    public double Restar_UnNumeroPositivoYUnNumeroNegativo_ResultadoCorrecto()
    {
        double num1 = 10;
        double num2 = -5;

        return Calculadora.Restar(num1, num2);
    }

    [Test(ExpectedResult = 50)]
    public double Multiplicar_DosNumerosPositivos_ResultadoCorrecto()
    {
        double num1 = 5;
        double num2 = 10;

        return Calculadora.Multiplicar(num1, num2);
    }

    [Test(ExpectedResult = 50)]
    public double Multiplicar_DosNumerosNegativos_ResultadoCorrecto()
    {
        double num1 = -5;
        double num2 = -10;

        return Calculadora.Multiplicar(num1, num2);
    }

    [Test(ExpectedResult = -50)]
    public double Multiplicar_UnNumeroPositivoYUnNumeroNegativo_ResultadoCorrecto()
    {
        double num1 = 5;
        double num2 = -10;

        return Calculadora.Multiplicar(num1, num2);
    }

    [Test(ExpectedResult = 2)]
    public double Dividir_DosNumerosPositivos_ResultadoCorrecto()
    {
        double num1 = 10;
        double num2 = 5;

        return Calculadora.Dividir(num1, num2);
    }

    [Test(ExpectedResult = 2)]
    public double Dividir_DosNumerosNegativos_ResultadoCorrecto()
    {
        double num1 = -10;
        double num2 = -5;

        return Calculadora.Dividir(num1, num2);
    }
}