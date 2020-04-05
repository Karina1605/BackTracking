using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Класс одной вещи, свойства: Имя, вес и стоимость
    /// </summary>
    class OneThing
    {
        public string Name { get; set; }
        public readonly float Weight;
        public float Cost { get; set; }
        public OneThing(string Name, float Weight, float Cost)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Cost = Cost;
        }
        public override string ToString()
        {
            return Name + ", Вес(кг): " + Weight.ToString() +
                ", Стоимость: " + Cost.ToString();
        }
        
    }
}
