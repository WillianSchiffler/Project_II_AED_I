using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

  class ex{

    public ex(){
    }

    public static void exception(int y){
    if(y == 0){
      throw new Exception();//CPF já registrado;
    } 
  }

    public static void exception2(string s){
    if(s == ""){
      throw new ArgumentNullException();//CPF em branco;
    }
  }

  }
}