using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Introduction
{
  class UndergraduateStudent : Student, BestPractices
  {
    public string Study()
    {
      return "Great party last night. All set for the exam!";
    }

    public string Rest()
    {
      return "Great friends, great movies, great parties. Well rested";
    }
  }
}