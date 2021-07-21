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

    void IState.PressSleepBtn() {
      Console.WriteLine("Can't move from hibernate to sleep, laptop wake up!");
    }

    void IState.PressHibernateBtn() {
      Console.WriteLine("Already in hibernate state");
    }

    void IState.PressPoweBtn() {
      Console.WriteLine("Laptop wake up from hibernate!");
    }
  }
}
