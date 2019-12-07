using System;
using System.Collections.Generic;
using System.IO;

using namespace encap{

  class doacao{
    private char tamanho; //P, M ou G;
    private char genero; //M ou F;
    private string tipo; //calça, camisa, roupa de frio, bermuda, calçado, vestido; 
    private double peso; //Em Kg;

    public doacao(){

    }

    public roupa(string ta, char g, string ti){
      tamanho = ta;
      genero = g;
      tipo = ti;
    }

    public brinquedo(char g){
      genero = g;
    }

    public alimento(double p){
      peso = p;
    }

  }
}