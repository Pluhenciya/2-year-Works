using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.Model = model;
            this.view = view;
        }

        internal Student Model { get => model; set => model = value; }

        public void UpdateView()
        {
            view.printStudentDetails(Model.Name, Model.RollNo);
        }
    }
}
