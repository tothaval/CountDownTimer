using System.Windows;

namespace CountDownTimer.Commands
{
    internal class LeftPressCommand : BaseCommand
    {

        public LeftPressCommand()
        {
                
        }


        public override void Execute(object? parameter)
        {
            MainWindow mainWindow = (MainWindow)parameter;

            if (mainWindow != null)
            {
                mainWindow.DragMove();
            }
            else
            {
                Application.Current.MainWindow.DragMove();
            }
            
        }
    }
}
// EOF