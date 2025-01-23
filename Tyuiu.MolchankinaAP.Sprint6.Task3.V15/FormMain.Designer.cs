namespace Tyuiu.MolchankinaAP.Sprint6.Task3.V15
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
            groupBoxTask_MAP = new GroupBox();
            textBoxTask_MAP = new TextBox();
            groupBoxOutput_MAP = new GroupBox();
            buttonHelp_MAP = new Button();
            buttonExecute_MAP = new Button();
            dataGridViewMatrix_MAP = new DataGridView();
            labelResult_MAP = new Label();
            groupBoxTask_MAP.SuspendLayout();
            groupBoxOutput_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MAP).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_MAP
            // 
            groupBoxTask_MAP.Controls.Add(textBoxTask_MAP);
            groupBoxTask_MAP.Location = new Point(12, 12);
            groupBoxTask_MAP.Name = "groupBoxTask_MAP";
            groupBoxTask_MAP.Size = new Size(543, 378);
            groupBoxTask_MAP.TabIndex = 2;
            groupBoxTask_MAP.TabStop = false;
            groupBoxTask_MAP.Text = "Условие";
            // 
            // textBoxTask_MAP
            // 
            textBoxTask_MAP.Location = new Point(6, 26);
            textBoxTask_MAP.Multiline = true;
            textBoxTask_MAP.Name = "textBoxTask_MAP";
            textBoxTask_MAP.ReadOnly = true;
            textBoxTask_MAP.Size = new Size(531, 346);
            textBoxTask_MAP.TabIndex = 0;
            // 
            // groupBoxOutput_MAP
            // 
            groupBoxOutput_MAP.Controls.Add(buttonHelp_MAP);
            groupBoxOutput_MAP.Controls.Add(buttonExecute_MAP);
            groupBoxOutput_MAP.Controls.Add(dataGridViewMatrix_MAP);
            groupBoxOutput_MAP.Controls.Add(labelResult_MAP);
            groupBoxOutput_MAP.Location = new Point(561, 12);
            groupBoxOutput_MAP.Name = "groupBoxOutput_MAP";
            groupBoxOutput_MAP.Size = new Size(303, 378);
            groupBoxOutput_MAP.TabIndex = 7;
            groupBoxOutput_MAP.TabStop = false;
            groupBoxOutput_MAP.Text = "Вывод данных";
            // 
            // buttonHelp_MAP
            // 
            buttonHelp_MAP.Location = new Point(150, 343);
            buttonHelp_MAP.Name = "buttonHelp_MAP";
            buttonHelp_MAP.Size = new Size(29, 29);
            buttonHelp_MAP.TabIndex = 3;
            buttonHelp_MAP.Text = "?";
            buttonHelp_MAP.UseVisualStyleBackColor = true;
            // 
            // buttonExecute_MAP
            // 
            buttonExecute_MAP.Location = new Point(185, 343);
            buttonExecute_MAP.Name = "buttonExecute_MAP";
            buttonExecute_MAP.Size = new Size(112, 29);
            buttonExecute_MAP.TabIndex = 2;
            buttonExecute_MAP.Text = "Выполнить";
            buttonExecute_MAP.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMatrix_MAP
            // 
            dataGridViewMatrix_MAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix_MAP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewMatrix_MAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_MAP.ColumnHeadersVisible = false;
            dataGridViewMatrix_MAP.Location = new Point(6, 49);
            dataGridViewMatrix_MAP.Name = "dataGridViewMatrix_MAP";
            dataGridViewMatrix_MAP.RowHeadersVisible = false;
            dataGridViewMatrix_MAP.RowHeadersWidth = 20;
            dataGridViewMatrix_MAP.Size = new Size(291, 288);
            dataGridViewMatrix_MAP.TabIndex = 1;
            dataGridViewMatrix_MAP.CellContentClick += dataGridViewMatrix_MAP_CellContentClick;
            // 
            // labelResult_MAP
            // 
            labelResult_MAP.AutoSize = true;
            labelResult_MAP.Location = new Point(6, 26);
            labelResult_MAP.Name = "labelResult_MAP";
            labelResult_MAP.Size = new Size(78, 20);
            labelResult_MAP.TabIndex = 0;
            labelResult_MAP.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 402);
            Controls.Add(groupBoxOutput_MAP);
            Controls.Add(groupBoxTask_MAP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 15 | Гридин А. Е.";
            Load += FormMain_Load;
            groupBoxTask_MAP.ResumeLayout(false);
            groupBoxTask_MAP.PerformLayout();
            groupBoxOutput_MAP.ResumeLayout(false);
            groupBoxOutput_MAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MAP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxTask_MAP;
        private TextBox textBoxTask_MAP;
        private GroupBox groupBoxOutput_MAP;
        private Button buttonHelp_MAP;
        private Button buttonExecute_MAP;
        private DataGridView dataGridViewMatrix_MAP;
        private Label labelResult_MAP;
    }
}
