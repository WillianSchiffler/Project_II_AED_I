using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

  class limpeza{
    private double tempo; //Qtd de horas gastas;
    private int condicao; //Como estava a condição do lugar: Boa, média ou ruim;
    private int ajuda; //Qtd de pessoas que levou pra ajudar;
    private double pontos; //soma de pontos;
    private cadast usuario;
    
  public limpeza(cadast u){
      pontos = u.ver_credito();
      usuario = u;
    }

  public void praia(){
    Console.WriteLine("Como estava a condição do lugar: 1 - Boa, 2 - média ou 3 - ruim?");
    condicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quanto tempo foi gasto? t em horas");
    tempo = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantas pessoas levou para ajudar? número inteiro por favor");
    ajuda = int.Parse(Console.ReadLine());

    pontos = pontos + (condicao*10) + (tempo*15) + (ajuda*50);

    usuario.add_credito(pontos);

    Console.WriteLine("Limpeza ralizada com sucesso!");
  }

  public void praca(){
    Console.WriteLine("Como estava a condição do lugar: 1 - Boa, 2 - média ou 3 - ruim?");
    condicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quanto tempo foi gasto? t em horas");
    tempo = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantas pessoas levou para ajudar? número inteiro por favor");
    ajuda = int.Parse(Console.ReadLine());

    pontos = pontos + (condicao*5) + (tempo*10) + (ajuda*20);

    usuario.add_credito(pontos);

    Console.WriteLine("Limpeza ralizada com sucesso!");
  }

  public void terreno(){
    Console.WriteLine("Como estava a condição do lugar: 1 - Boa, 2 - média ou 3 - ruim?");
    condicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Quanto tempo foi gasto? t em horas");
    tempo = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantas pessoas levou para ajudar? número inteiro por favor");
    ajuda = int.Parse(Console.ReadLine());

    pontos = pontos + (condicao*10) + (tempo*20) + (ajuda*35);

    usuario.add_credito(pontos);

    Console.WriteLine("Limpeza ralizada com sucesso!");
  }

  }
}