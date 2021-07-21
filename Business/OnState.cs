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
    string IState.Name { get { return "ON"; } }

    void IState.PressSleepBtn() {
      Console.WriteLine("Going to sleep. Please wait...");
      _laptop.SetState(_laptop.GetSleepState());
    }

    void IState.PressHibernateBtn() {
      Console.WriteLine("Going to hibernate. Please wait...");
      _laptop.SetState(_laptop.GetHibernateState());
    }

    void IState.PressPoweBtn() {
      Console.WriteLine("Turning off! See you...");
      _laptop.SetState(_laptop.GetOffState());
    }
  }
}
