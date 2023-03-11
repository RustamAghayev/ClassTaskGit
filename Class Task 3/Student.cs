using System.Runtime.CompilerServices;

namespace RustamAghayevTask3
{
    internal class Student
    {
        public string name;
        public string surname;
        public string speciality;
        public string groupNo;
        public int age;

        public override string ToString()
        {
          return ($"{name}{surname}{speciality}{groupNo}{age}");
        }
    }
}       