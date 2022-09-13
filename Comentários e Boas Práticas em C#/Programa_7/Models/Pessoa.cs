using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// <---- Aula - Comentando nossas classes ---->
namespace Programa_7.Models
{
  /// <summary>
  /// Representa uma pessoa física
  /// </summary>
    public class Pessoa
  {
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
      {
        Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
      }
  }
}