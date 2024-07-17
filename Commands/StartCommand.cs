using CountDownTimer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer.Commands
{
    internal class StartCommand : BaseCommand
    {

        public ICountDownTimer viewModel;


        public StartCommand(ICountDownTimer viewModel)
        {
            this.viewModel = viewModel;
        }


        public override void Execute(object? parameter)
        {
            viewModel.StartTimer();
        }


    }
}
