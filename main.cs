using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

class MainClass {
  public static void Main () {
    int opt, opt2, opt3, aux = 1;;
    string cpf;

    Console.WriteLine("Qual seu cpf? Sem pontos");
    cpf = Console.ReadLine();

    StreamReader r_cpf = File.OpenText("dados.txt");
    string linha = "";
    while ((linha = r_cpf.ReadLine()) != null) {
      if(cpf == linha){
        aux = 2;
      }    
    }
    r_cpf.Close();

    if(aux == 2){
      Console.WriteLine("cpf já cadastrado");
    }
    else{
    cadast novo_usuario = new cadast(cpf);
    troca new_troca = new troca(novo_usuario);
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Participar do voluntariado;");
    Console.WriteLine("2 - Ver quantidade de créditos;");
    Console.WriteLine("3 - Trocar;");
    Console.WriteLine("4 - Ver dados cadastrados;");
    Console.WriteLine("5 - Ver cupons;");
    Console.WriteLine("6 - Sair;");
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
        Console.WriteLine("O que deseja doar? 1 - roupa; 2 - brinquedo; 3 - alimento; 4 - Ver doações;");
        opt3 = int.Parse(Console.ReadLine());
        
        if(opt3 == 1){
          new_doacao.roupa();
        }
        else if(opt3 == 2){
          new_doacao.brinquedo();
        }
        else if(opt3 == 3){
          new_doacao.alimento();
        }
        else if(opt3 == 4){
          new_doacao.registrar_doacao();
          new_doacao.ver_doacao();
        }
        else{
          Console.WriteLine("Opção inválida!");
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
        new_troca.trocar();
        break;

        case 4:
        novo_usuario.inserir_dados();
        novo_usuario.ver_dados();
        break;

        case 5:
        new_troca.escrever_cupom();
        new_troca.ler_cupom();
        break;

        default:
        Console.WriteLine("Opcao inválida!");
        break;
      }

      Console.WriteLine("O que deseja fazer?"); 
      Console.WriteLine("1 - Participar do voluntariado;");
      Console.WriteLine("2 - Ver quantidade de créditos;");
      Console.WriteLine("3 - Trocar;");
      Console.WriteLine("4 - Ver dados cadastrados;");
      Console.WriteLine("5 - Ver cupons;");
      Console.WriteLine("6 - Sair;");
      opt = int.Parse(Console.ReadLine());

    }while(opt>=1 && opt<=5);
    Console.WriteLine("Programa finalizado!");
  }
}
}
}