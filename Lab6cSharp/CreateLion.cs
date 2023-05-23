using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6cSharp
{
    public partial class CreateLion : Form
    {
        private BindingList<IAnimal> animalList;
        public CreateLion(BindingList<IAnimal> animalList)
        {
            InitializeComponent();
            this.animalList = animalList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string species = txtSpecies.Text;
                string location = txtLocation.Text;
                double weight = int.Parse(txtWeight.Text);
                int age = int.Parse(txtAge.Text);
                double cost = int.Parse(txtCost.Text);

                Lion wolf = new Lion(species, location, weight, age, cost);
                animalList.Add(wolf);
                this.Close();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
