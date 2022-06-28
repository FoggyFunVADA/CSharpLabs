using System;
using System.Windows.Forms;

namespace ObjectsView
{
    public partial class InputForm : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public string Result { get; set; }

        public InputForm(string message)
        {
            InitializeComponent();
            InfoLabel.Text = message;
        }

        private void InputInfoButton_Click(object sender, EventArgs e)
        {
            if (InputInfo.Text == "")
                MessageBox.Show("Для начала введите данные!");
            else
            {
                Result = InputInfo.Text;
                this.Close();
            }
        }
    }
}
