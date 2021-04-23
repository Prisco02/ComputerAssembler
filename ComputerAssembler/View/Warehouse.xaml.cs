using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PCshop;

namespace ComputerAssembler.View
{
    /// <summary>
    /// Interaction logic for Warehouse.xaml
    /// </summary>
    public partial class Warehouse : UserControl
    {

        public int _menuInUso = 0;

        void ActivateBasicText()
        {
            FirstTextBox.IsEnabled = true;
            SecondTextBox.IsEnabled = true;
            ThirdTextBox.IsEnabled = true;
            FirstInfoLabel.Content = "Nome componente \n(stringa)";
            SecondInfoLabel.Content = "Prezzo in euro \n(numero con virgola)";
            ThirdInfoLabel.Content = "Consumo in Watt \n(numero intero)";
        }

        public Warehouse()
        {
            InitializeComponent();
            FirstTextBox.IsEnabled = false;
            SecondTextBox.IsEnabled = false;
            ThirdTextBox.IsEnabled = false;
            FourthTextBox.IsEnabled = false;
            FifthTextBox.IsEnabled = false;
            SixthTextBox.IsEnabled = false;
            SeventhTextBox.IsEnabled = false;
        }

        private void CPUMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 1;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = true;
            FourthLabel.Content = "Cache:";
            FifthLabel.Content = "Cores:";
            SixthLabel.Content = "Ghz:";
            SeventhLabel.Content = "Socket:";
            FourthInfoLabel.Content = "Grandezza Cache in MB \n(numero con virgola)";
            FifthInfoLabel.Content = "Quanti Core in numero \n(numero intero)";
            SixthInfoLabel.Content = "Velocitá del processore \n(numero con virgola)";
            SeventhInfoLabel.Content = "Quale Socket utilizza \n(stringa)";
        }

        private void MOBOMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 2;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = false;
            SixthTextBox.IsEnabled = false;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Socket:";
            FifthLabel.Content = "";
            SixthLabel.Content = "";
            SeventhLabel.Content = "";
            FourthInfoLabel.Content = "Quale Socket utilizza \n(stringa)";
            FifthInfoLabel.Content = "";
            SixthInfoLabel.Content = "";
            SeventhInfoLabel.Content = "";
        }

        private void RAMMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 3;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "DDR Version:";
            FifthLabel.Content = "GB:";
            SixthLabel.Content = "Mhz:";
            SeventhLabel.Content = "";
        }

        private void GPUMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 4;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "GDDR Version:";
            FifthLabel.Content = "TeraFlops:";
            SixthLabel.Content = "Vram:";
            SeventhLabel.Content = "";
        }

        private void COOLERMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 5;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = false;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Fans:";
            FifthLabel.Content = "Noise:";
            SixthLabel.Content = "";
            SeventhLabel.Content = "";
        }

        private void ARCHIVEMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 6;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "GB:";
            FifthLabel.Content = "Read:";
            SixthLabel.Content = "Write:";
            SeventhLabel.Content = "";
        }

        private void PSUMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 7;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = false;
            SixthTextBox.IsEnabled = false;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Quality:";
            FifthLabel.Content = "";
            SixthLabel.Content = "";
            SeventhLabel.Content = "";
        }

        private void CASEMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 8;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = false;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Hight:";
            FifthLabel.Content = "Width:";
            SixthLabel.Content = "";
            SeventhLabel.Content = "";
        }

        private void FANMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 9;
            ActivateBasicText();
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Noise:";
            FifthLabel.Content = "RGB:";
            SixthLabel.Content = "RPM:";
            SeventhLabel.Content = "";
        }
    }
}
