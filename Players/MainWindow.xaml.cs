using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Players
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string backup = "backup.txt"; 
        public MainWindow()
        {
            InitializeComponent();
            AddAge();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var players = Save.GetFromFile(backup);
            if (players != null)
                foreach (var pl in players)
                {
                    ListboxPlayers.Items.Add(pl);
                }
            //ListboxPlayers.Items.Refresh();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int n = ListboxPlayers.Items.Count;
            Player[] players = null;
            if (n > 0)
            {
                players = new Player[n];
                int index = 0;
                foreach (var o in ListboxPlayers.Items)
                {
                    players[index++] = o as Player;
                }
                Save.SaveToFile(backup, players);
            }
        }

        private void LoadPlayer(Player player)
        {
            TextBoxFirstName.Text = player.Firstname;
            TextBoxLastName.Text = player.Lastname;
            SliderWeight.Value = player.Weight;
            ComboBoxAge.SelectedItem = player.Age;
            ButtonModyfikuj.IsEnabled = true;
            ButtonUsun.IsEnabled = true;
        }

        private void SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if (ListboxPlayers.SelectedIndex > -1)
            {
                LoadPlayer((Player)ListboxPlayers.SelectedItem);
            }
        }

        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxFirstName.Text.Length != 0 & TextBoxLastName.Text.Length != 0)
            {
                var currentPlayer = new Player(TextBoxFirstName.Text.Trim(), TextBoxLastName.Text.Trim(), (double)SliderWeight.Value, (int)ComboBoxAge.SelectedItem);
                ListboxPlayers.Items.Add(currentPlayer);
                Clear();
            }
        }
        private void Clear()
        {
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            SliderWeight.Value = 75;
            ComboBoxAge.SelectedValue = 18;
            ButtonModyfikuj.IsEnabled = false;
            ButtonUsun.IsEnabled = false;
            ListboxPlayers.SelectedIndex = -1;
        }
        private void AddAge()
        {
            for (int i = 18; i < 100; i++)
            {
                ComboBoxAge.Items.Add(i);
            } 
            ComboBoxAge.Items.Refresh();
        }

        private void ButtonUsun_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz usunąć?", "Alert", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                ListboxPlayers.Items.Remove(ListboxPlayers.SelectedItem);
                TextBoxFirstName.Text = "Podaj imie";
                TextBoxLastName.Text = "Podaj nazwisko";
                SliderWeight.Value = 55d;
                ComboBoxAge.SelectedValue = 18;
            }
            ListboxPlayers.SelectedIndex = -1;
        }

        private void ButtonModyfikuj_Click_2(object sender, RoutedEventArgs e)
        {
            if (TextBoxFirstName.Text.Length != 0 & TextBoxLastName.Text.Length != 0)
            {
                var currentPlayer = new Player(TextBoxFirstName.Text.Trim(), TextBoxLastName.Text.Trim(), (double)SliderWeight.Value, (int)ComboBoxAge.SelectedItem);
                MessageBoxResult result = MessageBox.Show("Czy na pewno chcesz zmodyfikować?", "Alert", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    ListboxPlayers.Items[ListboxPlayers.SelectedIndex] = currentPlayer;
                }
                Clear();
            }
                
            ListboxPlayers.SelectedIndex = -1;
        }

        private void TextBoxFirstName_Click(object sender, EventArgs e)
        {
            TextBoxFirstName.Text = string.Empty;
        }

        private void TextBoxLastName_Click(object sender, EventArgs e)
        {
            TextBoxLastName.Text = string.Empty;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.BorderBrush = System.Windows.Media.Brushes.Red;
                tb.BorderThickness = new Thickness(2);
                tb.ToolTip = "Musisz uzupełnić pole!";
            }
            else
            {
                tb.BorderBrush = System.Windows.Media.Brushes.Black;
                tb.BorderThickness = new Thickness(1);
                tb.ToolTip = null;
            }
        }
        private void Focused(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Podaj imie" || tb.Text == "Podaj nazwisko")
            {
                tb.Foreground = System.Windows.Media.Brushes.Black;
                tb.Text = "";
            }
        }

    }
}
