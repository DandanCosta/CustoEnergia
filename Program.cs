double consumo, horasUsoDia;
decimal custo, custoMes;

Console.WriteLine("- - - Custo de Energia - - -\n");

Console.Write("Consumo do aparelho (em kWh/mes)...: ");
consumo = double.Parse(Console.ReadLine()!);

Console.Write("Horas de uso por dia...............: ");
horasUsoDia = double.Parse(Console.ReadLine()!);

Console.Write("Custo de Energia (em R$/kWh).......: ");
custo = decimal.Parse(Console.ReadLine()!);

custoMes = Convert.ToDecimal(consumo * horasUsoDia) * custo;

Console.WriteLine($"\nCusto estimado: {custoMes:c2}");