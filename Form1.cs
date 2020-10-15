using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Assignment
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();

        public RandomNumbers()
        {
            InitializeComponent();
        }


        private void btnInteger_Click(object sender, EventArgs e)
        {

            int min;
            int max;
            int random;

            min = Convert.ToInt32(txtMinimum.Text);
            max = Convert.ToInt32(txtMaximum.Text);
            random = generator.Next(min, max);

            lblOutput.Text = Convert.ToString(random);

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {

            int min;
            int max;
            double randomDouble;
            int random;

            min = Convert.ToInt32(txtMinimum.Text);
            max = Convert.ToInt32(txtMaximum.Text);
            random = generator.Next(min , max);
            randomDouble = generator.NextDouble() + (random);

            lblOutput.Text = Convert.ToString(randomDouble);

        }

        private void RandomNumbers_Load(object sender, EventArgs e)
        {

        }
    }
}
