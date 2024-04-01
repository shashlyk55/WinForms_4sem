using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JobSearchApp.Commands
{
    public static class Command1
    {
        private static RoutedUICommand _openAddVacancyWindowCommand;
        private static RoutedUICommand _openEditVacancyWindowCommand;
        private static RoutedUICommand _deleteVacancyCommand;
        private static RoutedUICommand _undoCommand;
        private static RoutedUICommand _redoCommand;

        static Command1()
        {
            _openAddVacancyWindowCommand = new RoutedUICommand("OpenAddVacancyWindow", "OpenAddVacancyWindowCommand", typeof(Command1));
            _openEditVacancyWindowCommand = new RoutedUICommand("OpenEditVacancyWindow", "OpenEditVacancyWindowCommand", typeof(Command1));
            _deleteVacancyCommand = new RoutedUICommand("DeleteVacancy", "DeleteVacancyCommand", typeof(Command1));
            _undoCommand = new RoutedUICommand("Undo","UndoCommand",typeof(Command1));
            _redoCommand = new RoutedUICommand("Redo","RedoCommand",typeof(Command1));
        }
        public static RoutedUICommand OpenAddVacancyWindowCommand { get => _openAddVacancyWindowCommand; }
        public static RoutedUICommand OpenEditVacancyWindowCommand { get => _openEditVacancyWindowCommand; }
        public static RoutedUICommand DeleteVacancyCommand { get => _deleteVacancyCommand; }
        public static RoutedUICommand UndoCommand { get => _undoCommand; }
        public static RoutedUICommand RedoCommand { get => _redoCommand; }
    }
}
