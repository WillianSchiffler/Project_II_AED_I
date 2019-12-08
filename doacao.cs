using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

  class doacao{
    private string tamanho; //P, M ou G;
    private string genero; //M ou F;
    private string tipo; //calça, camisa, roupa de frio, bermuda, calçado, vestido; 
    private double peso; //Em Kg;
    private cadast usuario;
    private List<string> roupas;
    private List<string> brinquedos;
    private List<double> alimentos;

    public doacao(cadast u){
      usuario = u;
      roupas = new List<string>();
      brinquedos = new List<string>();
      alimentos = new List<double>();
    }

    public void roupa(){
      Console.WriteLine("Qual o tamanho: P, M ou G");
      tamanho = Console.ReadLine();
      roupas.Add(tamanho);

      Console.WriteLine("Qual o tipo: calça, camisa, bermuda, vestido, etc");
      tipo = Console.ReadLine();
      roupas.Add(tipo);

      Console.WriteLine("Qual o genero: M ou F");
      genero = Console.ReadLine();
      roupas.Add(genero);

      usuario.add_credito(op.add_pont(1,1));

      Console.WriteLine("Doação ralizada com sucesso!");
    }

    public void brinquedo(){
      Console.WriteLine("Qual o genero: M ou F");
      genero = Console.ReadLine();
      brinquedos.Add(genero);

      usuario.add_credito(op.add_pont(2,1));

      Console.WriteLine("Doação ralizada com sucesso!");
    }

    public void alimento(){
      Console.WriteLine("Qual o peso do alimento?");
      peso = double.Parse(Console.ReadLine());
      alimentos.Add(peso);

      usuario.add_credito(op.add_pont(3, peso));

      Console.WriteLine("Doação ralizada com sucesso!");
    }

    public void registrar_doacao(){
      StreamWriter w_dados = File.AppendText("dados_doacao.txt");

      w_dados.WriteLine("Roupas:");
      foreach(string roup in roupas){
        w_dados.WriteLine(roup);
      }
      w_dados.WriteLine("#######");
      
      w_dados.WriteLine("Brinquedos:"); 
      foreach(string brinq in brinquedos){
        w_dados.WriteLine(brinq);
      }
      w_dados.WriteLine("#######");

      w_dados.WriteLine("Alimentos:");
      foreach(double aliment in alimentos){
        w_dados.WriteLine(aliment);
      }
      w_dados.WriteLine("#######");

    w_dados.Close(); 
    }

    public void ver_doacao(){
      StreamReader r_dados_doacao = File.OpenText("dados_doacao.txt");
      string linha = "";

      while ((linha = r_dados_doacao.ReadLine()) != null) {
        Console.WriteLine(linha);
      }
      
      r_dados_doacao.Close();
    }

  }
}