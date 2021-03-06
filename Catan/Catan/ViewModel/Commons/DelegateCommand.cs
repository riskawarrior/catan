﻿using System;
using System.Windows.Input;

namespace Catan.ViewModel.Commons
{
	public class DelegateCommand<T> : ICommand
	{
		private readonly Predicate<T> _canExecute;
		private readonly Action<T> _execute;

		void ICommand.Execute(object parameter)
		{
			Execute((T)parameter);
		}

		bool ICommand.CanExecute(object parameter)
		{
			return CanExecute((T)parameter);
		}

		public event EventHandler CanExecuteChanged;

		public DelegateCommand(Action<T> execute)
			: this(execute, null)
		{
		}

		public DelegateCommand(Action<T> execute,
					   Predicate<T> canExecute)
		{
			_execute = execute;
			_canExecute = canExecute;
		}

		public bool CanExecute(T parameter)
		{
			if (_canExecute == null)
			{
				return true;
			}

			return _canExecute(parameter);
		}

		public void Execute(T parameter)
		{
			_execute(parameter);
		}

		protected void OnCanExecuteChanged()
		{
			if (CanExecuteChanged != null)
			{
				CanExecuteChanged(this, EventArgs.Empty);
			}
		}
	}

}
