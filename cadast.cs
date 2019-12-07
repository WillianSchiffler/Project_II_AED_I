using System;
using System.Collections.Generic;
using System.IO;

namespace encap{

  class cadast{
    private string nome;
    private string cpf;
    private double credito;
    private List<double> soma;

    public cadast(string n, string c){
      nome = n;
      cpf = c;
      credito = 0;
    }

    public void inscricao(){
      /*StreamWriter dados = File.AppendText("dados.txt");
      dados.WriteLine(nome);
      dados.WriteLine(cpf);
      dados.WriteLine("#");
      dados.close();*/
    }

    public double ver_credito(){ //get credito
      return credito;
    }

    public void add_credito(double p){ //set credito
      credito = p;
    }

  }
}