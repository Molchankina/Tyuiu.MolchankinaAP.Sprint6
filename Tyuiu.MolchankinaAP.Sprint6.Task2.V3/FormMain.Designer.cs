namespace Tyuiu.MolchankinaAP.Sprint6.Task2.V3
{
    partial class FormMain
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
            groupBox1_MAP = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2_MAP = new GroupBox();
            groupBox4_MAP = new GroupBox();
            textBox2_MAP = new TextBox();
            groupBox3_MAP = new GroupBox();
            textBox1_MAP = new TextBox();
            button1_MAP = new Button();
            button2_MAP = new Button();
            groupBoxKVK_MAP = new GroupBox();
            groupBox1_MAP.SuspendLayout();
            groupBox2_MAP.SuspendLayout();
            groupBox4_MAP.SuspendLayout();
            groupBox3_MAP.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1_MAP
            // 
            groupBox1_MAP.Controls.Add(groupBox1);
            groupBox1_MAP.Location = new Point(13, 15);
            groupBox1_MAP.Name = "groupBox1_MAP";
            groupBox1_MAP.Size = new Size(562, 302);
            groupBox1_MAP.TabIndex = 0;
            groupBox1_MAP.TabStop = false;
            groupBox1_MAP.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(568, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 122);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2_MAP
            // 
            groupBox2_MAP.Controls.Add(groupBox4_MAP);
            groupBox2_MAP.Controls.Add(groupBox3_MAP);
            groupBox2_MAP.Location = new Point(12, 323);
            groupBox2_MAP.Name = "groupBox2_MAP";
            groupBox2_MAP.Size = new Size(345, 104);
            groupBox2_MAP.TabIndex = 1;
            groupBox2_MAP.TabStop = false;
            groupBox2_MAP.Text = "Ввод данных";
            // 
            // groupBox4_MAP
            // 
            groupBox4_MAP.Controls.Add(textBox2_MAP);
            groupBox4_MAP.Location = new Point(172, 20);
            groupBox4_MAP.Name = "groupBox4_MAP";
            groupBox4_MAP.Size = new Size(167, 78);
            groupBox4_MAP.TabIndex = 1;
            groupBox4_MAP.TabStop = false;
            groupBox4_MAP.Text = "Конец шага";
            // 
            // textBox2_MAP
            // 
            textBox2_MAP.Location = new Point(6, 42);
            textBox2_MAP.Name = "textBox2_MAP";
            textBox2_MAP.Size = new Size(155, 27);
            textBox2_MAP.TabIndex = 0;
            textBox2_MAP.Text = "5";
            // 
            // groupBox3_MAP
            // 
            groupBox3_MAP.Controls.Add(textBox1_MAP);
            groupBox3_MAP.Location = new Point(6, 20);
            groupBox3_MAP.Name = "groupBox3_MAP";
            groupBox3_MAP.Size = new Size(159, 78);
            groupBox3_MAP.TabIndex = 0;
            groupBox3_MAP.TabStop = false;
            groupBox3_MAP.Text = "Старт шага";
            // 
            // textBox1_MAP
            // 
            textBox1_MAP.Location = new Point(7, 42);
            textBox1_MAP.Name = "textBox1_MAP";
            textBox1_MAP.Size = new Size(145, 27);
            textBox1_MAP.TabIndex = 0;
            textBox1_MAP.Text = "-5";
            textBox1_MAP.TextChanged += textBox1_TextChanged;
            // 
            // button1_MAP
            // 
            button1_MAP.BackColor = Color.DeepSkyBlue;
            button1_MAP.Location = new Point(363, 343);
            button1_MAP.Name = "button1_MAP";
            button1_MAP.Size = new Size(94, 78);
            button1_MAP.TabIndex = 2;
            button1_MAP.Text = "Справка";
            button1_MAP.UseVisualStyleBackColor = false;
            // 
            // button2_MAP
            // 
            button2_MAP.BackColor = Color.Green;
            button2_MAP.Location = new Point(460, 343);
            button2_MAP.Name = "button2_MAP";
            button2_MAP.Size = new Size(115, 78);
            button2_MAP.TabIndex = 3;
            button2_MAP.Text = "Выполнить";
            button2_MAP.UseVisualStyleBackColor = false;
            button2_MAP.Click += button2_MAP_Click;
            // 
            // groupBoxKVK_MAP
            // 
            groupBoxKVK_MAP.Location = new Point(580, 15);
            groupBoxKVK_MAP.Name = "groupBoxKVK_MAP";
            groupBoxKVK_MAP.Size = new Size(483, 418);
            groupBoxKVK_MAP.TabIndex = 4;
            groupBoxKVK_MAP.TabStop = false;
            groupBoxKVK_MAP.Text = "Вывод данных";
            groupBoxKVK_MAP.Enter += groupBoxKVK_MAP_Enter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 445);
            Controls.Add(groupBoxKVK_MAP);
            Controls.Add(button2_MAP);
            Controls.Add(button1_MAP);
            Controls.Add(groupBox2_MAP);
            Controls.Add(groupBox1_MAP);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1_MAP.ResumeLayout(false);
            groupBox2_MAP.ResumeLayout(false);
            groupBox4_MAP.ResumeLayout(false);
            groupBox4_MAP.PerformLayout();
            groupBox3_MAP.ResumeLayout(false);
            groupBox3_MAP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1_MAP;
        private GroupBox groupBox2_MAP;
        private GroupBox groupBox4_MAP;
        private GroupBox groupBox3_MAP;
        private TextBox textBox1_MAP;
        private TextBox textBox2_MAP;
        private Button button1_MAP;
        private Button button2_MAP;
        private GroupBox groupBox1;
        private GroupBox groupBoxKVK_MAP;
    }
}