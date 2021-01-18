using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TPP_ver_2
{
    public partial class Radius : Form
    {
        public delegate void Radius_carrier(int R); //Объявляем делегат 
        public static event Radius_carrier Radius_changing; //Объявляем событие, которое представляет делегат Radius_carrier
        public Radius(int R_reserv)
        {
            InitializeComponent();
            Opened = true;
            trackBar1.Value = R_reserv;
        }

        private void Radius_FormClosed(object sender, FormClosedEventArgs e)
        {
            Opened = false;
        }

        private void TrackBar1_Scroll_1(object sender, EventArgs e)
        {
            if(Radius_changing != null) //Проверка определения обработчика (Событие принимает значение null, если для него не определён обработчик)
                Radius_changing.Invoke(trackBar1.Value); //Выполняем делегат
        }

        private void Radius_Load(object sender, EventArgs e)
        {
        }
    }
}
