using Circustrein.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class animalApp : Form
    {
        Train train = new Train();

        public animalApp()
        {
            InitializeComponent();
            cmbFood.DataSource = Enum.GetValues(typeof(Food));
            cmbSize.DataSource = Enum.GetValues(typeof(Logic.Size)); 
        }


        private void animalAdd_Click(object sender, EventArgs e)
        {
            if(AddAnimal() == false)
            {
                MessageBox.Show("Enter a name");
                ShowAction(false); 
            }

            else if(AddAnimal() == true)
            {
                ShowAction(true); 
            }
        }

        private bool AddAnimal()
        {
            if(txtName.Text != "")
            {
                Animal animal = new Animal((Food)cmbFood.SelectedItem, (Logic.Size)cmbSize.SelectedItem, txtName.Text);
                if(train.AddNewAnimal(animal))
                {
                    return true; 
                }

                else
                {
                    train.wagons.Add(new Wagon());
                    train.AddNewAnimal(animal); 
                    return true; 
                }
                
            }

            return false; 
        }

        private void ShowAction(bool worked)
        {
            if(worked == true)
            {
                string time = DateTime.Now.ToString("HH:mm:ss tt");
                string action = "[" + time + "] " + txtName.Text + " added";
                lbxAdd.Items.Add(action);
            }
            else if(worked == false)
            {
                string time = DateTime.Now.ToString("HH:mm:ss tt");
                string action = "[" + time + "]" + " Failed";
                lbxAdd.Items.Add(action); 
            }
             
        }
    }
}
