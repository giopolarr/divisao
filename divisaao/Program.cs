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
catch(DivideByZeroException ex)
{
    Console.WriteLine("Não é possível dividir qualquer número por zero" + ex.Message);
}
catch(InvalidCastException ex)
{
    Console.WriteLine($"Conversão de strig para letra não é permitida! {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("Ocorreu um erro" + ex.Message);
}
finally
{
    Console.WriteLine("Aqui passa de qualquer forma!");
}