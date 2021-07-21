using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Business;

namespace StatePattern.Models {
  class Laptop {
    private IState _off;
    private IState _on;
    private IState _sleep;
    private IState _hibernate;
    
    private string _type;
    private string _nowsState;
    private IState _state;
    internal Laptop(string type) {
      _type = type;

      _off = new OffState(this);
      _on = new OnState(this);
      _sleep = new SleepState(this);
      _hibernate = new HibernateState(this);
    }

    internal void SetState(IState state) {
      _state = state;
    }
    internal IState GetOffState() {
      return _off;
    }
    internal IState GetOnState() {
      return _on;
    }
    internal IState GetSleepState() {
      return _sleep;
    }
    internal IState GetHibernateState() {
      return _hibernate;
    }
  }
}
