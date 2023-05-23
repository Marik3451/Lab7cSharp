using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab6cSharp.Animal;

namespace Lab6cSharp
{
    public partial class Applications : Form
    {
        private WolfCollection<IAnimal> wolfCollection;
        private BindingList<IAnimal> animalList;
        private bool sortDescending = false;
        private bool sortAscending = true;
        public Applications()
        {
            wolfCollection = new WolfCollection<IAnimal>();
            animalList = new BindingList<IAnimal>(wolfCollection);
            InitializeComponent();
            lstAnimals.DataSource=animalList;
            fillAnimal();
        }
        void fillAnimal() 
        {
            animalList.Add(new Lion("Gray","Forest",60,10,15));
            animalList.Add(new Wolf("Angry", "Dark Forest", 40, 50, 55));
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateWolf wolf = new CreateWolf(animalList);
            wolf.ShowDialog();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            IAnimal[] _animal = new IAnimal[lstAnimals.Items.Count];
            for (int i = 0; i < lstAnimals.Items.Count; i++)
            {
                _animal[i] = lstAnimals.Items[i] as IAnimal;
            }

            if (sortAscending)
            {
                Array.Sort(_animal);
            }
            else if (sortDescending)
            {
                Array.Sort(_animal, (x, y) => y.CompareTo(x));
            }

            animalList.Clear();

            foreach (IAnimal animal in _animal)
            {
                animalList.Add(animal);
            }
        }
        private void btnClone_Click(object sender, EventArgs e)
        {
            int CountLstAnimal = animalList.Count;
            for (int i = 0; i < CountLstAnimal; i++)
            {
                animalList.Add((IAnimal)animalList[i].Clone());
            }
        }

        private void lstAnimals_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateLion lion = new CreateLion(animalList);
            lion.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void rbtnAscending_CheckedChanged(object sender, EventArgs e)
        {
            sortAscending = rbtnAscending.Checked;
        }

        private void rbtnDescending_CheckedChanged(object sender, EventArgs e)
        {
            sortDescending = rbtnDescending.Checked;
        }
    }
}

