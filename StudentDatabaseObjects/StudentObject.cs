using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDatabase
{
    class Student
    {
        public string Names { get; set; }


        public string HomeTown { get; set; }


        public string FavoriteFood { get; set; }

        public Student(string Names, string HomeTown, string FavoriteFood)
        {
            this.Names = Names;
            this.HomeTown = HomeTown;
            this.FavoriteFood = FavoriteFood;
        }
    }
}