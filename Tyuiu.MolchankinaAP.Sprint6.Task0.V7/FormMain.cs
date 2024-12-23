﻿using Tyuiu.MolchankinaAP.Sprint6.Task0.V7.Lib;

namespace Tyuiu.MolchankinaAP.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KES.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KES.Text)));
            }
            catch
            {
                MessageBox.Show("Íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) e.Handled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÀÑÎèÓá-24-1 Êîðîëåâ Å.Ñ.", "Ñïðàâêà");
        }

        private void groupBoxTask_KES_Enter(object sender, EventArgs e)
        {

        }
    }
}
