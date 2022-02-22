using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonExercise
{
    class Person
    {
        public Person(string naam, int age){
            this.Name = naam;
            this.Age = age;
        }

        private string name;
        public string Name {
            get {
                return name;
            }
            set {
                if(string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("naam mag niet leeg zijn");
                }
                name = value;
            }
        }

        private int age;
        public int Age {
            get {
                return age;
            }
            set {
                if (value < 0) {
                    throw new ArgumentException("Leeftijd moet positief zijn");
                }
                age = value;
            }
        }
    }
}
