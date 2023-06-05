using System;

try
{
    Console.WriteLine("Informe o primeiro valor: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor: ");
    int b = int.Parse(Console.ReadLine());

    int result = a / b;
    Console.WriteLine(result);
}
catch(Exception ex)
{
    Console.WriteLine("Não é possível dividir qualquer número por zero" + ex.Message);
}