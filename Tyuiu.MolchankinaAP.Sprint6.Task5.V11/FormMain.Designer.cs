using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.MolchankinaAP.Sprint6.Task5.V11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_MAP = new GroupBox();
            textBoxTask_MAP = new TextBox();
            buttonDone_MAP = new Button();
            buttonFile_MAP = new Button();
            buttonHelp_MAP = new Button();
            groupBoxVar_MAP = new GroupBox();
            dataGridViewResult_MAP = new DataGridView();
            chartResult_MAP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_MAP.SuspendLayout();
            groupBoxVar_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_MAP).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MAP
            // 
            groupBoxTask_MAP.Controls.Add(textBoxTask_MAP);
            groupBoxTask_MAP.Location = new Point(12, 12);
            groupBoxTask_MAP.Name = "groupBoxTask_MAP";
            groupBoxTask_MAP.Size = new Size(556, 112);
            groupBoxTask_MAP.TabIndex = 0;
            groupBoxTask_MAP.TabStop = false;
            groupBoxTask_MAP.Text = "Условие";
            // 
            // textBoxTask_MAP
            // 
            textBoxTask_MAP.Location = new Point(12, 26);
            textBoxTask_MAP.Multiline = true;
            textBoxTask_MAP.Name = "textBoxTask_MAP";
            textBoxTask_MAP.ReadOnly = true;
            textBoxTask_MAP.Size = new Size(541, 72);
            textBoxTask_MAP.TabIndex = 1;
            textBoxTask_MAP.Text = "Прочитать данные из файла InPutFileTask5V11.txt. Вывести все\r\nчисла кратные 5. Построить диаграмму по этим значениям. У \r\nвещественных значений округлить до трех знаков после запятой";
            // 
            // buttonDone_MAP
            // 
            buttonDone_MAP.BackColor = Color.PaleGreen;
            buttonDone_MAP.Location = new Point(574, 38);
            buttonDone_MAP.Name = "buttonDone_MAP";
            buttonDone_MAP.Size = new Size(108, 72);
            buttonDone_MAP.TabIndex = 1;
            buttonDone_MAP.Text = "Выполнить";
            buttonDone_MAP.UseVisualStyleBackColor = false;
            buttonDone_MAP.Click += buttonDone_MAP_Click;
            // 
            // buttonFile_MAP
            // 
            buttonFile_MAP.BackColor = Color.CornflowerBlue;
            buttonFile_MAP.Location = new Point(688, 38);
            buttonFile_MAP.Name = "buttonFile_MAP";
            buttonFile_MAP.Size = new Size(108, 72);
            buttonFile_MAP.TabIndex = 2;
            buttonFile_MAP.Text = "Открыть файл";
            buttonFile_MAP.UseVisualStyleBackColor = false;
            buttonFile_MAP.Click += buttonFile_MAP_Click;
            // 
            // buttonHelp_MAP
            // 
            buttonHelp_MAP.BackColor = Color.PaleTurquoise;
            buttonHelp_MAP.Location = new Point(802, 38);
            buttonHelp_MAP.Name = "buttonHelp_MAP";
            buttonHelp_MAP.Size = new Size(108, 72);
            buttonHelp_MAP.TabIndex = 3;
            buttonHelp_MAP.Text = "Справка";
            buttonHelp_MAP.UseVisualStyleBackColor = false;
            buttonHelp_MAP.Click += buttonHelp_MAP_Click;
            // 
            // groupBoxVar_MAP
            // 
            groupBoxVar_MAP.Controls.Add(dataGridViewResult_MAP);
            groupBoxVar_MAP.Location = new Point(12, 130);
            groupBoxVar_MAP.Name = "groupBoxVar_MAP";
            groupBoxVar_MAP.Size = new Size(250, 404);
            groupBoxVar_MAP.TabIndex = 4;
            groupBoxVar_MAP.TabStop = false;
            groupBoxVar_MAP.Text = "Вывод данных";
            // 
            // dataGridViewResult_MAP
            // 
            dataGridViewResult_MAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MAP.Location = new Point(3, 23);
            dataGridViewResult_MAP.Name = "dataGridViewResult_MAP";
            dataGridViewResult_MAP.RowHeadersWidth = 51;
            dataGridViewResult_MAP.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_MAP.Size = new Size(241, 375);
            dataGridViewResult_MAP.TabIndex = 0;
            // 
            // chartResult_MAP
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_MAP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult_MAP.Legends.Add(legend1);
            chartResult_MAP.Location = new Point(268, 130);
            chartResult_MAP.Name = "chartResult_MAP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_MAP.Series.Add(series1);
            chartResult_MAP.Size = new Size(642, 398);
            chartResult_MAP.TabIndex = 1;
            chartResult_MAP.Text = "chart1";
            // 
            // FormMain_MAP
            // 
            AutoScaMAPimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 546);
            Controls.Add(chartResult_MAP);
            Controls.Add(groupBoxVar_MAP);
            Controls.Add(buttonHelp_MAP);
            Controls.Add(buttonFile_MAP);
            Controls.Add(buttonDone_MAP);
            Controls.Add(groupBoxTask_MAP);
            Name = "FormMain_MAP";
            Text = "Спринт 6 | Таск 5 | Вариант 11 | Молчанкина А.П.";
            groupBoxTask_MAP.ResumeLayout(false);
            groupBoxTask_MAP.PerformLayout();
            groupBoxVar_MAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_MAP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MAP;
        private TextBox textBoxTask_MAP;
        private Button buttonDone_MAP;
        private Button buttonFile_MAP;
        private Button buttonHelp_MAP;
        private GroupBox groupBoxVar_MAP;
        private DataGridView dataGridViewResult_MAP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_MAP;
    }
}
