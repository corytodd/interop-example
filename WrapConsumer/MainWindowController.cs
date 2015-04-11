using MathFuncWrapper;
using System;

namespace WrapConsumer
{
    class MainWindowController
    {
        private readonly MainWindow mainWindow;
        private WrappedMathFunc nativeMath = new WrappedMathFunc();

        public MainWindowController(MainWindow parent)
        {
            mainWindow = parent;
            Model = new MathModel();
            Model.PropertyChanged += model_PropertyChanged;
        }

        public MathModel Model { get; private set; }


        private void model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var r = nativeMath.AddWrapper(Model.Plus_A, Model.Plus_B);
            mainWindow.plus_result.Content = String.Format("{0} + {1} = {2}",
                mainWindow.plus_a.Text, mainWindow.plus_b.Text, r);

            r = nativeMath.SubtractWrapper(Model.Minus_A, Model.Minus_B);
            mainWindow.minus_result.Content = String.Format("{0} - {1} = {2}",
                mainWindow.minus_a.Text, mainWindow.minus_b.Text, r);

            r = nativeMath.MultiplyWrapper(Model.Multiply_A, Model.Multiply_B);
            mainWindow.multiply_result.Content = String.Format("{0} x {1} = {2}",
                mainWindow.multiply_a.Text, mainWindow.multiply_b.Text, r);

            r = nativeMath.MultiplyWrapper(Model.Divide_A, Model.Divide_B);
            mainWindow.divide_result.Content = String.Format("{0}  / {1} = {2}",
                mainWindow.divide_a.Text, mainWindow.divide_b.Text, r);
        }

    }
}
