using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Test_Integration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Person : IPersons
        {
            string name;
            int hight;
            string number;

            void IPersons.Person()
            {
                MessageBox.Show("Мы люди!");
            }

            void IPersons.Trainer()
            {
                MessageBox.Show("Мы тренеры!");
            }

            void IPersons.Trenerovka()
            {
                MessageBox.Show("Мы являемся тренеровками!");
            }

            void IPersons.Zanyatie()
            {
                MessageBox.Show("Мы являемся занятиями");
            }

        }
        class Trainer : Person
        {
            string name;
            string trenerovka;
        }

        class Trenerovka : Person
        {
            string nametrenerovka;
        }

        class Zanyatie : Person
        {
            int number;
        }

        interface IPersons
        {
            void Person();
            void Trainer();
            void Trenerovka();
            void Zanyatie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPersons t = new Person();
            t.Person();
        }
    }
}
