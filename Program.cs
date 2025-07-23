internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        int contNum = 0;
        int sum = 0;

        Console.WriteLine("Ingrese números enteros positivos.\n Ingrese un número negativo para finalizar.");

        while (true)
        {
            Console.Write("Número: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                contNum = contNum + 1;
                sum = sum + num;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Se ha ingresado un número negativo {num}.\n Finalizando el programa...");
                Console.WriteLine($"Cantidad de números: {contNum}\nSuma de números: {sum}\n");
                break;
            }
        }
    }
}    