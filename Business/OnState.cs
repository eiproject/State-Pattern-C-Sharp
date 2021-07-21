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

    void IState.PressSleepBtn() {
      Console.WriteLine("Going to sleep. Please wait...");
    }

    void IState.PressHibernateBtn() {
      Console.WriteLine("Going to hibernate. Please wait...");
    }

    void IState.PressPoweBtn() {
      Console.WriteLine("Turning off!");
    }
  }
}
