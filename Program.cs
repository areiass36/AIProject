using Helpers;
using Models;
//Diminuir o tempo médio de espera

//Euristica é a funcao que mostra o quao proximo o nó atual esta do nó final
//"Euristica custo daqui até o fim"
//Euristica é adminssivel quando não é maior q o custo real g(x)
//Definir a função custo => Definir a função euristica
//1 - Como definir o estado final = menor tempo de espera
//2 - Definir a função custo = tempo de espera
//3 - Definir a euristica = menpr tempo de espera

var ships = new ShipList(new List<Ship>
{
    new()
    {
        Key = 1,
        Size = ShipSize.Medium,
        ArriveTime = 10,
        StayTime = 30
    },
    new ()
    {
        Key = 2,
        Size = ShipSize.Medium,
        ArriveTime = 11,
        StayTime = 21
    },
});

var permutation = ships.GetPermutation();

foreach (var s in permutation)
{
    Console.WriteLine(s.GeneralAwaitTime);
    Console.WriteLine("\n====\n");
}

Console.WriteLine(permutation.Count() == ships.Value.Count().Factorial());