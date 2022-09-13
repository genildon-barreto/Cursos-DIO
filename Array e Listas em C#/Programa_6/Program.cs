// /*
// <---- Aula - Trabalhando com listas ---->
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("RJ");
Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");
Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("PE");
Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("PR");
Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("PB");
Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");
Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


Console.WriteLine("Percorrendo a lista com o FOR");
for (int contador = 0; contador < listaString.Count ; contador++) 
{
	Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com o FOREACH");
int contadorForEach = 0;
foreach (string item in listaString) 
{
	Console.WriteLine($"Posição N° {contadorForEach} - {item}");
	contadorForEach++;
}

// */




/*
// <---- Aula - Copiando um Array para outro ---->
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
  Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}
*/




/*
// <---- Aula - Redimensionando um Array ---->
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
  Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}
*/




/*
// <---- Aula - Perconrrendo um Array com FOREACH ---->
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;


Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
  Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}


Console.WriteLine("Percorrendo o Array com o FOREACH");
int contadorForEach = 0;
foreach(int valor in arrayInteiros)
{
	Console.WriteLine($"Posição N° {contadorForEach} - {valor}");
	contadorForEach++;
}
*/




/*
// <---- Aula - Implementando um Array de inteiros ---->
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;


Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
  Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}
*/