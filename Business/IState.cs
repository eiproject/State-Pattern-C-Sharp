using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Business {
  interface IState {
    string Name { get; }
    void PressPowerBtn();
    void PressSleepBtn();
    void PressHibernateBtn();
  }
}
