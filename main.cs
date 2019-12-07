using System;
using System.Collections.Generic;
using System.IO;

namespace encap{

class MainClass {
  public static void Main () {
    int opt, opt2;
    string nome, cpf;
    Console.WriteLine("Qual seu nome?");
    nome = Console.ReadLine();
    Console.WriteLine("Qual seu 3? Sem pontos");
    cpf = Console.ReadLine();
    cadast novo_usuario = new cadast(nome, cpf);
    
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Participar do voluntariado;");
    Console.WriteLine("2 - Ver quantidade de créditos;");
    Console.WriteLine("3 - Ver cupons;");
    Console.WriteLine("4 - Sair;");
    opt = int.Parse(Console.ReadLine());

    do{
      switch(opt){
        case 1:
          Console.WriteLine("O que deseja fazer?");
          Console.WriteLine("1 - Doação;");
          Console.WriteLine("2 - Limpeza;");
          Console.WriteLine("3 - Reflorestamento;");

        opt2 = int.Parse(Console.ReadLine());

        switch(opt2){
        case 1:
        doacao new_doacao = new doacao(novo_usuario);
        Console.WriteLine("O que deseja doar? 1 - roupa; 2 - brinquedo; 3 - alimento;");
        
        if(int.Parse(Console.ReadLine()) == 1){
          new_doacao.roupa();
        }
        else if(int.Parse(Console.ReadLine()) == 2){
          new_doacao.brinquedo();
        }
        else if(int.Parse(Console.ReadLine()) == 3){
          new_doacao.alimento();
        }
        else{
          Console.WriteLine("Opcao inválida!");
        }
        break;

        case 2:
        limpeza new_limpeza = new limpeza(novo_usuario);
        Console.WriteLine("O que deseja doar? 1 - praia; 2 - praca; 3 - terreno baldio;");

        if(int.Parse(Console.ReadLine()) == 1){
          new_limpeza.praia();
        }
        else if(int.Parse(Console.ReadLine()) == 2){
          new_limpeza.praca();
        }
        else if(int.Parse(Console.ReadLine()) == 3){
          new_limpeza.terreno();
        }
        else{
          Console.WriteLine("Opcao inválida!");
        }
        break;

        case 3:
        reflorestamento new_reflorestamento = new reflorestamento(novo_usuario);
        Console.WriteLine("O que deseja doar? 1 - floresta; 2 - praca; 3 - terreno baldio;");

        if(int.Parse(Console.ReadLine()) == 1){
          new_reflorestamento.terreno();
        }
        else if(int.Parse(Console.ReadLine()) == 2){
          new_reflorestamento.praca();
        }
        else if(int.Parse(Console.ReadLine()) == 3){
          new_reflorestamento.floresta();
        }
        else{
          Console.WriteLine("Opcao inválida!");
        }
        break;

        default:
        Console.WriteLine("Opcao inválida!");
        break;
        }
        break;

        case 2:
        Console.WriteLine("Quantidade de créditos: {0}", novo_usuario.ver_credito());
        break;
        case 3:
        Console.WriteLine("Opcao inválida!");

        break;
        default:
        Console.WriteLine("Opcao inválida!");
        break;
      }

      Console.WriteLine("O que deseja fazer?"); 
      Console.WriteLine("1 - Participar do voluntariado;");
      Console.WriteLine("2 - Ver quantidade de créditos;");
      Console.WriteLine("3 - Ver cupons;");
      Console.WriteLine("4 - Sair;");
      opt = int.Parse(Console.ReadLine());

    }while(opt>=1 && opt<=4);
    Console.WriteLine("Programa finalizado!");
  }
}
}