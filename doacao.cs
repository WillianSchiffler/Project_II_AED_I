using System;
using System.Collections.Generic;
using System.IO;

namespace encap{

  class doacao{
    private string tamanho; //P, M ou G;
    private string genero; //M ou F;
    private string tipo; //calça, camisa, roupa de frio, bermuda, calçado, vestido; 
    private double peso; //Em Kg;
    private double pontos; //soma de pontos;
    private cadast usuario;
    private List<string> roupas;
    private List<string> brinquedos;
    private List<double> alimentos;

    public doacao(cadast u){
      pontos = u.ver_credito();
      usuario = u;
    }

    public void roupa(){
      roupas = new List<string>();
      Console.WriteLine("Qual o tamanho: P, M ou G");
      tamanho = Console.ReadLine();
      Console.WriteLine("Qual o tipo: calça, camisa, bermuda, vestido, etc");
      tipo = Console.ReadLine();
      Console.WriteLine("Qual o genero: M ou F");
      genero = Console.ReadLine();
      roupas.Add(tamanho);
      roupas.Add(tipo);
      roupas.Add(genero);

      pontos = pontos + 100;

      usuario.add_credito(pontos);

      Console.WriteLine("Doação ralizada com sucesso!");
    }

    public void brinquedo(){
      brinquedos = new List<string>();
      Console.WriteLine("Qual o genero: M ou F");
      genero = Console.ReadLine();
      brinquedos.Add(genero);

      pontos = pontos + 50;

      usuario.add_credito(pontos);

      Console.WriteLine("Doação ralizada com sucesso!");
    }

    public void alimento(){
      alimentos = new List<double>();
      Console.WriteLine("Qual o peso do alimento?");
      peso = double.Parse(Console.ReadLine());
      alimentos.Add(peso);

      pontos = pontos + (50*peso);

      usuario.add_credito(pontos);

      Console.WriteLine("Doação ralizada com sucesso!");
    }

  }
}