using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

  class troca{
  private cadast usuario;
  private int opt4, opt5;
  private double pontos;
  private string cod_cupom = "";
  private List<string> cupons_celular = new List<string>();
  private List<string> cupons_ifood = new List<string>();
  private List<string> cupons_uber = new List<string>();
  
  public troca(cadast u){
    pontos = u.ver_credito();
    usuario = u;
  }

  public void trocar(){
  Console.WriteLine("Pelo que deseja trocar seus pontos?");
  Console.WriteLine("1 - crédito do celular;");
  Console.WriteLine("2 - Ifood;");
  Console.WriteLine("3 - Uber;");
  opt4 = int.Parse(Console.ReadLine());

  switch(opt4){
    case 1:
    Console.WriteLine("Crédito para celular vai debitar 1000 pts. Tem certeza? 1 - sim; 2 - não");
    opt5 = int.Parse(Console.ReadLine());

    if(opt5 == 1){
      if(pontos >= 1000){
      pontos = pontos - 1000;
      usuario.add_credito(pontos);
      Console.WriteLine("Troca aprovada! Anote seu cupom...");
      cod_cupom = cupom.cup();
      Console.WriteLine("celular: {0}", cod_cupom);
      cupons_celular.Add(cod_cupom);
      }
      else {
        Console.WriteLine("Créditos insuficientes!");
      }
    }
    break;

    case 2:
    Console.WriteLine("Ifood vai debitar 2000 pts. Tem certeza? 1 - sim; 2 - não");
    opt5 = int.Parse(Console.ReadLine());

    if(opt5 == 1){
      if(pontos >= 2000){
      pontos = pontos - 2000;
      usuario.add_credito(pontos);
      Console.WriteLine("Troca aprovada! Anote seu cupom...");
      cod_cupom = cupom.cup();
      Console.WriteLine("celular: {0}", cod_cupom);
      cupons_ifood.Add(cod_cupom);
      }
      else {
        Console.WriteLine("Créditos insuficientes!");
      }
    }
    break;

    case 3:
    Console.WriteLine("Uber vai debitar 2500 pts. Tem certeza? 1 - sim; 2 - não");
    opt5 = int.Parse(Console.ReadLine());

    if(opt5 == 1){
      if(pontos >= 2500){
      pontos = pontos - 2500;
      usuario.add_credito(pontos);
      Console.WriteLine("Troca aprovada! Anote seu cupom...");
      cod_cupom = cupom.cup();
      Console.WriteLine("celular: {0}", cod_cupom);
      cupons_uber.Add(cod_cupom);
      }
      else {
        Console.WriteLine("Créditos insuficientes!");
      }
    }
    break;

    default:
    Console.WriteLine("Opção inválida!");
    break;
  }
  }

    public void escrever_cupom(){
      StreamWriter w_dados_troca = File.AppendText("dados_troca.txt");

      w_dados_troca.WriteLine("Celular:");
      for(int i=0; i<cupons_celular.Count; i++){
        w_dados_troca.WriteLine(cupons_celular[i]);
      }
      w_dados_troca.WriteLine("#######");
      
      w_dados_troca.WriteLine("Ifood:");
      for(int i=0; i<cupons_ifood.Count; i++){
        w_dados_troca.WriteLine(cupons_ifood[i]);
      }
      w_dados_troca.WriteLine("#######");

      w_dados_troca.WriteLine("Uber:");
      for(int i=0; i<cupons_uber.Count; i++){
        w_dados_troca.WriteLine(cupons_uber[i]);
      }
      w_dados_troca.WriteLine("#######");

    w_dados_troca.Close();
    }

    public void ler_cupom(){
      StreamReader r_dados_troca = File.OpenText("dados_troca.txt");
      string linha = "";
      while ((linha = r_dados_troca.ReadLine()) != null) {
      Console.WriteLine(linha);
    }
      r_dados_troca.Close();
    }

  }
  }
  