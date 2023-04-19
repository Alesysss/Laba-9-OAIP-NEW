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
            pictureBox = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(32, 94);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1101, 523);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 13);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 1;
            label1.Text = "Командная строка";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(1152, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(306, 604);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1470, 667);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
    }
}