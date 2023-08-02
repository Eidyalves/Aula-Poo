using System.Formats.Asn1;

public class Program
{
    static void Main(string[] args)
    {
        //atividade 1
        Funcinario func1 = new Funcinario();

        Console.WriteLine("Informe a matricula, nome cpf e o salário do primeiro fucionário");
        func1.matricula = Console.ReadLine();
        func1.nome = Console.ReadLine();
        func1.cpf = Console.ReadLine();
        func1.salario = Convert.ToDouble(Console.ReadLine());

        Funcinario func2 = new Funcinario();

        Console.WriteLine("Informe a matricula, nome cpf e o salário do segundo fucionário");
        func2.matricula = Console.ReadLine();
        func2.nome = Console.ReadLine();
        func2.cpf = Console.ReadLine();
        func2.salario = Convert.ToDouble(Console.ReadLine());

        if (func1.salario > func2.salario)
        {
            Console.WriteLine("O salário do 1° funcionário é maior");
        }
        else if (func1.salario < func2.salario)
        {
            Console.WriteLine(" O salário do 2° funcionário é maior");
        }
        else
        { 
            Console.WriteLine("Os dois têm o mesmo salário!!");
        }
        Triangulo triangulo = new Triangulo();
        Console.WriteLine("Adicione a medida da 1°, 2° e 3° aresta: ");
        triangulo.a = Convert.ToDouble(Console.ReadLine());
        triangulo.b = Convert.ToDouble(Console.ReadLine());
        triangulo.c = Convert.ToDouble(Console.ReadLine());

        triangulo.CalcularAreaTriangulo();

        Console.WriteLine("A area do triangulo é " + triangulo.area);

        //atividade 3
        Circulo circulo = new Circulo();
        Console.WriteLine("insira o valor do raio do circulo");
        circulo.raio = Convert.ToDouble(Console.ReadLine());

        circulo.CalcularAreaCirculo();
        Console.WriteLine("A area do circulo é " + circulo.area);
    }
}