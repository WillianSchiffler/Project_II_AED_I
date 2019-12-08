using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

  class op{
    private static double x = 50;
    private static double y = 100;
    public op(){
    }

    public static double add_pont(double op, double peso){
      if(op == 1){ //ROUPA
        return x;
      }
      if (op == 2){ //BRIQNUEDO
        return y;
      }
      if (op == 3){ //ALIMENTO
        return (75*peso);
      }
      return 0;
    }

  }
}