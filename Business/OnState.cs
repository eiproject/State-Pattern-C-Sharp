using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Models;

namespace StatePattern.Business {
  class OnState : IState {
    private Laptop _laptop;
    internal OnState(Laptop laptop) {
      _laptop = laptop;
    }
    void IState.battery() {
      Console.WriteLine("Normal power consumption");
    }

    void IState.display() {
      Console.WriteLine("Display on");
    }

    void IState.hardisk() {
      Console.WriteLine("Hardisk on");
    }

    void IState.keyboard() {
      Console.WriteLine("Keyboard on");
    }

    void IState.memory() {
      Console.WriteLine("Memory on");
    }

    void IState.touchpad() {
      Console.WriteLine("Touchpad on");
    }
  }
}
