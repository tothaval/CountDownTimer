using CountDownTimer.Interfaces;
using CountDownTimer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer.Commands
{
    internal class StopCommand : BaseCommand
    {

        ICountDownTimer viewModel;


        public StopCommand(ICountDownTimer viewModel)
        {
            this.viewModel = viewModel;
        }


        public override void Execute(object? parameter)
        {
            viewModel.StopTimer();
        }


    }
}
