using CountDownTimer.Commands;
using CountDownTimer.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CountDownTimer.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private readonly NavigationStore _navigationStore;

        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;


        public ICommand CloseCommand { get; }


        public ICommand LeftPressCommand { get; }


        public ICommand MaximizeCommand { get; }


        public ICommand MinimizeCommand { get; }


        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            CloseCommand = new CloseCommand();
            LeftPressCommand = new LeftPressCommand();
            MaximizeCommand = new MaximizeCommand();
            MinimizeCommand = new MinimizeCommand();
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
