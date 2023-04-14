Console.Write("Quanti cibi vuoi inserire? ");
string[] userCibiPreferiti = new string[int.Parse(Console.ReadLine())];

for(int i = 0; i < userCibiPreferiti.Length; i++)
{
	Console.Write("Cosa vuoi inserire come " + (i + 1) + "° cibo? ");
	string userCibi = Console.ReadLine();
	userCibiPreferiti[i] = userCibi;
}

arrayPrint(userCibiPreferiti);
Console.WriteLine();
elementiMedianaArray(userCibiPreferiti);



//----------FUNZIONI----------------
void elementiMedianaArray(string[] array)
{
	if (array.Length % 2 == 0)
	{
		string elementoArrayASinistra = array[array.Length / 2 - 1];
		string elementoArrayADestra = array[array.Length / 2];

		Console.WriteLine(elementoArrayADestra + elementoArrayASinistra)

	}
	else
	{
		string elementoArrayCentrale = array[array.Length / 2];

		Console.WriteLine(elementoArrayCentrale);
	}
}


string arrayPrint(string[] array)
{
	for (int i=0; i < array.Length; i++)
	{
		Console.WriteLine(array[i]);
	}
}

