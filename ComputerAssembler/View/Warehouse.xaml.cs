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

        List<Cpu> _processori = new List<Cpu>();
        List<Mobo> _schedeMadri = new List<Mobo>();
        List<Ram> _rams = new List<Ram>();
        List<Gpu> _schedeVideo = new List<Gpu>();
        List<Cooler> _dissipatori = new List<Cooler>();
        List<Archive> _storage = new List<Archive>();
        List<Psu> _alimentatori = new List<Psu>();
        List<Case> _cases = new List<Case>();
        List<Fans> _fans = new List<Fans>();

        public int _menuInUso = 0;

        void ClearContent()
        {
            FirstTextBox.Text = "";
            SecondTextBox.Text = "";
            ThirdTextBox.Text = "";
            FourthTextBox.Text = "";
            FifthTextBox.Text = "";
            SixthTextBox.Text = "";
            SeventhTextBox.Text = "";
        }

        void ActivateBasicText()
        {
            ListComponents.UnselectAll();
            ListComponents.Items.Clear();
            ClearContent();
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
            for (int i = 0; i<_processori.Count; i++ )
            {
                ListComponents.Items.Add(_processori[i].Name);
            }
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
            for (int i = 0; i < _schedeMadri.Count; i++)
            {
                ListComponents.Items.Add(_schedeMadri[i].Name);
            }
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
            for (int i = 0; i < _rams.Count; i++)
            {
                ListComponents.Items.Add(_rams[i].Name);
            }
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "DDR Version:";
            FifthLabel.Content = "GB:";
            SixthLabel.Content = "Mhz:";
            SeventhLabel.Content = "";
            FourthInfoLabel.Content = "Versione dello standard DDR \n(numero intero)";
            FifthInfoLabel.Content = "Dimensione totale della RAM \n(numero intero)";
            SixthInfoLabel.Content = "Velocitá della RAM \n(numero intero)";
            SeventhInfoLabel.Content = "";
        }

        private void GPUMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 4;
            ActivateBasicText();
            for (int i = 0; i < _schedeVideo.Count; i++)
            {
                ListComponents.Items.Add(_schedeVideo[i].Name);
            }
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "GDDR Version:";
            FifthLabel.Content = "TeraFlops:";
            SixthLabel.Content = "GB:";
            SeventhLabel.Content = "";
            FourthInfoLabel.Content = "Versione dello standard GDDR \n(numero intero)";
            FifthInfoLabel.Content = "Potenza della GPU \n(numero con virgola)";
            SixthInfoLabel.Content = "Dimensione totale della VRAM \n(numero intero)";
            SeventhInfoLabel.Content = "";
        }

        private void COOLERMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 5;
            ActivateBasicText();
            for (int i = 0; i < _dissipatori.Count; i++)
            {
                ListComponents.Items.Add(_dissipatori[i].Name);
            }
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = false;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Fans:";
            FifthLabel.Content = "Noise:";
            SixthLabel.Content = "";
            SeventhLabel.Content = "";
            FourthInfoLabel.Content = "Numero ventole incluse \n(numero intero)";
            FifthInfoLabel.Content = "Rumore massimo in DB \n(numero intero)";
            SixthInfoLabel.Content = "";
            SeventhInfoLabel.Content = "";
        }

        private void ARCHIVEMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 6;
            ActivateBasicText();
            for (int i = 0; i < _storage.Count; i++)
            {
                ListComponents.Items.Add(_storage[i].Name);
            }
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "GB:";
            FifthLabel.Content = "Read:";
            SixthLabel.Content = "Write:";
            SeventhLabel.Content = "";
            FourthInfoLabel.Content = "Dimensione totale dell'archiviazione \n(numero intero)";
            FifthInfoLabel.Content = "Velocitá di lettura in MB/s \n(numero con virgola)";
            SixthInfoLabel.Content = "Velocitá di scrittura in MB/s \n(numero con virgola)";
            SeventhInfoLabel.Content = "";
        }

        private void PSUMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 7;
            ActivateBasicText();
            for (int i = 0; i < _alimentatori.Count; i++)
            {
                ListComponents.Items.Add(_alimentatori[i].Name);
            }
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = false;
            SixthTextBox.IsEnabled = false;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Quality:";
            FifthLabel.Content = "";
            SixthLabel.Content = "";
            SeventhLabel.Content = "";
            FourthInfoLabel.Content = "Standard 80Plus \n(stringa)";
            FifthInfoLabel.Content = "";
            SixthInfoLabel.Content = "";
            SeventhInfoLabel.Content = "";
        }

        private void CASEMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 8;
            ActivateBasicText();
            for (int i = 0; i < _cases.Count; i++)
            {
                ListComponents.Items.Add(_cases[i].Name);
            }
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = false;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Hight:";
            FifthLabel.Content = "Width:";
            SixthLabel.Content = "";
            SeventhLabel.Content = "";
            FourthInfoLabel.Content = "Altezza in cm \n(numero con virgola)";
            FifthInfoLabel.Content = "Larghezza in cm \n(numero con virgola)";
            SixthInfoLabel.Content = "";
            SeventhInfoLabel.Content = "";
        }

        private void FANMenu_Click(object sender, RoutedEventArgs e)
        {
            _menuInUso = 9;
            ActivateBasicText();
            for (int i = 0; i < _fans.Count; i++)
            {
                ListComponents.Items.Add(_fans[i].Name);
            }
            FourthTextBox.IsEnabled = true;
            FifthTextBox.IsEnabled = true;
            SixthTextBox.IsEnabled = true;
            SeventhTextBox.IsEnabled = false;
            FourthLabel.Content = "Noise:";
            FifthLabel.Content = "RGB:";
            SixthLabel.Content = "RPM:";
            SeventhLabel.Content = "";
            FourthInfoLabel.Content = "Rumore massimo in DB \n(numero intero)";
            FifthInfoLabel.Content = "Se sono luminose \n(1=True,0=False)";
            SixthInfoLabel.Content = "Velocitá massima della ventola \n(numero intero)";
            SeventhInfoLabel.Content = "";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (_menuInUso)
                {


                    case 1:
                        Cpu a = new Cpu();
                        a.Name = FirstTextBox.Text;
                        a.Price = double.Parse(SecondTextBox.Text);
                        a.Power = int.Parse(ThirdTextBox.Text);
                        a.Cache = double.Parse(FourthTextBox.Text);
                        a.Core = int.Parse(FifthTextBox.Text);
                        a.Ghz = double.Parse(SixthTextBox.Text);
                        a.Socket = SeventhTextBox.Text;
                        _processori.Add(a);
                        ListComponents.Items.Add(a.Name);
                        break;
                    case 2:
                        Mobo b = new Mobo();
                        b.Name = FirstTextBox.Text;
                        b.Price = double.Parse(SecondTextBox.Text);
                        b.Power = int.Parse(ThirdTextBox.Text);
                        b.Socket = FourthTextBox.Text;
                        _schedeMadri.Add(b);
                        ListComponents.Items.Add(b.Name);
                        break;
                    case 3:
                        Ram c = new Ram();
                        c.Name = FirstTextBox.Text;
                        c.Price = double.Parse(SecondTextBox.Text);
                        c.Power = int.Parse(ThirdTextBox.Text);
                        c.DdrVersion = int.Parse(FourthTextBox.Text);
                        c.GB = int.Parse(FifthTextBox.Text);
                        c.Mhz = int.Parse(SixthTextBox.Text);
                        _rams.Add(c);
                        ListComponents.Items.Add(c.Name);
                        break;
                    case 4:
                        Gpu d = new Gpu();
                        d.Name = FirstTextBox.Text;
                        d.Price = double.Parse(SecondTextBox.Text);
                        d.Power = int.Parse(ThirdTextBox.Text);
                        d.Gddr = int.Parse(FourthTextBox.Text);
                        d.Teraflops = double.Parse(FirstTextBox.Text);
                        d.Vram = int.Parse(SixthTextBox.Text);
                        _schedeVideo.Add(d);
                        ListComponents.Items.Add(d.Name);
                        break;
                    case 5:
                        Cooler f;
                        f = new LiquidCooler();
                        f = new AirCooler();
                        f.Name = FirstTextBox.Text;
                        f.Price = double.Parse(SecondTextBox.Text);
                        f.Power = int.Parse(ThirdTextBox.Text);
                        f.Fans = int.Parse(FourthTextBox.Text);
                        f.Noise = int.Parse(SixthTextBox.Text);
                        _dissipatori.Add(f);
                        ListComponents.Items.Add(f.Name);
                        break;
                    case 6:
                        Archive g;
                        g = new Ssd();
                        g = new Hdd();
                        g.Name = FirstTextBox.Text;
                        g.Price = double.Parse(SecondTextBox.Text);
                        g.Power = int.Parse(ThirdTextBox.Text);
                        g.GB = int.Parse(FourthTextBox.Text);
                        g.Read = double.Parse(FifthTextBox.Text);
                        g.Write = double.Parse(SixthTextBox.Text);
                        _storage.Add(g);
                        ListComponents.Items.Add(g.Name);
                        break;
                    case 7:
                        Psu h = new Psu();
                        h.Name = FirstTextBox.Text;
                        h.Price = double.Parse(SecondTextBox.Text);
                        h.Power = int.Parse(ThirdTextBox.Text);
                        h.Quality = FourthTextBox.Text;
                        _alimentatori.Add(h);
                        ListComponents.Items.Add(h.Name);
                        break;
                    case 8:
                        Case i = new Case();
                        i.Name = FirstTextBox.Text;
                        i.Price = double.Parse(SecondTextBox.Text);
                        i.Power = int.Parse(ThirdTextBox.Text);
                        i.Hight = double.Parse(FourthTextBox.Text);
                        i.Width = double.Parse(FifthTextBox.Text);
                        _cases.Add(i);
                        ListComponents.Items.Add(i.Name);
                        break;
                    case 9:
                        Fans l = new Fans();
                        l.Name = FirstTextBox.Text;
                        l.Price = double.Parse(SecondTextBox.Text);
                        l.Power = int.Parse(ThirdTextBox.Text);
                        l.Noise = int.Parse(FourthTextBox.Text);
                        if (int.Parse(FifthTextBox.Text) == 1) l.RGB = true;
                        if (int.Parse(FifthTextBox.Text) == 0) l.RGB = false;
                        l.RPM = int.Parse(SixthTextBox.Text);
                        _fans.Add(l);
                        ListComponents.Items.Add(l.Name);
                        break;
                }
                ClearContent();
            }
            catch
            {

            }
        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (_menuInUso)
                {
                    case 1:
                        _processori[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _processori[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _processori[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _processori[ListComponents.SelectedIndex].Cache = double.Parse(FourthTextBox.Text);
                        _processori[ListComponents.SelectedIndex].Core = int.Parse(FifthTextBox.Text);
                        _processori[ListComponents.SelectedIndex].Ghz = double.Parse(SixthTextBox.Text);
                        _processori[ListComponents.SelectedIndex].Socket = SeventhTextBox.Text;
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                    case 2:
                        _schedeMadri[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _schedeMadri[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _schedeMadri[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _schedeMadri[ListComponents.SelectedIndex].Socket = FourthTextBox.Text;
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                    case 3:
                        _rams[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _rams[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _rams[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _rams[ListComponents.SelectedIndex].DdrVersion = int.Parse(FourthTextBox.Text);
                        _rams[ListComponents.SelectedIndex].GB = int.Parse(FifthTextBox.Text);
                        _rams[ListComponents.SelectedIndex].Mhz = int.Parse(SixthTextBox.Text);
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                    case 4:
                        _schedeVideo[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _schedeVideo[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _schedeVideo[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _schedeVideo[ListComponents.SelectedIndex].Gddr = int.Parse(FourthTextBox.Text);
                        _schedeVideo[ListComponents.SelectedIndex].Teraflops = double.Parse(FirstTextBox.Text);
                        _schedeVideo[ListComponents.SelectedIndex].Vram = int.Parse(SixthTextBox.Text);
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                    case 5:
                        _dissipatori[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _dissipatori[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _dissipatori[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _dissipatori[ListComponents.SelectedIndex].Fans = int.Parse(FourthTextBox.Text);
                        _dissipatori[ListComponents.SelectedIndex].Noise = int.Parse(SixthTextBox.Text);
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                    case 6:
                        _storage[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _storage[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _storage[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _storage[ListComponents.SelectedIndex].GB = int.Parse(FourthTextBox.Text);
                        _storage[ListComponents.SelectedIndex].Read = double.Parse(FifthTextBox.Text);
                        _storage[ListComponents.SelectedIndex].Write = double.Parse(SixthTextBox.Text);
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                    case 7:
                        _alimentatori[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _alimentatori[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _alimentatori[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _alimentatori[ListComponents.SelectedIndex].Quality = FourthTextBox.Text;
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                    case 8:
                        _cases[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _cases[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _cases[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _cases[ListComponents.SelectedIndex].Hight = int.Parse(ThirdTextBox.Text);
                        _cases[ListComponents.SelectedIndex].Width = double.Parse(FifthTextBox.Text);
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                    case 9:
                        _fans[ListComponents.SelectedIndex].Name = FirstTextBox.Text;
                        _fans[ListComponents.SelectedIndex].Price = double.Parse(SecondTextBox.Text);
                        _fans[ListComponents.SelectedIndex].Power = int.Parse(ThirdTextBox.Text);
                        _fans[ListComponents.SelectedIndex].Noise = int.Parse(FourthTextBox.Text);
                        if (int.Parse(FifthTextBox.Text) == 1) _fans[ListComponents.SelectedIndex].RGB = true;
                        if (int.Parse(FifthTextBox.Text) == 0) _fans[ListComponents.SelectedIndex].RGB = false;
                        _fans[ListComponents.SelectedIndex].RPM = int.Parse(SixthTextBox.Text);
                        ListComponents.SelectedItem = FirstTextBox.Text;
                        break;
                }
            }
            catch { }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListComponents.Items.Remove(ListComponents.SelectedItem);
                switch (_menuInUso)
                {
                    case 1:
                        _processori.RemoveAt(ListComponents.SelectedItem);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                }
                ClearContent();
            }
            catch
            {

            }
        }

        private void ListComponents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                switch (_menuInUso)
                {
                    case 1:
                        FirstTextBox.Text = _processori[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _processori[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _processori[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _processori[ListComponents.SelectedIndex].Cache.ToString();
                        FifthTextBox.Text = _processori[ListComponents.SelectedIndex].Core.ToString();
                        SixthTextBox.Text = _processori[ListComponents.SelectedIndex].Ghz.ToString();
                        SeventhTextBox.Text = _processori[ListComponents.SelectedIndex].Socket;
                        break;
                    case 2:
                        FirstTextBox.Text = _schedeMadri[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _schedeMadri[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _schedeMadri[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _schedeMadri[ListComponents.SelectedIndex].Socket;
                        break;
                    case 3:
                        FirstTextBox.Text = _rams[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _rams[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _rams[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _rams[ListComponents.SelectedIndex].DdrVersion.ToString();
                        FifthTextBox.Text = _rams[ListComponents.SelectedIndex].GB.ToString();
                        SixthTextBox.Text = _rams[ListComponents.SelectedIndex].Mhz.ToString();
                        break;
                    case 4:
                        FirstTextBox.Text = _schedeVideo[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _schedeVideo[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _schedeVideo[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _schedeVideo[ListComponents.SelectedIndex].Gddr.ToString();
                        FirstTextBox.Text = _schedeVideo[ListComponents.SelectedIndex].Teraflops.ToString();
                        SixthTextBox.Text = _schedeVideo[ListComponents.SelectedIndex].Vram.ToString();
                        break;
                    case 5:
                        FirstTextBox.Text = _dissipatori[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _dissipatori[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _dissipatori[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _dissipatori[ListComponents.SelectedIndex].Fans.ToString();
                        SixthTextBox.Text = _dissipatori[ListComponents.SelectedIndex].Noise.ToString();
                        break;
                    case 6:
                        FirstTextBox.Text = _storage[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _storage[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _storage[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _storage[ListComponents.SelectedIndex].GB.ToString();
                        FifthTextBox.Text = _storage[ListComponents.SelectedIndex].Read.ToString();
                        SixthTextBox.Text = _storage[ListComponents.SelectedIndex].Write.ToString();
                        break;
                    case 7:
                        FirstTextBox.Text = _alimentatori[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _alimentatori[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _alimentatori[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _alimentatori[ListComponents.SelectedIndex].Quality;
                        break;
                    case 8:
                        FirstTextBox.Text = _cases[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _cases[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _cases[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _cases[ListComponents.SelectedIndex].Hight.ToString();
                        FifthTextBox.Text = _cases[ListComponents.SelectedIndex].Width.ToString();
                        break;
                    case 9:
                        FirstTextBox.Text = _fans[ListComponents.SelectedIndex].Name;
                        SecondTextBox.Text = _fans[ListComponents.SelectedIndex].Price.ToString();
                        ThirdTextBox.Text = _fans[ListComponents.SelectedIndex].Power.ToString();
                        FourthTextBox.Text = _fans[ListComponents.SelectedIndex].Noise.ToString();
                        if (_fans[ListComponents.SelectedIndex].RGB == true) FifthTextBox.Text = "1";
                        if (_fans[ListComponents.SelectedIndex].RGB == false) FifthTextBox.Text = "0";
                        SixthTextBox.Text = _fans[ListComponents.SelectedIndex].RPM.ToString();
                        break;
                }
            }
            catch { }
        }
    }
}
