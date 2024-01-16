using Avalonia.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SampleView.Views;

public partial class MainView : UserControl
{
    public ObservableCollection<string> Animals { get; set; }

    public MainView()
    {
        InitializeComponent();

        Animals =
        [
            "cat", "camel", "cow", "chameleon", "mouse", "lion", "zebra"
        ];
    }
}
