// Desafio
// A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

// Salário	
// 0 - 400.00
// 400.01 - 800.00
// 800.01 - 1200.00
// 1200.01 - 2000.00
// Acima de 2000.00

// Percentual de Reajuste
// 15%
// 12%
// 10%
// 7%
// 4%

// Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
// Entrada
// A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.

// Saída
// Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.

// Exemplo de Entrada	
// 400.00
// Exemplo de Saída
// Novo salario: 460.00
// Reajuste ganho: 60.00
// Em percentual: 15 %

// Exemplo de Entrada	
// 800.01
// Exemplo de Saída
// Novo salario: 880.01
// Reajuste ganho: 80.00
// Em percentual: 10 %

// Exemplo de Entrada
// 2000.00
// Exemplo de Saída
// Novo salario: 2140.00
// Reajuste ganho: 140.00
// Em percentual: 7 %


class DIO_5
{
    public static void Main(string[] args)
    {
        double salario = 0.00;
        double reajuste = 0.00;
        double novoSalario = 0.00;
        double percentual = 0.00;
        salario = Convert.ToDouble(Console.ReadLine());
        if (salario < 400.01)
        {
            percentual = .15;
            reajuste = salario * percentual;
            novoSalario = salario * (percentual + 1);
        }
        else if (salario < 800.01)
        {
            percentual = .12;
            reajuste = salario * percentual;
            novoSalario = salario * (percentual + 1);
        }
        else if (salario < 1200.01)
        {
            percentual = .10;
            reajuste = salario * percentual;
            novoSalario = salario * (percentual + 1);
        }
        else if (salario < 2000.01)
        {
            percentual = .07;
            reajuste = salario * percentual;
            novoSalario = salario * (percentual + 1);
        }
        else if (salario > 2000)
        {
            percentual = .04;
            reajuste = salario * percentual;
            novoSalario = salario * (percentual + 1);
        }

        Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
        Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
        Console.WriteLine("Em percentual: {0:0} %", percentual * 100);
    }
}