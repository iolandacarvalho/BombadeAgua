// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int largura = 50;
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("=".PadLeft(23,'='));
Console.WriteLine("- Repositório de Água -");
Console.WriteLine("=".PadLeft(23,'='));
Console.ResetColor();
Console.Write("\n");

return1:
Console.WriteLine("Qual a situação da boia A?\n(1 - cheio | 0 - Vazio)");
Console.Write("R: ");
int bA = int.Parse(Console.ReadLine());
Console.WriteLine("\nQual a situação da boia B?\n(1 - cheio | 0 - Vazio)");
Console.Write("R: ");
int bB = int.Parse(Console.ReadLine());
Console.WriteLine("\nQual a situação da boia C?\n(1 - cheio | 0 - Vazio)");
Console.Write("R: ");
int bC = int.Parse(Console.ReadLine());

Console.WriteLine("=".PadLeft(32,'='));

if (bA == 0 && bB == 0 && bC == 0)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n= Torneira ligada =");
    Console.ResetColor();
    Console.WriteLine("- aguarde o reservatório se encher -");
    Thread.Sleep(3000);
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n|| Boia A cheia ||\n");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("= Torneira ligada =");
    Console.WriteLine("= Bomba ligada =");
    Console.ResetColor();   
    Thread.Sleep(3000);
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n|| Boia B cheia ||\n");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("= Torneira desligada =");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("= Bomba ligada =");
    Console.ResetColor();
    Thread.Sleep(3000);
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n|| Boia C cheia ||\n");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("= Torneira desligada =");
    Console.WriteLine("= Bomba desligada =");
    Console.ResetColor();
}
else if (bA == 0 && bB == 0 && bC == 1)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n= Torneira ligada =");
    Console.ResetColor();
    Console.WriteLine("- aguarde o reservatório se encher -");
    Thread.Sleep(3000);
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n|| Boia A cheia ||\n");
    Thread.Sleep(3000);
    Console.WriteLine("\n|| Boia B cheia ||\n");
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("= Torneira desligada =");
    Console.ResetColor();
}
else if (bA == 0 && bB == 1 && bC == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n");
    Console.WriteLine("!".PadLeft(48,'!'));
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("---------------------- ERRO --------------------");
    Console.WriteLine("- solicite um técnico para resolver o problema -");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("!".PadLeft(48,'!'));
    Console.ResetColor();
}
else if (bA == 0 && bB == 1 && bC == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n");
    Console.WriteLine("!".PadLeft(48,'!'));
    Console.ResetColor();
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("---------------------- ERRO --------------------");
    Console.WriteLine("- solicite um técnico para resolver o problema -");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("!".PadLeft(48,'!'));
    Console.ResetColor();
}
else if (bA == 1 && bB == 0 && bC == 0)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n= Bomba ligada =");
    Console.WriteLine("= Torneira ligada =");
    Console.ResetColor(); 
    Thread.Sleep(3000);
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n|| Boia B cheia ||\n");
    Thread.Sleep(1500);
    Console.WriteLine("|| Boia C cheia ||\n");
    Console.ResetColor();
}
else if (bA == 1 && bB == 0 && bC == 1)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n= Torneira ligada =");
    Console.ResetColor();
    Thread.Sleep(3000);
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n|| Boia B cheia ||\n");
    Console.ResetColor();
}
else if (bA == 1 && bB == 1 && bC == 0)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n= Bomba ligada =");
    Console.ResetColor();
    Thread.Sleep(3000);
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\n|| Boia C cheia ||\n");
    Console.ResetColor();
}
else if (bA == 1 && bB == 1 && bC == 1)
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\n= Torneira desligada =");
    Console.WriteLine("= Bomba desligada =\n");
    Console.ResetColor();
}
else
{
    Console.WriteLine("\n-Valor inválido. Informe novamente.");
    goto return1;
}