
namespace WrapConsumer
{
    class MainWindowController
    {
        private readonly MainWindow mainWindow;

        public MainWindowController(MainWindow parent)
        {
            mainWindow = parent;
            Model = new MathModel();
        }

        public MathModel Model { get; private set; }

    }
}
