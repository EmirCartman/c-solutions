using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örmek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }




        public class Siparis
    {

        public DateTime Tarih { get; set; }
        public string Durum { get; set; }

    }





        public class Musteri
    {

        public string Ad { get; set; }
        public string Telefon { get; set; }

        public void SiparisVer()
        {
            Siparis sipariş;
        }

    }








}


