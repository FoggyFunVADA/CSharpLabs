using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectsModel;
using ObjectsModel.Mechanics;

namespace ObjectsView
{
    public partial class MainForm : Form
    {
        const int MaxCountOfMechanics = 4;
        const int MaxCountOfOperators = 4;

        public List<CoordinatesForImage> ViewObjects { get; set; }
        public object ViewObjectsLocker { get; set; }
        public List<Model> ViewModels { get; set; }
        public object ViewModelsLocker { get; set; }
        public object QuadrocoptersLocker { get; set; }
        public CreatingObject Creator { get; set; }
        public List<Operator> Operators { get; set; }
        public List<Quadrocopter> Quadrocopters { get; set; }
        public List<string> Messages { get; set; }
        public int CountOfMechanics { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CountOfMechanics = 0;
            ViewObjects = new List<CoordinatesForImage>();
            ViewObjectsLocker = new object();
            ViewModels = new List<Model>();
            ViewModelsLocker = new object();
            QuadrocoptersLocker = new object();
            Quadrocopters = new List<Quadrocopter>();
            Operators = new List<Operator>();
            Messages = new List<string>();
            Creator = new CreatingObject(pictureBox, Properties.Resources.Background, ViewObjects, ViewObjectsLocker, ViewModels, ViewModelsLocker);
            Creator.TimerStart();
        }

        private void Message(string message)
        {
            textBox.Invoke((MethodInvoker) delegate
            {
                Messages.Add(message);
                textBox.Text += message + "\r\n";
                textBox.SelectionStart = textBox.Text.Length;
                textBox.ScrollToCaret();
            });
        }

        private string Input(string message)
        {
            InputForm inputForm = new InputForm(message);
            inputForm.ShowDialog();
            this.Enabled = true;
            return inputForm.Result;
        }

        private void AddOperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float coordinateX = 400 + Operators.Count * 50;
            float coordinateY = 550;
            Operators.Add(new Operator(coordinateX, coordinateY, Message));

            lock (ViewObjectsLocker)
            {
                ViewObjects.Add(new CoordinatesForImage(Properties.Resources.Operator, coordinateX, coordinateY));
            }

            Operators[Operators.Count() - 1].Quadrocopter = new Quadrocopter(QuadrocoptersLocker, Operators[Operators.Count() - 1].CoordinateX,
                Operators[Operators.Count() - 1].CoordinateY, Message);
            Operators[Operators.Count() - 1].Quadrocopter.Name = Input("Введите название/номер квадрокоптера:");
            Task.Run(Operators[Operators.Count() - 1].StartOfWork);

            lock (ViewModels)
            {
                ViewModels.Add(new Model(Operators[Operators.Count() - 1].Quadrocopter, Properties.Resources.Quadrocopter));
                Quadrocopters.Add(Operators[Operators.Count() - 1].Quadrocopter);
            }

            if (Operators.Count() > MaxCountOfOperators)
                AddOperatorToolStripMenuItem.Enabled = false;
            Task.Run(Operators[Operators.Count() - 1].Quadrocopter.StartOfWork);
        }

        private void CreateMechanic(Mechanic mechanic)
        {
            CountOfMechanics++;
            mechanic.Name = Input("Введите имя/номер механика:");

            lock (ViewModelsLocker)
            {
                ViewModels.Add(new Model(mechanic, Properties.Resources.Mechanic));
            }

            if (CountOfMechanics > MaxCountOfMechanics)
                AddMechanicToolStripMenuItem.Enabled = false;
            Task.Run(mechanic.StartOfWork);
        }

        private void TraineeMechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraineeMechanic mechanic = Activator.CreateInstance(typeof(TraineeMechanic),
                new object[] { 870 + CountOfMechanics * 20, 650, (Action<string>)Message, Quadrocopters, QuadrocoptersLocker }) as TraineeMechanic;
            CreateMechanic(mechanic);
        }

        private void ExperiencedMechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExperiencedMechanic mechanic = Activator.CreateInstance(typeof(ExperiencedMechanic), 
                new object[] { 870 + CountOfMechanics * 20, 650, (Action<string>)Message, Quadrocopters, QuadrocoptersLocker }) as ExperiencedMechanic;
            CreateMechanic(mechanic);
        }

        private void ProfessionalMechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfessionalMechanic mechanic = Activator.CreateInstance(typeof(ProfessionalMechanic),
                new object[] { 870 + CountOfMechanics * 20, 650, (Action<string>)Message, Quadrocopters, QuadrocoptersLocker }) as ProfessionalMechanic;
            CreateMechanic(mechanic);
        }
    }
}
