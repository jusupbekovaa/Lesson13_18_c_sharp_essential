using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17_2
{
    class Car
    {
        string firm;
        string model;
        int year;
        string color;
        public string Firm
        {
            get { return firm; }
            set { firm = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
