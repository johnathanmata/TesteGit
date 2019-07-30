using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio {
    class Employee {
        private int id;
        private string name;
        private double salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public void UpdateSalary(double percent) {
            this.salary *= (1.0 + (percent / 100));
        }

        public override string ToString() {
            return Id + " | " + Name + " | " + Salary;
        }
    }
}
