Console.WriteLine("Sistema CALC");
Console.WriteLine("Selecione uma opção:");
Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair");

Menu opcao = (Menu)int.Parse(Console.ReadLine());

Console.ReadLine();

enum Menu
{
    Soma = 1,
    Subtracao,
    Divisao,
    Multiplicacao,
    Potencia,
    Raiz,
    Sair
}

