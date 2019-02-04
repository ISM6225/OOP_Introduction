using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
  class GraduateStudent : Student, BestPractices
  {
    public string Study()
    {
      return "Completed assignments. Exam week is too close!";
    }

    public string Rest()
    {
      return "Late to bed, no time to rest";
    }
  }
}