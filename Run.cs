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
      _myLaptop.PressPoweBtn();
      _myLaptop.PressSleepBtn();
      _myLaptop.PressPoweBtn();
      _myLaptop.PressHibernateBtn();
      _myLaptop.PressPoweBtn();
      _myLaptop.PressPoweBtn();

    }
  }
}
