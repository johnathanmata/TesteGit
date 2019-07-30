using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio {
    class Employee {
        private int _id;
        private string _name;
        private double _salary;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public double Salary { get => _salary; set => _salary = value; }

        public void UpdateSalary(double percent) {
            this._salary *= (1.0 + (percent / 100));
        }

        public override string ToString() {
            return Id + " | " + Name + " | " + Salary;
        }
    }
}
