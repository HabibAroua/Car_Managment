using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Car_Managment_System.Controller;
using Car_Managment_System.Model;

namespace Car_Managment_System.View
{
    public partial class UpdateCar : MetroForm
    {
        public UpdateCar()
        {
            InitializeComponent();
        }

        private void UpdateCar_Load(object sender, EventArgs e)
        {
            carburantCamboBox.Items.Add("Essence");
            carburantCamboBox.Items.Add("GPL");
            carburantCamboBox.Items.Add("Gazoile");
        }
    }
}
