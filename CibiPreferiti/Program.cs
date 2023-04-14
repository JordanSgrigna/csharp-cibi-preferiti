string[] cibiPreferiti = { "Patatine fritte", "Carne", "Gelato", "Formaggio", "Verdura", "Frutta" };

Console.WriteLine(findArrayLength(cibiPreferiti));
Console.WriteLine();
classificaArray(cibiPreferiti);
Console.WriteLine();
Console.WriteLine(firstElementInArray(cibiPreferiti));
Console.WriteLine();
Console.WriteLine(lastElementInArray(cibiPreferiti));






//----------------- FUNZIONI -------------------

//Funzione per trovare la lunghezza di un array

int findArrayLength(string[] array)
{
	int arrayLength = array.Length;
	return arrayLength;
};

//Classifica Array

void classificaArray(string[] array) 
{
	for(int i = 0; i < array.Length; i++)
	{
		Console.WriteLine((i + 1) + "° - " + array[i]);
	}
}

//Primo elemento di un array

string firstElementInArray(string[] array)
{
	string firstElement = array[0];
	return firstElement;
}

//Ultimo elemento di un array
string lastElementInArray(string[] array)
{
	string lastElement = array[array.Length - 1];
	return lastElement;
}

