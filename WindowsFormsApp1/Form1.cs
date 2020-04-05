using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        //Сумка
        Bag bag;
        //Вещи
        Things things;
        //Общий вес всех введенных вещей
        float WeightofAllThings = 0;
        public mainForm()
        {
            InitializeComponent();
            //Сначала при запуске запроситься вместимость сумки (переменная capacity)
            float capacity;
            //При некорректном вводе сохранится значение по умолчанию (50)
            string res = Interaction.InputBox("Введите вместимоть рюкзака");
            if (res == "" || !float.TryParse(res, out capacity))
                bag = new Bag(50);
            else
                bag = new Bag(capacity);
            things = new Things();
            ResulttextBox.ScrollBars = ScrollBars.Vertical;
        }

        //Получение информации с формы ввода
        public void GetInfo (string name, float weight, float cost)
        {
            //Создание новой вещи и ее добавления в коллекцию  
            OneThing oneThing = new OneThing(name, weight, cost);
            things.Add(oneThing);
            //Суммирование веса и обновление поля
            WeightofAllThings += weight;
            CurrentWeighttextBox.Text = WeightofAllThings.ToString();
            //Добавление вещи на textbox для всех вещей
            AlltextBox1.Text += oneThing.ToString() + Environment.NewLine ; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //при добавлении открывается форма для заполнения
        private void Addbutton_Click(object sender, EventArgs e)
        {
            (new InputForm()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Если суммарный вес вещей меньше вместимости сумки, оповещем пользователя и просто выводим их
            if (WeightofAllThings<=bag.Capacity)
            {
                MaintreeView.Enabled = false;
                MessageBox.Show("Общий вес вещей меньше вместимости сумки, поэтому оптимальная выборка - все вещи");
                for (int i=0; i<things.Count; ++i)
                {
                    ResulttextBox.Text += things[i].thing.ToString()+Environment.NewLine;
                }
            }
            else
            {
                //Иначе формируем набор
                Things mainthings = bag.PackOptimally(things, MaintreeView, ResulttextBox);
                //Переменные показывающие полученные вес и цену
                float sum = 0;
                float weight = 0;
                //Отделяем место
                ResulttextBox.Text +=Environment.NewLine
                    + "----------------------------------------" + Environment.NewLine;
                //Выводим на экран все вещи, вошедшие в выборку
                for (int i=0; i<mainthings.Count; ++i)
                {
                    sum += mainthings[i].thing.Cost;
                    weight += mainthings[i].thing.Weight;
                    ResulttextBox.Text += mainthings[i].thing.ToString() + Environment.NewLine;
                }
                //Выводим их общие вес и стоимость
                ResulttextBox.Text += "Итого : " + weight.ToString() + " кг" + Environment.NewLine
                    + "Стоимость : " + sum.ToString();

            }
        }
    }
}
