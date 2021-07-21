using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern {
  interface ILaptopState {
    void battery();
    void keyboard();
    void display();
    void touchpad();
    void hardisk();
    void memory();
  }
}
