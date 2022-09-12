using Programa_5.Common.Models;

// <---- Aula - Refatorando o menu ---->

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
	Console.Clear();
	Console.WriteLine("Digite a sua opção: ");
	Console.WriteLine("1 - Cadastrar cliente");
	Console.WriteLine("2 - Buscar cliente");
	Console.WriteLine("3 - Apagar cliente");
	Console.WriteLine("4 - Encerrar");

	opcao = Console.ReadLine();

	switch(opcao)
	{
		case "1":
		Console.WriteLine("Cadastro de cliente");
		break;

		case "2":
		Console.WriteLine("Busca de cliente");
		break;

		case "3":
		Console.WriteLine("Apagar cliente");
		break;

		case "4":
		Console.WriteLine("Encerrar");
		exibirMenu = false;
//		Environment.Exit(0);
		break;
	}
}

Console.WriteLine("O programa se encerrou!");



// <---- Aula - Construindo um menu interativo ---->

// string opcao;

// while(true)
// {
// 	Console.Clear();
// 	Console.WriteLine("Digite a sua opção: ");
// 	Console.WriteLine("1 - Cadastrar cliente");
// 	Console.WriteLine("2 - Buscar cliente");
// 	Console.WriteLine("3 - Apagar cliente");
// 	Console.WriteLine("4 - Encerrar");

// 	opcao = Console.ReadLine();

// 	switch(opcao)
// 	{
// 		case "1":
// 		Console.WriteLine("Cadastro de cliente");
// 		break;

// 		case "2":
// 		Console.WriteLine("Busca de cliente");
// 		break;

// 		case "3":
// 		Console.WriteLine("Apagar cliente");
// 		break;

// 		case "4":
// 		Console.WriteLine("Encerrar");
// 		Environment.Exit(0);
// 		break;
// 	}
// }




// <---- Aula - Introdução ao DO WHILE ---->

// int soma = 0, numero = 0;

// do 
// {
// 	Console.WriteLine("Digite um número (0 para parar)");
// 	numero = Convert.ToInt32(Console.ReadLine());
	
// 	soma += numero;
// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");



// <---- Aula - Interrompendo o fluxo de execução ---->
 
// int numero = 5;
// int contador = 0;

// while(contador <= 10)
// {
	// Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
	// contador++;
	
	// if(contador == 6)
		// {
			// break;
		// }
// }


// <---- Aula - Introdução ao WHILE ---->
 
// int numero = 5;
// int contador = 0;

// while(contador <= 10)
// {
	// Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
	// contador++;
// }



// <---- Aula - Introdução ao FOR ---->
 
// int numero = 5;


// for(int contador = 0; contador <= 10; contador++)
// {
	// Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }