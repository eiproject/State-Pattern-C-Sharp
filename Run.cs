using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.Models;

namespace StatePattern {
  class Run {
    Laptop _myLaptop;
    internal Run() {
      Laptop newLaptop = new Laptop("Acer");
      _myLaptop = newLaptop;
    }

    internal void Start() {
      _myLaptop.PressPowerBtn();
      _myLaptop.PressSleepBtn();
      _myLaptop.PressPowerBtn();
      _myLaptop.PressHibernateBtn();
      _myLaptop.PressPowerBtn();
      _myLaptop.PressPowerBtn();

    }
  }
}
