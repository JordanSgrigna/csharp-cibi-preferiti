Console.Write("Quanti cibi vuoi inserire? ");
string[] userCibiPreferiti = new string[int.Parse(Console.ReadLine())];

for(int i = 0; i < userCibiPreferiti.Length; i++)
{
	Console.Write("Cosa vuoi inserire come " + (i + 1) + "° cibo? ");
	string userCibi = Console.ReadLine();
	userCibiPreferiti[i] = userCibi;
}

Console.WriteLine();
arrayPrint(userCibiPreferiti);
Console.WriteLine();
string elementiMediani = elementiMedianaArray(userCibiPreferiti);
Console.WriteLine(elementiMediani);



//----------FUNZIONI----------------
string elementiMedianaArray(string[] array)
{
	string result;

	if (array.Length % 2 == 0)
	{
		string elementoArrayASinistra = array[array.Length / 2 - 1];
		string elementoArrayADestra = array[array.Length / 2];

		result = elementoArrayADestra + " " + elementoArrayASinistra;

	}
	else
	{
		string elementoArrayCentrale = array[array.Length / 2];

		result = elementoArrayCentrale;


	}

	return result;
}


void arrayPrint(string[] array)
{
	for (int i=0; i < array.Length; i++)
	{
		Console.WriteLine(array[i]);
	}
}

