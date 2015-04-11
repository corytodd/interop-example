using System.Windows;
using System.Windows.Controls;

namespace WrapConsumer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MainWindowController controller;

        public MainWindow()
        {
            // Setup controller before we initialize the UI
            controller = new MainWindowController(this);

            // Model is an IPropertyChangeNotifier which the controller handles.
            DataContext = controller.Model;

            InitializeComponent();
        }

        #region Boring Focus Change Event Stuff
        /// <summary>
        /// Highlight all text when we tab into textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textFocus_Event(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            focusOn(sender as Control);
        }

        /// <summary>
        /// Highlight all text when we click into textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textFocus_Event(object sender, System.Windows.Input.MouseEventArgs e)
        {
            focusOn(sender as Control);
        }

        /// <summary>
        /// Perform the actual select all
        /// </summary>
        /// <param name="control"></param>
        private void focusOn(Control control)
        {
            if(control is TextBox)
                (control as TextBox).SelectAll();
        }      
        #endregion
    }
}
