using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var HouseBuilder = new HouseBuilder();

            if (radioButton1.Checked) 
            {
                HouseBuilder.SetSize("50m");
                MessageBox.Show("Size 50m");
            }
            if (radioButton2.Checked)
            {
                HouseBuilder.SetMaterial("Brick");
                MessageBox.Show("Material is brick");
            }

            if(radioButton4.Checked)
            {
                HouseBuilder.SetHeight("30m");
                MessageBox.Show("Height 30m");
            }
            if (radioButton5.Checked) 
            {
                HouseBuilder.SetHeight("40m");
                MessageBox.Show("Height 40m");
            }
            
            if (radioButton6.Checked)
            {
                HouseBuilder.SetSize("100m");
                MessageBox.Show("Size 100m");
            }
            if (radioButton7.Checked)
            {
                HouseBuilder.SetMaterial("Wood");
                MessageBox.Show("Material is wood");
            }
            


            var house = HouseBuilder.GetHouse();
            var houseImage = GetHouseImage(house);

            var copy = house.DeepCopy();
            var houseImages = CopyHouse(copy);
        }


        private Image GetHouseImage(House house)
        {
            if (house.size == "50m")
            {
                return pictureBox1.Image = Resource1.house2;
            }
            else
            {
                return pictureBox1.Image = Resource1.house1;
            }
        }

        private Image CopyHouse(House copy )
        {
            if (copy.size == "50m")
            {
                return pictureBox2.Image = Resource1.house2;
            }
            else
            {
                return pictureBox2.Image = Resource1.house1;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }     
}
