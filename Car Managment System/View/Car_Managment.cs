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
    public partial class Car_Managment : MetroForm
    {
        public Car_Managment()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }

        private void Car_Managment_Load(object sender, EventArgs e)
        {
            VoitureController vc = new VoitureController();
            List<Voiture> list = vc.SelectAll();
            foreach (Voiture v in list)
            {
                ListViewItem lv = new ListViewItem(v.reference.ToString());
                lv.SubItems.Add(v.marque);
                lv.SubItems.Add(v.carburant);
                lv.SubItems.Add(v.prixParJour.ToString());
                dataGridView1.Rows.Add(v.reference.ToString(), v.marque, v.carburant, v.prixParJour.ToString());
                
            }
        }
    }
}
