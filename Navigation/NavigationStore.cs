﻿using CountDownTimer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer.Navigation
{
    internal class NavigationStore
    {
        private BaseViewModel _baseViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return _baseViewModel; }
            set
            {
                _baseViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

    }
}
