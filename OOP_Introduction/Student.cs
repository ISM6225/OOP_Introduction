using System;

namespace OOP_Introduction
{
  class Student : Person
  {
    public string studentNumber;
    public Person Advisor;

    /// <summary>
    /// Default constructor attempt 1
    /// </summary>
    public Student()
    {
      studentNumber = "U1234";
      lastName = "Doe";
    }

    /// <summary>
    /// Default constructor that uses inheritance
    /// </summary>
    //public Student() : base()
    //{
    //  studentNumber = "U1234";
    //}
  }
}
