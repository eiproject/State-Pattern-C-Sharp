using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Business {
  interface IState {
    void PressPoweBtn();
    void PressSleepBtn();
    void PressHibernateBtn();
  }
}
