using System.Windows.Forms;

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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}