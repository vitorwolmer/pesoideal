// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Cálculo do Peso Ideal");

int XXX;
double pim;
double pih;
double altura;
string nome;
char sexo;

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine($"{nome}, digite sua Altura (m):");
altura = double.Parse(Console.ReadLine());

Console.WriteLine($"{nome}, escolha uma opção: [h] Homem ou [m] Mulher.");
sexo = char.Parse(Console.ReadLine());


    switch (sexo){

    case 'H':
    case 'h':
        
        pih = Convert.ToDouble((72.7 * altura) - 58.0);
        Math.Round(pih, 2, MidpointRounding.AwayFromZero);
        //XXX = 1;
        Console.WriteLine($"{nome}, seu peso ideal (kg) é {pih}");

        break;

    case 'M':
    case 'm':

        pim = Convert.ToDouble((62.1 * altura) - 44.7);
        Math.Round(pim, 2, MidpointRounding.AwayFromZero);
        //XXX = 0;
        Console.WriteLine($"{nome}, seu peso ideal (kg) é {pim}");

        break;

    default:
        Console.WriteLine("Opção inválida.");
        //XXX = -1;
        break;
}

//if (XXX == 1)
{
          //Console.WriteLine($"{nome}, seu peso ideal (kg) é {pih}");
}
//else if (XXX == 0)
{
          //Console.WriteLine($"{nome}, seu peso ideal (kg) é {pim}");
}
//else
{
   // Console.WriteLine("Informação inválida.");
}
