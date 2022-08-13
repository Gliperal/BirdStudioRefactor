﻿using System.Windows;
using System.Windows.Input;

namespace BirdStudioRefactor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TASEditor editor;

        public MainWindow()
        {
            InitializeComponent();
            editor = new TASEditor(this, editorBase);
        }

        private void NewCommand_Execute(object sender, RoutedEventArgs e)
        {
            editor.neww();
        }

        private void OpenCommand_Execute(object sender, RoutedEventArgs e)
        {
            editor.open();
        }

        private void SaveCommand_Execute(object sender, RoutedEventArgs e)
        {
            editor.save();
        }

        private void SaveAsCommand_Execute(object sender, RoutedEventArgs e)
        {
            editor.saveAs(null);
        }

        private void UndoCommand_Execute(object sender, RoutedEventArgs e)
        {
            editor.undo();
        }

        private void UndoCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = editor.canUndo();
        }

        private void RedoCommand_Execute(object sender, RoutedEventArgs e)
        {
            editor.redo();
        }

        private void RedoCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = editor.canRedo();
        }

        private void NewBranch_Execute(object sender, RoutedEventArgs e)
        {
            editor.newBranch();
        }

        private void AddBranch_Execute(object sender, RoutedEventArgs e)
        {
            editor.addBranch();
        }

        private void CycleBranch_Execute(object sender, RoutedEventArgs e)
        {
            editor.cycleBranch();
        }

        private void RemoveBranch_Execute(object sender, RoutedEventArgs e)
        {
            editor.removeBranch();
        }

        private void RenameBranch_Execute(object sender, RoutedEventArgs e)
        {
            editor.renameBranch();
        }

        private void Menu_LightMode(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void Menu_DarkMode(object sender, RoutedEventArgs e)
        {
            // TODO
            editor.showPlaybackFrame(20);
        }

        /* TODO
        private void showPlaybackFrame()
        {
            if (currentFrame == -1)
                return;
            // TODO
        }
        */
    }
}
