
namespace CountDownTimer.Commands
{
    internal class MinimizeCommand : BaseCommand
    {
        public override void Execute(object? parameter)
        {
            MainWindow mainWindow = (MainWindow)parameter;

            mainWindow.WindowState = System.Windows.WindowState.Minimized;
        }
    }
}
// EOF