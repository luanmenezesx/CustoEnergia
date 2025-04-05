Console.Clear();

double tempoDeDiario, consumoDoAparelho, custoEnergia, custoDeUmMes;

Console.WriteLine("--- Custo de Energia ---");

Console.Write("Consumo do aparelho (em KWh/mês)...:");
consumoDoAparelho = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Horas de uso por dia...............:");
tempoDeDiario = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Custo de energia (em R$/KWh).......:");
custoEnergia = Convert.ToDouble(Console.ReadLine()!);


custoDeUmMes = tempoDeDiario * consumoDoAparelho * custoEnergia;

Console.Write("Custo estimado do mês será.........:");
Console.WriteLine($"R$ {custoDeUmMes:F2}");
