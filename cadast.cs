using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

  class cadast{
    private string cpf;
    private double credito;

    public cadast(string c){
      cpf = c;
      credito = 0;
    }

    public void inserir_dados(){
      StreamWriter w_dados = File.AppendText("dados.txt");
      w_dados.WriteLine(cpf);
      w_dados.WriteLine(credito);
      w_dados.WriteLine("#");
      w_dados.Close();     
      }

    public void ver_dados(){
      StreamReader r_dados = File.OpenText("dados.txt");
      string linha = "";
      while ((linha = r_dados.ReadLine()) != null) {
      Console.WriteLine(linha);
    }
      r_dados.Close();
    }

    public double ver_credito(){ //get credito
      return credito;
    }

    public void add_credito(double p){ //set credito
      credito = p;
    }

  }
}