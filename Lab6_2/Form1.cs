using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_2
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int counter = 0; //Количество слагаемых
            double sum = 0; //Сумма
            double summand = 0.0; //слагаемое
            double x;
            bool f = false;
            double precision;

            if (double.TryParse(txtPrecision.Text, out precision))
            {
                f = true;
            }


            do
            {
                counter++;
                if (double.TryParse(txtX.Text, out x) )
                {
                    summand = double.Parse(txtX.Text) / counter;
                }

                sum += summand;
                
            }   while (f && Math.Abs(summand) > precision);

            if (f)
            {
                lblResult.Text = "сумма = " + sum + ", количество =" + counter; //Заполнение суммы
            }

            else
            {
                MessageBox.Show("Введите числовое значение");
            }
        }
    }
}
