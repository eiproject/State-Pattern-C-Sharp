using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern {
  class Laptop {
    private string _type;
    private string _nowsState;
    internal Laptop(string type) {
      _type = type;
    }
  }
}
