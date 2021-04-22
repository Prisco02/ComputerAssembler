using System;
using System.IO;
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
using PCshop;

namespace PCPartPickerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Computer 
    {
        private Cpu _processore;
        private Mobo _schedaMadre;
        private Ram _ram;
        private Gpu _schedaVideo;
        private Cooler _dissipatore;
        private Archive _storage;
        private Psu _alimentatore;
        private Case _case;

        public Cpu Processore { get; set; }
        public Mobo SchedaMadre { get; set; }
        public Ram Ram { get; set; }
        public Gpu SchedaVideo { get; set; }
        public Cooler Dissipatore { get; set; }
        public Archive Storage { get; set; }
        public Case Case { get; set; }
    }

    public partial class MainWindow : Window
    {
        List<Cpu> _processori = new List<Cpu>();
        List<Mobo> _schedeMadri = new List<Mobo>();
        List<Ram> _rams = new List<Ram>();
        List<Gpu> _schedeVideo = new List<Gpu>();
        List<Cooler> _dissipatori = new List<Cooler>();
        List<Archive> _storage = new List<Archive>();
        List<Psu> _alimentatori = new List<Psu>();
        List<Case> _cases = new List<Case>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AggiungiCPU_Click(object sender, RoutedEventArgs e)
        {
            CPUWindow w = new CPUWindow();
            w.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(path + "\\Componenti"))
                Directory.CreateDirectory(path + "\\Componenti");
            if (!File.Exists(path + "\\Componenti\\componenti.xml"))
                File.Create(path + "\\Componenti\\componenti.xml");
        }

        private void AggiungiMOBO_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AggiungiRAM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AggiungiGPU_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AggiungiCOOLER_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AggiungiSTORAGE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AggiungiPSU_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AggiungiCASE_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
