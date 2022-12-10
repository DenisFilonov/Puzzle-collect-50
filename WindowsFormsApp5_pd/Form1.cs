using System;
using System.Windows.Forms;

namespace WindowsFormsApp5_pd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbDigits_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (chbDigits.CheckedItems != null)
            //{
            //    txbDigits.Text += chbDigits.Text + "\r\n";
            //}
            int sum = 0;

            txbDigits.Text = "";
            if (chbDigits.CheckedItems.Count == 0)
            {
                txbDigits.Text = "";

            }
            var list = chbDigits.CheckedItems;

            foreach (var item in list)
            {
                txbDigits.Text += item + Environment.NewLine;
                sum += int.Parse(item.ToString());
            }
            
            list = null;
            lblSum.Text = "Сумма: " + sum.ToString();

            if (sum == 50)
            {
                if (MessageBox.Show("Вы успешно решили головоломку", "Поздравляю", MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
                {
                    for (int i = 0; i < chbDigits.Items.Count; i++)
                    {
                        chbDigits.SetItemChecked(i, false);
                    }
                    txbDigits.Text = "Подбери числа";
                    lblSum.Text = "Сумма: ";
                }
                MessageBox.Show("Игра обнулена", "Отлично", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
