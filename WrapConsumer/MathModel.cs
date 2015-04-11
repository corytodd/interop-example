using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapConsumer
{
    class MathModel : INotifyPropertyChanged
    {
        private double plus_a = 42;
        private double plus_b = 42;

        private double minus_a = 42;
        private double minus_b = 42;

        private double multiply_a = 42;
        private double multiply_b = 42;

        private double divide_a = 42;
        private double divide_b = 42;


        public double Plus_A
        {
            get { return plus_a; }
            set { plus_a = value; OnPropertyChanged("Plus_A"); }
        }

        public double Plus_B
        {
            get { return plus_b; }
            set { plus_b = value; OnPropertyChanged("Plus_B"); }
        }

        public double Minus_A
        {
            get { return minus_a; }
            set { minus_a = value; OnPropertyChanged("Minus_A"); }
        }

        public double Minus_B
        {
            get { return minus_b; }
            set { minus_b = value; OnPropertyChanged("Minus_B"); }
        }


        public double Multiply_A
        {
            get { return multiply_a; }
            set { multiply_a = value; OnPropertyChanged("Multiply_A"); }
        }


        public double Multiply_B
        {
            get { return multiply_b; }
            set { multiply_b = value; OnPropertyChanged("Multiply_B"); }
        }


        public double Divide_A
        {
            get { return divide_a; }
            set { divide_a = value; OnPropertyChanged("Divide_A"); }
        }


        public double Divide_B
        {
            get { return divide_b; }
            set { divide_b = value; OnPropertyChanged("Divide_B"); }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
