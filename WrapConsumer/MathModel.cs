using MathFuncWrapper;
using System;
using System.ComponentModel;

namespace WrapConsumer
{
    class MathModel : INotifyPropertyChanged
    {
        private WrappedMathFunc nativeMath = new WrappedMathFunc();

        private double plus_a = 0;
        private double plus_b = 0;
        private string plus_result = string.Empty;

        private double minus_a = 0;
        private double minus_b = 0;
        private string minus_result = string.Empty;

        private double multiply_a = 0;
        private double multiply_b = 0;
        private string multiply_result = string.Empty; 

        private double divide_a = 0;
        private double divide_b = 1;
        private string divide_result = string.Empty;

        public double Plus_A
        {
            get { return plus_a; }
            set 
            { 
                plus_a = value;
                double val = nativeMath.AddWrapper(Plus_A, Plus_B);
                Plus_Result = String.Format("{0} + {1} = {2}", Plus_A, Plus_B, val);
                OnPropertyChanged("Plus_A"); 
            }
        }

        public double Plus_B
        {
            get { return plus_b; }
            set 
            { 
                plus_b = value;
                double val = nativeMath.AddWrapper(Plus_A, Plus_B);
                Plus_Result = String.Format("{0} + {1} = {2}", Plus_A, Plus_B, val);
                OnPropertyChanged("Plus_B");
            }
        }

        public string Plus_Result
        {
            get { return plus_result; }
            set
            {
                plus_result = value; 
                OnPropertyChanged("Plus_Result");
            }
        }

        public double Minus_A
        {
            get { return minus_a; }
            set
            { 
                minus_a = value;
                double val = nativeMath.SubtractWrapper(Minus_A, Minus_B);
                Minus_Result = String.Format("{0} - {1} = {2}", Minus_A, Minus_A, val);
                OnPropertyChanged("Minus_A");
            }
        }

        public double Minus_B
        {
            get { return minus_b; }
            set 
            { 
                minus_b = value;
                double val = nativeMath.SubtractWrapper(Minus_A, Minus_B);
                Minus_Result = String.Format("{0} - {1} = {2}", Minus_A, Minus_A, val);
                OnPropertyChanged("Minus_B"); 
            }
        }

        public string Minus_Result
        {
            get { return minus_result; }
            set
            {
                minus_result = value; 
                OnPropertyChanged("Minus_Result");
            }
        }

        public double Multiply_A
        {
            get { return multiply_a; }
            set 
            {
                multiply_a = value;
                double val = nativeMath.MultiplyWrapper(Multiply_A, Multiply_B);
                Multiply_Result = String.Format("{0} x {1} = {2}", Multiply_A, Multiply_B, val);
                OnPropertyChanged("Multiply_A"); 
            }
        }

        public double Multiply_B
        {
            get { return multiply_b; }
            set 
            { 
                multiply_b = value;
                double val = nativeMath.MultiplyWrapper(Multiply_A, Multiply_B);
                Multiply_Result = String.Format("{0} x {1} = {2}", Multiply_A, Multiply_B, val);
                OnPropertyChanged("Multiply_B"); 
            }
        }

        public string Multiply_Result
        {
            get { return multiply_result; }
            set
            {
                multiply_result = value;
                OnPropertyChanged("Multiply_Result");
            }
        }

        public double Divide_A
        {
            get { return divide_a; }
            set 
            { 
                divide_a = value;
                double val = nativeMath.DivideWrapper(Divide_A, Divide_B);
                Divide_Result = String.Format("{0} / {1} = {2}", Divide_A, Divide_B, val);
                OnPropertyChanged("Divide_A");
            }
        }


        public double Divide_B
        {
            get { return divide_b; }
            set 
            { 
                divide_b = value;
                double val = nativeMath.DivideWrapper(Divide_A, Divide_B);
                Divide_Result = String.Format("{0} / {1} = {2}", Divide_A, Divide_B, val);
                OnPropertyChanged("Divide_B");
            }
        }

        public string Divide_Result
        {
            get { return divide_result; }
            set
            {
                divide_result = value; 
                OnPropertyChanged("Divide_Result");
            }
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
