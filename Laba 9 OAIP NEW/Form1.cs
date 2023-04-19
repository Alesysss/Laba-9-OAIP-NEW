using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba_9_OAIP_NEW
{
    public partial class Form1 : Form
    {
        PointF[] pointFs = new PointF[3];
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            Pen pen = new Pen(Color.Black, 1);
            Init.bitmap = bitmap;
            Init.pen = pen;
            Init.pictureBox = pictureBox;
        }
        private Stack<Operator> operators = new Stack<Operator>();
        private Stack<Operand> operands = new Stack<Operand>();
        private Triangle figure;
        private bool flag;
        string Name;
        string Name1;

        private bool IsNotOperation(char item)
        {

            if (!(item == 'A' || item == 'T' || item == 'D' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                operators = new Stack<Operator>();
                operands = new Stack<Operand>();
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (IsNotOperation(textBox1.Text[i]))
                    {
                        if (!(Char.IsDigit(textBox1.Text[i])))
                        {
                            this.operands.Push(new Operand(textBox1.Text[i]));
                            continue;
                        }
                        else if (Char.IsDigit(textBox1.Text[i]))
                        {
                            if (flag)
                            {
                                this.operands.Push(new Operand(textBox1.Text[i]));
                            }
                            else
                            {
                                if (!(Char.IsDigit(textBox1.Text[i - 1])))
                                {
                                    this.operands.Push(new Operand(Convert.ToInt32(textBox1.Text[i])));
                                    continue;
                                }
                                this.operands.Push(new Operand(Convert.ToInt32(this.operands.Pop().value) + Convert.ToInt32(textBox1.Text[i])));
                            }
                            flag = false;
                            continue;
                        }
                    }
                    else if (textBox1.Text[i] == ',')
                    {
                        flag = true;
                        continue;
                    }

                    else if (textBox1.Text[i] == 'A')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBox1.Text[i]));
                        continue;
                    }
                    else if (textBox1.Text[i] == 'T')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBox1.Text[i]));
                        continue;
                    }
                    else if (textBox1.Text[i] == 'D')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBox1.Text[i]));
                        continue;
                    }
                    else if (textBox1.Text[i] == '(')
                    {
                        this.operators.Push(OperatorContainer.FindOperator(textBox1.Text[i]));
                    }
                    else if (textBox1.Text[i] == ')')
                    {
                        do
                        {
                            if (operators.Peek().symbolOperator == '(')
                            {
                                operators.Pop();
                                break;
                            }
                            if (operators.Count == 0)
                            {
                                break;
                            }
                        }
                        while (operators.Peek().symbolOperator != '(');
                    }
                }
                this.SelectingPerformingOperation(operators.Peek());//Я выбираю жить в КАИ :3r
            }
        }
        private void SelectingPerformingOperation(Operator op)
        {

            if (textBox1.Text[0] == 'A')
            {
                int y3 = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int x3 = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int y2 = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int x2 = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int y1 = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                int x1 = Convert.ToInt32(Convert.ToString(operands.Pop().value));
                Name1 = Convert.ToString(operands.Pop().value);

                if (x1 >= Init.pictureBox.Width || y1 >= Init.pictureBox.Height
                                || x2 >= Init.pictureBox.Width || y2 >= Init.pictureBox.Height
                                || x3 >= Init.pictureBox.Width || y3 >= Init.pictureBox.Height)
                { listBox1.Items.Add("Выходит за пределы экрана"); }
                else
                {
                    pointFs[0].X = x1;
                    pointFs[0].Y = y1;
                    pointFs[1].X = x2;
                    pointFs[1].Y = y2;
                    pointFs[2].X = x3;
                    pointFs[2].Y = y3;
                    listBox1.Items.Add(Name1 + " создан массив точек");
                }

                if (textBox1.Text[0] == 'T')
                {
                    Name1 = Convert.ToString(operands.Pop().value);
                    Name = Convert.ToString(operands.Pop().value);
                    ShapeContainer.figurelist.Add(figure);
                    figure.Draw();
                    ShapeContainer.AddFigure(figure);
                    listBox1.Items.Add(Name + " Треугольник успешно нарисован");
                }



                if (textBox1.Text[0] == 'D')
                {
                    Name = Convert.ToString(operands.Pop().value);
                    string deletename = "удалили фигуру " + Name + "\n";
                    if (ShapeContainer.FindFigure(Name) == null)
                    {
                        listBox1.Text += "Ошибка в данных\n";
                    }
                    else
                    {
                        ShapeContainer.FindFigure(Name).DeleteF(ShapeContainer.FindFigure(Name), true);
                        listBox1.Text += ShapeContainer.FindFigure(Name) + deletename;
                    }
                }


            }
        }
    }
}