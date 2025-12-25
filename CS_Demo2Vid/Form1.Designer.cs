namespace CS_Demo2Vid
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Demo .json";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Player";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(504, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(95, 127);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(504, 214);
            listBox1.TabIndex = 5;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "Output folder";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(423, 23);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(524, 35);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(524, 65);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 364);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "CS Demo2Vid";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog1;
    }
}
