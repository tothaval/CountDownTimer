﻿using System.Windows;
using System.Windows.Media;

namespace CountDownTimer.Commands
{
    internal class MaximizeCommand : BaseCommand
    {

        public MaximizeCommand()
        {
                
        }

        public override void Execute(object? parameter)
        {
            MainWindow mainWindow = (MainWindow)parameter;


            if (mainWindow.WindowState == WindowState.Normal)
            {
                mainWindow.SizeToContent = SizeToContent.Manual;

                mainWindow.WindowState = WindowState.Maximized;
                mainWindow.Background = (SolidColorBrush)Application.Current.Resources["BackgroundBrush"];
                Application.Current.Resources["MaximizeContextMenuItemHeader"] = "Normalize";
            }
            else
            {
                mainWindow.SizeToContent = SizeToContent.WidthAndHeight;

                mainWindow.WindowState = WindowState.Normal;
                mainWindow.Background = new SolidColorBrush(Colors.Transparent);
                Application.Current.Resources["MaximizeContextMenuItemHeader"] = "Maximize";
            }
        }


    }
}
// EOF