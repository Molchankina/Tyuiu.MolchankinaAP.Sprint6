﻿
namespace Tyuiu.MolchankinaAP.Sprint6.Task0.V7
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
            textBoxTask_KES = new TextBox();
            pictureBoxFormula_KES = new PictureBox();
            groupBoxTask_KES = new GroupBox();
            groupBoxEnter_KES = new GroupBox();
            labelVarX_KES = new Label();
            textBoxVarX_KES = new TextBox();
            groupBoxResult_KES = new GroupBox();
            labelResult_KES = new Label();
            textBoxResult_KES = new TextBox();
            buttonResult_KES = new Button();
            buttonHelp_KES = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).BeginInit();
            groupBoxTask_KES.SuspendLayout();
            groupBoxEnter_KES.SuspendLayout();
            groupBoxResult_KES.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTask_KES
            // 
            textBoxTask_KES.Location = new Point(29, 29);
            textBoxTask_KES.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_KES.Multiline = true;
            textBoxTask_KES.Name = "textBoxTask_KES";
            textBoxTask_KES.ReadOnly = true;
            textBoxTask_KES.Size = new Size(265, 221);
            textBoxTask_KES.TabIndex = 0;
            textBoxTask_KES.TabStop = false;
            textBoxTask_KES.Text = "Вычислить выражение по формуле\r\n";
            // 
            // pictureBoxFormula_KES
            // 
            pictureBoxFormula_KES.InitialImage = null;
            pictureBoxFormula_KES.Location = new Point(321, 29);
            pictureBoxFormula_KES.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula_KES.Name = "pictureBoxFormula_KES";
            pictureBoxFormula_KES.Size = new Size(147, 93);
            pictureBoxFormula_KES.TabIndex = 1;
            pictureBoxFormula_KES.TabStop = false;
            // 
            // groupBoxTask_KES
            // 
            groupBoxTask_KES.Controls.Add(textBoxTask_KES);
            groupBoxTask_KES.Controls.Add(pictureBoxFormula_KES);
            groupBoxTask_KES.Location = new Point(26, 32);
            groupBoxTask_KES.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_KES.Name = "groupBoxTask_KES";
            groupBoxTask_KES.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_KES.Size = new Size(493, 288);
            groupBoxTask_KES.TabIndex = 2;
            groupBoxTask_KES.TabStop = false;
            groupBoxTask_KES.Text = "Условие:";
            groupBoxTask_KES.Enter += groupBoxTask_KES_Enter;
            // 
            // groupBoxEnter_KES
            // 
            groupBoxEnter_KES.Controls.Add(labelVarX_KES);
            groupBoxEnter_KES.Controls.Add(textBoxVarX_KES);
            groupBoxEnter_KES.Location = new Point(26, 343);
            groupBoxEnter_KES.Margin = new Padding(3, 4, 3, 4);
            groupBoxEnter_KES.Name = "groupBoxEnter_KES";
            groupBoxEnter_KES.Padding = new Padding(3, 4, 3, 4);
            groupBoxEnter_KES.Size = new Size(229, 175);
            groupBoxEnter_KES.TabIndex = 3;
            groupBoxEnter_KES.TabStop = false;
            groupBoxEnter_KES.Text = "Ввод данные";
            // 
            // labelVarX_KES
            // 
            labelVarX_KES.AutoSize = true;
            labelVarX_KES.Location = new Point(46, 60);
            labelVarX_KES.Name = "labelVarX_KES";
            labelVarX_KES.Size = new Size(114, 20);
            labelVarX_KES.TabIndex = 1;
            labelVarX_KES.Text = "Переменная X:";
            // 
            // textBoxVarX_KES
            // 
            textBoxVarX_KES.Location = new Point(46, 105);
            textBoxVarX_KES.Margin = new Padding(3, 4, 3, 4);
            textBoxVarX_KES.Name = "textBoxVarX_KES";
            textBoxVarX_KES.Size = new Size(114, 27);
            textBoxVarX_KES.TabIndex = 0;
            textBoxVarX_KES.KeyPress += textBoxVarX_KeyPressed;
            // 
            // groupBoxResult_KES
            // 
            groupBoxResult_KES.Controls.Add(labelResult_KES);
            groupBoxResult_KES.Controls.Add(textBoxResult_KES);
            groupBoxResult_KES.Location = new Point(290, 343);
            groupBoxResult_KES.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult_KES.Name = "groupBoxResult_KES";
            groupBoxResult_KES.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult_KES.Size = new Size(229, 177);
            groupBoxResult_KES.TabIndex = 4;
            groupBoxResult_KES.TabStop = false;
            groupBoxResult_KES.Text = "Вывод данных";
            // 
            // labelResult_KES
            // 
            labelResult_KES.AutoSize = true;
            labelResult_KES.Location = new Point(73, 60);
            labelResult_KES.Name = "labelResult_KES";
            labelResult_KES.Size = new Size(78, 20);
            labelResult_KES.TabIndex = 1;
            labelResult_KES.Text = "Результат:";
            // 
            // textBoxResult_KES
            // 
            textBoxResult_KES.Location = new Point(57, 105);
            textBoxResult_KES.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_KES.Name = "textBoxResult_KES";
            textBoxResult_KES.ReadOnly = true;
            textBoxResult_KES.Size = new Size(114, 27);
            textBoxResult_KES.TabIndex = 0;
            textBoxResult_KES.TextChanged += buttonResult_Click;
            // 
            // buttonResult_KES
            // 
            buttonResult_KES.Location = new Point(397, 540);
            buttonResult_KES.Margin = new Padding(3, 4, 3, 4);
            buttonResult_KES.Name = "buttonResult_KES";
            buttonResult_KES.Size = new Size(122, 49);
            buttonResult_KES.TabIndex = 5;
            buttonResult_KES.Text = "Вычислить";
            buttonResult_KES.UseVisualStyleBackColor = true;
            buttonResult_KES.Click += buttonResult_Click;
            // 
            // buttonHelp_KES
            // 
            buttonHelp_KES.BackColor = SystemColors.Control;
            buttonHelp_KES.FlatStyle = FlatStyle.Flat;
            buttonHelp_KES.Location = new Point(347, 540);
            buttonHelp_KES.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_KES.Name = "buttonHelp_KES";
            buttonHelp_KES.Size = new Size(42, 49);
            buttonHelp_KES.TabIndex = 6;
            buttonHelp_KES.Text = "?";
            buttonHelp_KES.UseVisualStyleBackColor = false;
            buttonHelp_KES.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(560, 617);
            Controls.Add(buttonHelp_KES);
            Controls.Add(buttonResult_KES);
            Controls.Add(groupBoxResult_KES);
            Controls.Add(groupBoxEnter_KES);
            Controls.Add(groupBoxTask_KES);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 7| Молчанкина А.П.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).EndInit();
            groupBoxTask_KES.ResumeLayout(false);
            groupBoxTask_KES.PerformLayout();
            groupBoxEnter_KES.ResumeLayout(false);
            groupBoxEnter_KES.PerformLayout();
            groupBoxResult_KES.ResumeLayout(false);
            groupBoxResult_KES.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTask_KES;
        private PictureBox pictureBoxFormula_KES;
        private GroupBox groupBoxTask_KES;
        private GroupBox groupBoxEnter_KES;
        private TextBox textBoxVarX_KES;
        private Label labelVarX_KES;
        private GroupBox groupBoxResult_KES;
        private TextBox textBoxResult_KES;
        private Label labelResult_KES;
        private Button buttonResult_KES;
        private Button buttonHelp_KES;
    }
}
