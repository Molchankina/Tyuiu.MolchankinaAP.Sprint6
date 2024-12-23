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
            groupBoxviv_MAP = new GroupBox();
            textBoxResult_MAP = new TextBox();
            dataGrid_MAP = new DataGridView();
            buttonHelpClick_MAP = new Button();
            groupBoxTask_MAP = new GroupBox();
            pictureBox1_MAP = new PictureBox();
            buttonStrt_MAP = new Button();
            groupBoxviv_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_MAP).BeginInit();
            groupBoxTask_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_MAP).BeginInit();
            SuspendLayout();
            // 
            // groupBoxviv_MAP
            // 
            groupBoxviv_MAP.Controls.Add(textBoxResult_MAP);
            groupBoxviv_MAP.Location = new Point(811, 12);
            groupBoxviv_MAP.Name = "groupBoxviv_MAP";
            groupBoxviv_MAP.Size = new Size(261, 89);
            groupBoxviv_MAP.TabIndex = 29;
            groupBoxviv_MAP.TabStop = false;
            groupBoxviv_MAP.Text = "Вывод данных";
            groupBoxviv_MAP.Enter += groupBoxviv_MAP_Enter;
            // 
            // textBoxResult_MAP
            // 
            textBoxResult_MAP.Location = new Point(52, 35);
            textBoxResult_MAP.Name = "textBoxResult_MAP";
            textBoxResult_MAP.ReadOnly = true;
            textBoxResult_MAP.Size = new Size(153, 27);
            textBoxResult_MAP.TabIndex = 1;
            // 
            // dataGrid_MAP
            // 
            dataGrid_MAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_MAP.Location = new Point(409, 26);
            dataGrid_MAP.Name = "dataGrid_MAP";
            dataGrid_MAP.RowHeadersVisible = false;
            dataGrid_MAP.RowHeadersWidth = 51;
            dataGrid_MAP.Size = new Size(365, 337);
            dataGrid_MAP.TabIndex = 0;
            dataGrid_MAP.CellContentClick += dataGrid_tia_CellContentClick;
            // 
            // buttonHelpClick_MAP
            // 
            buttonHelpClick_MAP.BackColor = SystemColors.ControlDark;
            buttonHelpClick_MAP.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_MAP.Location = new Point(811, 338);
            buttonHelpClick_MAP.Name = "buttonHelpClick_MAP";
            buttonHelpClick_MAP.Size = new Size(54, 51);
            buttonHelpClick_MAP.TabIndex = 27;
            buttonHelpClick_MAP.Text = "?";
            buttonHelpClick_MAP.UseVisualStyleBackColor = false;
            buttonHelpClick_MAP.Click += buttonHelpClick_tia_Click;
            // 
            // groupBoxTask_MAP
            // 
            groupBoxTask_MAP.Controls.Add(pictureBox1_MAP);
            groupBoxTask_MAP.Controls.Add(dataGrid_MAP);
            groupBoxTask_MAP.Location = new Point(12, 12);
            groupBoxTask_MAP.Name = "groupBoxTask_MAP";
            groupBoxTask_MAP.Size = new Size(793, 377);
            groupBoxTask_MAP.TabIndex = 26;
            groupBoxTask_MAP.TabStop = false;
            groupBoxTask_MAP.Text = "Условия";
            // 
            // pictureBox1_MAP
            // 
            pictureBox1_MAP.Location = new Point(15, 26);
            pictureBox1_MAP.Name = "pictureBox1_MAP";
            pictureBox1_MAP.Size = new Size(404, 337);
            pictureBox1_MAP.TabIndex = 1;
            pictureBox1_MAP.TabStop = false;
            pictureBox1_MAP.Click += pictureBox1_tia_Click;
            // 
            // buttonStrt_MAP
            // 
            buttonStrt_MAP.BackColor = SystemColors.ControlDark;
            buttonStrt_MAP.Location = new Point(926, 338);
            buttonStrt_MAP.Name = "buttonStrt_MAP";
            buttonStrt_MAP.Size = new Size(146, 51);
            buttonStrt_MAP.TabIndex = 25;
            buttonStrt_MAP.Text = "Выполнить";
            buttonStrt_MAP.UseVisualStyleBackColor = false;
            buttonStrt_MAP.Click += buttonStrt_tia_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 401);
            Controls.Add(groupBoxviv_MAP);
            Controls.Add(buttonHelpClick_MAP);
            Controls.Add(groupBoxTask_MAP);
            Controls.Add(buttonStrt_MAP);
            Name = "FormMain";
            Text = "Спринт6|Таск3|Вариант15|Тясин И.А.";
            Load += FormMain_Load;
            groupBoxviv_MAP.ResumeLayout(false);
            groupBoxviv_MAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_MAP).EndInit();
            groupBoxTask_MAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1_MAP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxviv_MAP = new GroupBox();
            textBoxResult_MAP = new TextBox();
            dataGrid_MAP = new DataGridView();
            buttonHelpClick_MAP = new Button();
            groupBoxTask = new GroupBox();
            pictureBox1_tia = new PictureBox();
            buttonStrt_tia = new Button();
            groupBoxviv_tia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_tia).BeginInit();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_tia).BeginInit();
            SuspendLayout();
            // 
            // groupBoxviv_tia
            // 
            groupBoxviv_tia.Controls.Add(textBoxResult_tia);
            groupBoxviv_tia.Controls.Add(dataGrid_tia);
            groupBoxviv_tia.Location = new Point(952, 12);
            groupBoxviv_tia.Name = "groupBoxviv_tia";
            groupBoxviv_tia.Size = new Size(570, 694);
            groupBoxviv_tia.TabIndex = 29;
            groupBoxviv_tia.TabStop = false;
            groupBoxviv_tia.Text = "Результат";
            // 
            // textBoxResult_tia
            // 
            textBoxResult_tia.Location = new Point(147, 645);
            textBoxResult_tia.Name = "textBoxResult_tia";
            textBoxResult_tia.ReadOnly = true;
            textBoxResult_tia.Size = new Size(250, 27);
            textBoxResult_tia.TabIndex = 1;
            // 
            // dataGrid_tia
            // 
            dataGrid_tia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_tia.Location = new Point(29, 39);
            dataGrid_tia.Name = "dataGrid_tia";
            dataGrid_tia.RowHeadersVisible = false;
            dataGrid_tia.RowHeadersWidth = 51;
            dataGrid_tia.Size = new Size(511, 571);
            dataGrid_tia.TabIndex = 0;
            dataGrid_tia.CellContentClick += dataGrid_tia_CellContentClick;
            // 
            // buttonHelpClick_tia
            // 
            buttonHelpClick_tia.BackColor = SystemColors.ControlDark;
            buttonHelpClick_tia.FlatStyle = FlatStyle.Flat;
            buttonHelpClick_tia.Location = new Point(197, 607);
            buttonHelpClick_tia.Name = "buttonHelpClick_tia";
            buttonHelpClick_tia.Size = new Size(218, 184);
            buttonHelpClick_tia.TabIndex = 27;
            buttonHelpClick_tia.Text = "?";
            buttonHelpClick_tia.UseVisualStyleBackColor = false;
            buttonHelpClick_tia.Click += buttonHelpClick_tia_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBox1_tia);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(883, 575);
            groupBoxTask.TabIndex = 26;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            // 
            // pictureBox1_tia
            // 
            pictureBox1_tia.Image = (Image)resources.GetObject("pictureBox1_tia.Image");
            pictureBox1_tia.Location = new Point(0, 39);
            pictureBox1_tia.Name = "pictureBox1_tia";
            pictureBox1_tia.Size = new Size(845, 455);
            pictureBox1_tia.TabIndex = 1;
            pictureBox1_tia.TabStop = false;
            pictureBox1_tia.Click += pictureBox1_tia_Click;
            // 
            // buttonStrt_tia
            // 
            buttonStrt_tia.BackColor = SystemColors.MenuHighlight;
            buttonStrt_tia.Location = new Point(477, 607);
            buttonStrt_tia.Name = "buttonStrt_tia";
            buttonStrt_tia.Size = new Size(316, 184);
            buttonStrt_tia.TabIndex = 25;
            buttonStrt_tia.Text = "Выполнить";
            buttonStrt_tia.UseVisualStyleBackColor = false;
            buttonStrt_tia.Click += buttonStrt_tia_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1568, 812);
            Controls.Add(groupBoxviv_tia);
            Controls.Add(buttonHelpClick_tia);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonStrt_tia);
            Name = "FormMain";
            Text = "Спринт6|Таск3|Вариант15|Тясин И.А.";
            Load += FormMain_Load;
            groupBoxviv_tia.ResumeLayout(false);
            groupBoxviv_tia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_tia).EndInit();
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1_tia).EndInit();
            ResumeLayout(false);
        }


        private GroupBox groupBoxviv_tia;
        private DataGridView dataGrid_tia;
        private Button buttonHelpClick_tia;
        private GroupBox groupBoxTask;
        private PictureBox pictureBox1_tia;
        private Button buttonStrt_tia;
        private TextBox textBoxResult_tia;

        private GroupBox groupBoxviv_MAP;
        private DataGridView dataGrid_MAP;
        private Button buttonHelpClick_MAP;
        private GroupBox groupBoxTask_MAP;
        private PictureBox pictureBox1_MAP;
        private Button buttonStrt_MAP;
        private TextBox textBoxResult_MAP;
    }
}
