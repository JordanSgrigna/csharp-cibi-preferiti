Console.Write("Quanti cibi vuoi inserire? ");
string[] userCibiPreferiti = new string[int.Parse(Console.ReadLine())];

for(int i = 0; i < userCibiPreferiti.Length; i++)
{
	Console.Write("Cosa vuoi inserire come " + (i + 1) + "° cibo? ");
	string userCibi = Console.ReadLine();
	userCibiPreferiti[i] = userCibi;
}




//----------FUNZIONI----------------


