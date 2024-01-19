
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string mensagem = "";
decimal total = 0m;

foreach(var valor in values)
{
    decimal numero;
    if(decimal.TryParse(valor, out numero))
    {
        total += numero;
    }
    else
    {
        mensagem += valor;
    }
}
Console.WriteLine($"Message: {mensagem}");
Console.WriteLine($"Total: {total}");

