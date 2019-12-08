using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace encap{

  class cupom{

  public cupom(){
  }

  public static string cup(){
    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    var random = new Random();
    var result = new string(
        Enumerable.Repeat(chars, 7)
                  .Select(s => s[random.Next(s.Length)])
                  .ToArray());
  return result;
}

}
}