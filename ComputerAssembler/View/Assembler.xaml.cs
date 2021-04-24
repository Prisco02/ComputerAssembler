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
    /// Interaction logic for Assembler.xaml
    /// </summary>

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

    public partial class Assembler : UserControl
    {
        public Assembler()
        {
            InitializeComponent();
        }

        private void CPUAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
