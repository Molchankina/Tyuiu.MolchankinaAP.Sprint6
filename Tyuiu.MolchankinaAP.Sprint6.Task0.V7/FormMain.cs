using Tyuiu.MolchankinaAP.Sprint6.Task0.V7.Lib;

namespace Tyuiu.MolchankinaAP.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_IAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_IAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_IAA.Text)));
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибкка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_IAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÑÌÀÐÒá-24-1 Ìèëþòèí Íèêèòà Äìèòðèèåâè÷", "Ñîîáùåíèå");
        }
        //Ð
        private void textBoxVarX_IAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_IAA_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
