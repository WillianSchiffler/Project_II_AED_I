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
    private double pontos; //soma de pontos;
    private cadast usuario;
    private List<string> roupas = new List<string>();
    private List<string> brinquedos = new List<string>();
    private List<double> alimentos = new List<double>();

    public doacao(cadast u){
      pontos = u.ver_credito();
      usuario = u;
    }

    public void roupa(){
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
      Console.WriteLine("Qual o genero: M ou F");
      genero = Console.ReadLine();
      brinquedos.Add(genero);

      pontos = pontos + 50;

      usuario.add_credito(pontos);

      Console.WriteLine("Doação ralizada com sucesso!");
    }

    public void alimento(){
      Console.WriteLine("Qual o peso do alimento?");
      peso = double.Parse(Console.ReadLine());
      alimentos.Add(peso);

      pontos = pontos + (50*peso);

      usuario.add_credito(pontos);

      Console.WriteLine("Doação ralizada com sucesso!");
    }

    public void registrar_doacao(){
      StreamWriter w_dados_doacao = File.AppendText("dados_doacao.txt");

      w_dados_doacao.WriteLine("Roupas:");
      for(int i=0; i<roupas.Count; i=i+3){
        w_dados_doacao.WriteLine("{0}:{1}:{2}", roupas[i], roupas[i+1], roupas[i+2]);
      }
      w_dados_doacao.WriteLine("#######");
      
      w_dados_doacao.WriteLine("Brinquedos:"); 
      foreach(string brinq in brinquedos){
        w_dados_doacao.WriteLine(brinq);
      }
      w_dados_doacao.WriteLine("#######");

      w_dados_doacao.WriteLine("Alimentos:");
      for(int k=0; k<alimentos.Count; k++){
        w_dados_doacao.WriteLine(alimentos[k]);
      }
      w_dados_doacao.WriteLine("#######");

    w_dados_doacao.Close(); 
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