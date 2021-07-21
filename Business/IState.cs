using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Business {
  interface IState {
    string Name { get; }
    void PressPoweBtn();
    void PressSleepBtn();
    void PressHibernateBtn();
  }
}
