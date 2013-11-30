using System;
using System.Windows.Input;

namespace Catan.ViewModel.Commons
{
    /// <summary>
    /// Akci� parancs
    /// </summary>
    public class ActionCommand : ICommand
    {
        /// <summary>
        /// A parancs fut�s�nak el�felt�tel�t t�rol� f�ggv�ny
        /// </summary>
        private readonly Predicate<object> _CanExecute;

        /// <summary>
        /// A parancs fut�s�t t�rol� f�ggv�ny
        /// </summary>
        private readonly Action _Execute;

        /// <summary>
        /// ActionCommand konstruktor
        /// </summary>
        public ActionCommand(Action execute)
            : this(null, execute)
        {

        }

        /// <summary>
        /// ActionCommand konstruktor
        /// </summary>
        public ActionCommand(Predicate<object> canExecute, Action execute)
        {
            _Execute = execute;
            _CanExecute = canExecute;
        }

        /// <summary>
        /// Parancs lefuttat�sa
        /// </summary>
        public void Execute(object parameter)
        {
            _Execute();
        }

        /// <summary>
        /// Igazzal t�r vissza, ha le lehet futtatni a parancsot
        /// </summary>
        public bool CanExecute(object parameter)
        {
            if (_CanExecute == null)
                return true;
            return _CanExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        protected void OnCanExecuteChanged()
        {
            if (CanExecuteChanged != null) {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}