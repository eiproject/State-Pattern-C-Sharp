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
    string IState.Name { get { return "OFF"; } }

    void IState.PressSleepBtn() {
      Console.WriteLine("laptop off!");
    }

    void IState.PressHibernateBtn() {
      Console.WriteLine("Laptop off!");
    }

    void IState.PressPowerBtn() {
      Console.WriteLine("Now, Turning on!");
      _laptop.SetState(_laptop.GetOnState());
    }
  }
}
