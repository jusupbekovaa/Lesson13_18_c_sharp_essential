using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15_2
{
    struct Worker
    {
        string surname;
        string name;
        string position;
        int year;
        public string Surname
        {
            get { return surname; }                                                                                                                             
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        

    }
}
