using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Models;

namespace StatePattern.Business {
  class SleepState : IState{
    private Laptop _laptop;
    internal SleepState(Laptop laptop) {
      _laptop = laptop;
    }
    void IState.battery() {
      Console.WriteLine("Low power consumption");
    }

    void IState.display() {
      Console.WriteLine("Display standby");
    }

    void IState.hardisk() {
      Console.WriteLine("Hardisk standby");
    }

    void IState.keyboard() {
      Console.WriteLine("Keyboard standby");
    }

    void IState.memory() {
      Console.WriteLine("Memory on");
    }

    void IState.touchpad() {
      Console.WriteLine("Touchpad standby");
    }
  }
}
