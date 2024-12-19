using Tyuiu.MolchankinaAP.Sprint6.Task1.V15.Lib;
namespace Tyuiu.MolchankinaAP.Sprint6.Task1.V15

{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxsj_MAP.Text);
                int stopStep = Convert.ToInt32(textBox4_MAP.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                MAP.Text = "";
                MAP.AppendText("+----------+------------+" + Environment.NewLine);
                MAP.AppendText("|    X     |     f(x)   |" + Environment.NewLine);
                MAP.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,7:f2}    |", startStep, valueArray[i]);
                    MAP.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                MAP.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("??????? ???????? ??????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("???? 1 ???????? ??????? ?????? ?????-24-1 ???????? ??????? ?????????????", "?????????", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeComponent()
        {
            groupBoxgK_MAP = new GroupBox();
            textBox9_MAP = new TextBox();
            groupBoxgh_MAP = new GroupBox();
            MAP = new TextBox();
            groupBoxhg_MAP = new GroupBox();
            textBox4_MAP = new TextBox();
            textBoxsj_MAP = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            buttonty_MAP = new Button();
            button2_MAP = new Button();
            groupBoxgK_MAP.SuspendLayout();
            groupBoxgh_MAP.SuspendLayout();
            groupBoxhg_MAP.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxgK_MAP
            // 
            groupBoxgK_MAP.Controls.Add(textBox9_MAP);
            groupBoxgK_MAP.Location = new Point(12, 0);
            groupBoxgK_MAP.Name = "groupBoxgK_MAP";
            groupBoxgK_MAP.Size = new Size(576, 369);
            groupBoxgK_MAP.TabIndex = 0;
            groupBoxgK_MAP.TabStop = false;
            groupBoxgK_MAP.Text = "Условие";
            // 
            // textBox9_MAP
            // 
            textBox9_MAP.BackColor = SystemColors.Control;
            textBox9_MAP.Location = new Point(0, 26);
            textBox9_MAP.Multiline = true;
            textBox9_MAP.Name = "textBox9_MAP";
            textBox9_MAP.Size = new Size(576, 343);
            textBox9_MAP.TabIndex = 0;
            textBox9_MAP.Text = "Протабулировать функцию f(x) на заданном диапозоне\r\nРезультат вывести в виде таблицы";
            // 
            // groupBoxgh_MAP
            // 
            groupBoxgh_MAP.Controls.Add(MAP);
            groupBoxgh_MAP.Location = new Point(594, 0);
            groupBoxgh_MAP.Name = "groupBoxgh_MAP";
            groupBoxgh_MAP.Size = new Size(299, 472);
            groupBoxgh_MAP.TabIndex = 1;
            groupBoxgh_MAP.TabStop = false;
            groupBoxgh_MAP.Text = "Вывод данных";
            groupBoxgh_MAP.Enter += groupBoxgh_MAP_Enter;
            // 
            // MAP
            // 
            MAP.BackColor = SystemColors.Control;
            MAP.Location = new Point(22, 26);
            MAP.Name = "MAP";
            MAP.Size = new Size(260, 27);
            MAP.TabIndex = 0;
            MAP.Text = "Результат";
            // 
            // groupBoxhg_MAP
            // 
            groupBoxhg_MAP.Controls.Add(textBox4_MAP);
            groupBoxhg_MAP.Controls.Add(textBoxsj_MAP);
            groupBoxhg_MAP.Controls.Add(textBox2);
            groupBoxhg_MAP.Controls.Add(textBox1);
            groupBoxhg_MAP.Location = new Point(12, 375);
            groupBoxhg_MAP.Name = "groupBoxhg_MAP";
            groupBoxhg_MAP.Size = new Size(304, 98);
            groupBoxhg_MAP.TabIndex = 2;
            groupBoxhg_MAP.TabStop = false;
            groupBoxhg_MAP.Text = "Ввод данных";
            // 
            // textBox4_MAP
            // 
            textBox4_MAP.Location = new Point(160, 61);
            textBox4_MAP.Name = "textBox4_MAP";
            textBox4_MAP.Size = new Size(129, 27);
            textBox4_MAP.TabIndex = 3;
            textBox4_MAP.Text = "5";
            // 
            // textBoxsj_MAP
            // 
            textBoxsj_MAP.Location = new Point(9, 61);
            textBoxsj_MAP.Name = "textBoxsj_MAP";
            textBoxsj_MAP.Size = new Size(132, 27);
            textBoxsj_MAP.TabIndex = 2;
            textBoxsj_MAP.Text = "-5";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(160, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Конец шага:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(9, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Старт шага:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonty_MAP
            // 
            buttonty_MAP.BackColor = SystemColors.Highlight;
            buttonty_MAP.ForeColor = SystemColors.ActiveCaptionText;
            buttonty_MAP.Location = new Point(322, 386);
            buttonty_MAP.Name = "buttonty_MAP";
            buttonty_MAP.Size = new Size(107, 87);
            buttonty_MAP.TabIndex = 0;
            buttonty_MAP.Text = "Справка";
            buttonty_MAP.UseVisualStyleBackColor = false;
            buttonty_MAP.Click += buttonty_MAP_Click;
            // 
            // button2_MAP
            // 
            button2_MAP.BackColor = Color.FromArgb(0, 192, 0);
            button2_MAP.Location = new Point(435, 386);
            button2_MAP.Name = "button2_MAP";
            button2_MAP.Size = new Size(153, 87);
            button2_MAP.TabIndex = 3;
            button2_MAP.Text = "Выполнить";
            button2_MAP.UseVisualStyleBackColor = false;
            button2_MAP.Click += button2_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(905, 484);
            Controls.Add(button2_MAP);
            Controls.Add(buttonty_MAP);
            Controls.Add(groupBoxhg_MAP);
            Controls.Add(groupBoxgh_MAP);
            Controls.Add(groupBoxgK_MAP);
            Name = "FormMain";
            Text = "Спринт 6 Таск 1 Вариант 15 Молчанкина А.П.";
            Load += FormMain_Load;
            groupBoxgK_MAP.ResumeLayout(false);
            groupBoxgK_MAP.PerformLayout();
            groupBoxgh_MAP.ResumeLayout(false);
            groupBoxgh_MAP.PerformLayout();
            groupBoxhg_MAP.ResumeLayout(false);
            groupBoxhg_MAP.PerformLayout();
            ResumeLayout(false);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonty_MAP_Click(object sender, EventArgs e)
        {

        }

        private void list_MAP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxgh_MAP_Enter(object sender, EventArgs e)
        {

        }
    }
}
