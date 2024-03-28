while (true)
{
    Console.WriteLine("**Calculadora aritmética**");
    Console.WriteLine("-----------------------");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");
    Console.WriteLine("5. Salir");
    Console.WriteLine("-----------------------");
    Console.Write("Introduzca una opción: ");

    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            Sumar();
            break;
        case 2:
            Restar();
            break;
        case 3:
            Multiplicar();
            break;
        case 4:
            Dividir();
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
    Console.Clear();

}

static void Sumar()
{
    Console.Write("Introduzca el primer número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Introduzca el segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = Calculadora.Sumar(num1, num2);
    Console.WriteLine("El resultado de la suma es: {0}", resultado);
}

static void Restar()
{
    Console.Write("Introduzca el primer número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Introduzca el segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = Calculadora.Restar(num1, num2);
    Console.WriteLine("El resultado de la resta es: {0}", resultado);
}

static void Multiplicar()
{
    Console.Write("Introduzca el primer número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Introduzca el segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = Calculadora.Multiplicar(num1, num2);
    Console.WriteLine("El resultado de la multiplicación es: {0}", resultado);
}

static void Dividir()
{
    Console.Write("Introduzca el primer número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Introduzca el segundo número: ");
    double num2 = double.Parse(Console.ReadLine());

    if (num2 == 0)
    {
        Console.WriteLine("No se puede dividir por cero.");
        return;
    }
    
    double resultado = Calculadora.Dividir(num1, num2);
    Console.WriteLine("El resultado de la suma es: {0}", resultado);
}
