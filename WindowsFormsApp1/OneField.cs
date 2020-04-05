using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Перечисление - состояние одной вещи в множетсве (выбрана уже или нет)
    /// </summary>
    enum Condition { Free, Chosen}
    /// <summary>
    /// Класс поле списка, состоит из самой вещи и ее состояния
    /// </summary>
    class OneField
    {
        public OneThing thing { get; set; }
        public Condition condition { get; set; }

        //Получить стоимость вещи
        public float GetCost() { return thing.Cost; }
        //Получить вес вещи
        public float GetWeight() { return thing.Weight; }
        public OneField(string ThingName, string ThingWeight, string ThingCost)
        {
            thing = new OneThing(ThingName, int.Parse(ThingWeight), int.Parse(ThingCost));
            condition = Condition.Free;
        }
        public OneField(OneThing thing)
        {
            this.thing = thing;
            condition = Condition.Free;
        }
    }
    /// <summary>
    /// Класс, представляющий собой набор вещей
    /// </summary>
    class Things
    {
        List<OneField> things;
        public Things() { things = new List<OneField>(); }
        //Добавить вещь
        public void Add (OneThing newNode)
        {
            things.Add(new OneField(newNode));
        }
        //Индексатор для домупа к произвольной вещи
        public OneField this [int i]
        {
            get
            {
                return things.ElementAt(i);
            }
        }
        public int Count { get { return things.Count; } }
    }
    /// <summary>
    /// Класс сумки, на вход поступает конструктор с вместимостью сумки
    /// </summary>
    class Bag
    {
        //Вместимость сумки
        public readonly float Capacity;
        //Текущая сумма всех вещей в сумке
        public float CurCost { get; private set; }
        public Bag (float Capacity)
        {
            this.Capacity = Capacity;
            CurCost = 0;
        }
        //Функция получающая на ход набор вещей, возвращающая набор вещей максимальной стоимости для веса рюкзака
        public Things PackOptimally (Things things, TreeView main, TextBox result)
        {
            //Счетчики текущих цены и веса в проуессе подсчета
            float currCost = 0;
            float currWeight=0;
            //Список из инексов включенных в текущую выборку
            List<int> indexes = new List<int>();
            //Список из индексов эл-тов, сумма которых максимальна
            List<int> final = new List<int>();
            //Корень дерева для визуализации
            TreeNode root=null;
            //Внутренняя функция генерации следующего шага. Задача сводится к поиску оптимальной неупорядоченной
            //выборки без повторений, следовательно, оптимальный обход и подбор будет происходить по порядку
            //на вход подается позиция с которой нужно начать цикл
            void tryNextStep(int start)
            {
                //Если мы дошли до конца, то нужно просто проверить превосодить полученная сумма максимальную
                if (start == things.Count)
                {
                    //Если да, то обновляем значения
                    if (CurCost < currCost)
                    {
                        //Обновляем максимум
                        CurCost = currCost;
                        //Обновляем выборку, вместе с тем, отчет о промежуточном максимуме выводим на экран
                        final.Clear();
                        for (int j = 0; j < indexes.Count; ++j)
                        {
                            final.Add(indexes.ElementAt(j));
                            result.Text += things[indexes.ElementAt(j)].thing.ToString()
                                + Environment.NewLine;
                        }
                        result.Text += "Промежуточный вес : " + currWeight.ToString() + Environment.NewLine +
                        "Промежуточная стоимость : " + CurCost.ToString() + Environment.NewLine +
                        "----------------------------------------" + Environment.NewLine;
                    }
                    return;
                }
                //Иначе идем до конца списка
                for (int i = start;  i<things.Count; ++i)
                {
                    //Выбираем свободный элемент
                    if (things[i].condition == Condition.Free)
                    {
                        //Если его включение приемлемо
                        if (things[i].GetWeight() + currWeight <= Capacity)
                        {
                            //Добавляем в выборку
                            indexes.Add(i);
                            //Прибавляем к общему весу и общей стоимости
                            currWeight += things[i].GetWeight();
                            currCost += things[i].GetCost();
                            //Генерируем узел дерева
                            start -= 1;
                            if (start == -1)
                                start = 0;
                            //Создаем строку узла W - текущий суммарный вес, C - текущая общая стоимость
                            string s = things[i].thing.Name+", W= "+currWeight.ToString()+", C= "+currCost.ToString();
                            //Создаем узел дерева и добавляем его
                            TreeNode one = new TreeNode(s);
                            if (root == null)
                                main.Nodes.Add(one);
                            else
                                root.Nodes.Add(one);
                            root = one;
                            //Меняем состояние на выбранное
                            things[i].condition = Condition.Chosen;
                            //Генерируем след. шаг
                            tryNextStep(i+1);

                            //"Откатываем назад", стираем запись, уменьшаем вес и сумму
                            currWeight -= things[i].GetWeight();
                            currCost -= things[i].GetCost();
                            root = root.Parent;
                            things[i].condition = Condition.Free;
                            indexes.Remove(i);
                        }
                        //Включение невозможно
                        else
                        //Проверяем, превосходит ли полученная выборка стоимость максимальной
                            if (CurCost < currCost)
                            {
                                //Если да, обновляем данные
                                CurCost = currCost;
                                final.Clear();
                                 for (int j = 0; j < indexes.Count; ++j)
                                 {
                                        final.Add(indexes.ElementAt(j));
                                        result.Text += things[indexes.ElementAt(j)].thing.ToString()
                                            + Environment.NewLine;
                                 }
                                result.Text += "Промежуточный вес : "+currWeight.ToString()+Environment.NewLine+
                                "Промежуточная стоимость : "+CurCost.ToString()+Environment.NewLine+
                                "----------------------------------------" + Environment.NewLine;
                            }   
                    }
                }

            }
            //Запускаем генерацию сначала
            tryNextStep(0);
            //Формариуем результирующий список вещей
            Things res = new Things();
            for (int i=0; i<final.Count; ++i)
                res.Add(things[final.ElementAt(i)].thing);
            return res;
        }        
    }
}
