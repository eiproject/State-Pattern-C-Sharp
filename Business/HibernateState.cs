using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Models;

namespace StatePattern.Business {
  class HibernateState : IState {
    private Laptop _laptop;
    internal HibernateState(Laptop laptop) {
      _laptop = laptop;
    }
    void IState.battery() {
      Console.WriteLine("Lesser power consumption");
    }

    void IState.display() {
      Console.WriteLine("Display off");
    }

    void IState.hardisk() {
      Console.WriteLine("Hardisk off");
    }

    void IState.keyboard() {
      Console.WriteLine("Keyboard standby");
    }

    void IState.memory() {
      Console.WriteLine("Memory on");
    }

    void IState.touchpad() {
      Console.WriteLine("Touchpad off");
    }
  }
}
