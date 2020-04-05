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
    /// <summary>
    /// Вспомогательная форма для ввода данных
    /// </summary>
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }


        //При нажатии на кнпоку ввода проверяется корректность введенных данных
        //и, в противном случае, выводится сообщение
        private void Inputbutton_Click(object sender, EventArgs e)
        {
            float weight, cost;
            if (NametextBox.Text == "" || WeighttextBox.Text == "" && CosttextBox.Text == "")
                MessageBox.Show("Заполните все поля");
            else
                if (!float.TryParse(WeighttextBox.Text, out weight) || !float.TryParse(CosttextBox.Text, out cost))
                    MessageBox.Show("Введенные числа некорректны");
                else
                {
                    Program.form.GetInfo(NametextBox.Text, weight, cost);
                    this.Close();
                }
        }
    }
}
