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

    void IState.PressSleepBtn() {
      Console.WriteLine("laptop off!");
    }

    void IState.PressHibernateBtn() {
      Console.WriteLine("Laptop off!");
    }

    void IState.PressPoweBtn() {
      Console.WriteLine("Turning on!");
    }
  }
}
