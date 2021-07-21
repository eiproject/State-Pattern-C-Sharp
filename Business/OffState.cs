using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Models;

namespace StatePattern.Business {
  class OffState : IState {
    private Laptop _laptop;
    internal OffState(Laptop laptop) {
      _laptop = laptop;
    }
    void IState.battery() {
      Console.WriteLine("No power consumption");
    }

    void IState.display() {
      Console.WriteLine("Display off");
    }

    void IState.hardisk() {
      Console.WriteLine("Hardisk off");
    }

    void IState.keyboard() {
      Console.WriteLine("Keyboard off");
    }

    void IState.memory() {
      Console.WriteLine("Memory off");
    }

    void IState.touchpad() {
      Console.WriteLine("Touchpad off");
    }
  }
}
