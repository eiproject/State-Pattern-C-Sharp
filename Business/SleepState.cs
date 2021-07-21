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

    void IState.PressSleepBtn() {
      Console.WriteLine("Already sleep, now waking up!");
    }

    void IState.PressHibernateBtn() {
      Console.WriteLine("Can't move from sleep to hibernate");
    }

    void IState.PressPoweBtn() {
      Console.WriteLine("Waking up!");
    }
  }
}
