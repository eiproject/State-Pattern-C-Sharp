using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Business {
  interface IState {
    void battery();
    void keyboard();
    void display();
    void touchpad();
    void hardisk();
    void memory();
  }
}
