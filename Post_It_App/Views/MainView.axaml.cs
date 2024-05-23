using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Post_It_App.ViewModels;
using System.Windows.Input; // Adicione esta linha

namespace Post_It_App.Views;

public partial class MainView : UserControl
{

    public MainView()
    {
        InitializeComponent();
    }
 private void DeletePostButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
{
    if (sender is Button button && button.CommandParameter is PostViewModel postViewModel)
    {
        (DataContext as MainViewModel)?.DeletePost(postViewModel);
    }
} 
}
