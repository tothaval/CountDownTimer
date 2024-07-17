using System.Windows;

namespace CountDownTimer.Commands
{
    internal class CloseCommand : BaseCommand
    {


        public CloseCommand()
        {

        }


        public override void Execute(object? parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
// EOF