Console.WriteLine("# Testes com SortedSet #");

Console.WriteLine("Informe número inteiros válidos. " +
    "Para encerrar a inclusão digite um conteúdo inválido...");

var dadosIniciais = new List<int>();
var entradaValida = true;
do
{
    var entrada = Console.ReadLine();
    if (!String.IsNullOrWhiteSpace(entrada) &&
        int.TryParse(entrada, out int valor))
            dadosIniciais.Add(valor);
    else
    {
        entradaValida = false;
        Console.WriteLine("Valor inválido! Encerrando loop de entrada...");
    }
}
while (entradaValida);

var resultadoConsolidado = new SortedSet<int>(dadosIniciais);

Console.WriteLine();
Console.WriteLine("*** Resultado consolidado ***");
Console.WriteLine();
Console.Write("[  ");
foreach (var item in resultadoConsolidado)
    Console.Write($"{item}  ");
Console.WriteLine("]");
Console.WriteLine();