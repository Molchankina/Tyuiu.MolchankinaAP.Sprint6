using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace Tyuiu.MolchankinaAP.Sprint6.Task4.V18
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
            textBoxDone = new TextBox();
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            groupBoxInput = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxDone
            // 
            textBoxDone.Location = new Point(14, 120);
            textBoxDone.Margin = new Padding(3, 4, 3, 4);
            textBoxDone.Multiline = true;
            textBoxDone.Name = "textBoxDone";
            textBoxDone.Size = new Size(229, 525);
            textBoxDone.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(30, 59);
            textBoxStart.Margin = new Padding(3, 4, 3, 4);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(114, 27);
            textBoxStart.TabIndex = 2;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(162, 59);
            textBoxEnd.Margin = new Padding(3, 4, 3, 4);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(114, 27);
            textBoxEnd.TabIndex = 3;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(192, 192, 255);
            buttonDone.Location = new Point(666, 35);
            buttonDone.Margin = new Padding(3, 4, 3, 4);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(89, 77);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(255, 192, 192);
            buttonSave.Location = new Point(762, 35);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(89, 77);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(255, 224, 192);
            buttonHelp.Location = new Point(858, 35);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(89, 77);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBox2);
            groupBoxInput.Controls.Add(textBox1);
            groupBoxInput.Controls.Add(textBoxEnd);
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Location = new Point(366, 15);
            groupBoxInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput.Size = new Size(294, 97);
            groupBoxInput.TabIndex = 7;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(162, 29);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 20);
            textBox2.TabIndex = 9;
            textBox2.Text = "Конец";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(30, 29);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 20);
            textBox1.TabIndex = 8;
            textBox1.Text = "Начало";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(15, 3);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(344, 109);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 663);
            Controls.Add(groupBox1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(textBoxDone);
            Controls.Add(groupBoxInput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 18 | Кулько.Д.А";
            Load += FormMain_Load;
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxDone;
        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonHelp;
        private GroupBox groupBoxInput;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox1;
    }
}
