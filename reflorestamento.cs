using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

  class reflorestamento{
    private int tipo; //Tipo da vegetação. Árvores, flores ou arbustos;
    private int metros; //Qtd de metros quadrados;
    private int condicao; //Como ficou a condição do lugar: Boa, média ou ruim;
    private int duracao; //Qtd de tempo do projeto, em dias;
    private double pontos; //soma de pontos;
    private cadast usuario;
    
  public reflorestamento(cadast u){
      pontos = u.ver_credito();
      usuario = u;
    }

  public void floresta(){
    Console.WriteLine("Como estava a condição do lugar: 1 - Boa, 2 - média ou 3 - ruim?");
    condicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quanto tempo foi gasto?");
    duracao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantos metros quadrados foi plantado?");
    metros = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual o tipo de vegetação foi plantado? 1 - arbusto, 2 - árvores ou 3 - flores;");
    tipo = int.Parse(Console.ReadLine());

    pontos = pontos + (condicao*10) + (duracao*15) + (tipo*10) + (metros*20);

    usuario.add_credito(pontos);

    Console.WriteLine("Limpeza ralizada com sucesso!");
  }

  public void terreno(){
    Console.WriteLine("Como estava a condição do lugar: 1 - Boa, 2 - média ou 3 - ruim?");
    condicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quanto tempo foi gasto?");
    duracao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantos metros quadrados foi plantado?");
    metros = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual o tipo de vegetação foi plantado? 1 - arbusto, 2 - árvores ou 3 - flores;");
    tipo = int.Parse(Console.ReadLine());

    pontos = pontos + (condicao*20) + (duracao*10) + (tipo*10) + (metros*40);

    usuario.add_credito(pontos);

    Console.WriteLine("Limpeza ralizada com sucesso!");
  }

  public void praca(){
    Console.WriteLine("Como estava a condição do lugar: 1 - Boa, 2 - média ou 3 - ruim?");
    condicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quanto tempo foi gasto?");
    duracao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantos metros quadrados foi plantado?");
    metros = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual o tipo de vegetação foi plantado? 1 - arbusto, 2 - árvores ou 3 - flores;");

    pontos = pontos + (condicao*5) + (duracao*10) + (tipo*20) + (metros*50);

    usuario.add_credito(pontos);

    Console.WriteLine("Limpeza ralizada com sucesso!");
  }

  }
}