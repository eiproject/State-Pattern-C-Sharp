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
    string IState.Name { get { return "HIBERNATE"; } }

    void IState.PressSleepBtn() {
      Console.WriteLine("Can't move from hibernate to sleep.");
    }

    void IState.PressHibernateBtn() {
      Console.WriteLine("Already in hibernate state, now waking up!");
      _laptop.SetState(_laptop.GetOnState());
    }

    void IState.PressPoweBtn() {
      Console.WriteLine("Laptop waking up from hibernate!");
      _laptop.SetState(_laptop.GetOnState());
    }
  }
}
