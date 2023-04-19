namespace Laba_9_OAIP_NEW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(120, 190);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(671, 462);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 1;
            label1.Text = "Командная строка";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCoral;
            textBox1.Location = new Point(12, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(842, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(1097, 344);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 104);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 606);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1035, 266);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(453, 412);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCoral;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Maroon;
            groupBox1.Location = new Point(989, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 188);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Допустимые команды";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 61);
            label2.Name = "label2";
            label2.Size = new Size(483, 29);
            label2.TabIndex = 0;
            label2.Text = "A(m,x1,y1,x2,y2,x3,y3) - создание массива точек";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 102);
            label3.Name = "label3";
            label3.Size = new Size(332, 29);
            label3.TabIndex = 1;
            label3.Text = "T(t,m) - создание треугольника";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 141);
            label4.Name = "label4";
            label4.Size = new Size(310, 29);
            label4.TabIndex = 2;
            label4.Text = "D(t) - удаление треугольника";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(806, 454);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(223, 319);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(855, 301);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(178, 147);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1532, 704);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}