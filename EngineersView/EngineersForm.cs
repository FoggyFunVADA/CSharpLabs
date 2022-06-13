using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using EngineersModel;

namespace EngineersView
{
    public partial class EngineersForm : Form
    {
        Assembly Assembly;
        IEnumerable<Type> Types;
        Type CurrentType;
        object CurrentObject;
        MethodInfo CurrentMethod;
        object[] MethodParameters;
        public EngineersForm()
        {
            InitializeComponent();
        }

        private void EngineersForm_Load(object sender, EventArgs e)
        {
            Assembly = Assembly.Load("EngineersModel");
            Types = Assembly.GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IEmployee") != null);
            ClassComboBox.Items.AddRange(Types.Select(type => type.Name).ToArray());
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PropertiesListBox.Items.Clear();
            ParametersListBox.Items.Clear();
            MethodComboBox.Items.Clear();
            FillParameters.Enabled = false;
            Perform.Enabled = false;

            CurrentType = Types.First(type => type.Name == ClassComboBox.SelectedItem.ToString());
            CurrentObject = null;

            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            MethodComboBox.Items.AddRange(CurrentType.GetMethods().Where(
                method => !objectMethods.Contains(method.Name) && !method.Name.Contains("get_") && !method.Name.Contains("set_")).Select(method => method.Name).ToArray());

            MethodComboBox.Enabled = false;
            Create.Enabled = true;
        }

        private void MethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentMethod = CurrentType.GetMethods().First(method => method.Name == MethodComboBox.SelectedItem.ToString());
            MethodParameters = null;
            if (CurrentMethod.GetParameters().Length == 0)
            {
                FillParameters.Enabled = false;
                Perform.Enabled = CurrentObject != null;
            }
            else
            {
                FillParameters.Enabled = true;
                Perform.Enabled = false;
            }
            ParametersListBox.Items.Clear();
            foreach (ParameterInfo info in CurrentMethod.GetParameters())
            {
                ParametersListBox.Items.Add(info.Name);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            PropertiesListBox.Items.Clear();
            MethodComboBox.Enabled = true;
            Perform.Enabled = false;
            FillParameters.Enabled = false;
            object newObject = Activator.CreateInstance(CurrentType);
            Form add = new Form();
            add.ClientSize = new Size(600, 300);
            add.MaximizeBox = false;
            add.MinimizeBox = false;
            add.FormBorderStyle = FormBorderStyle.FixedSingle;
            add.Font = new Font("Verdana", 12, FontStyle.Bold);
            int pos = 10;
            foreach (PropertyInfo info in newObject.GetType().GetProperties())
            {
                Label label = new Label { Top = pos, Left = 10, Width = 300, Height = 20 };
                label.Text = info.Name;
                label.MaximumSize = new Size(300, 60);
                label.AutoSize = true;
                TextBox textBox = new TextBox { Top = pos, Left = label.Width + 30, Width = label.Width - 70, Height = label.Height };
                textBox.Text = "0";
                add.Controls.Add(label);
                add.Controls.Add(textBox);
                pos += label.Height + 15;
            }
            add.Controls.Add(new Button() { Top = pos + 10, Left = 250, Width = 120, Height = 60, Text = "Добавить" });
            add.Controls[add.Controls.Count - 1].Click += new EventHandler((object sender2, EventArgs e2) => { add.DialogResult = DialogResult.OK; add.Close(); });
            if (add.ShowDialog() == DialogResult.OK)
            {
                PropertyInfo[] properties = newObject.GetType().GetProperties();
                for (int i = 1, j = 0; i < add.Controls.Count; i += 2, j++)
                {
                    string value = add.Controls[i].Text;
                    if (value.Length != 0)
                    {
                        if (properties[j].PropertyType.Name == "Int32")
                            properties[j].SetValue(newObject, Int32.Parse(value));
                        else if (properties[j].PropertyType.Name == "Double")
                            properties[j].SetValue(newObject, Double.Parse(value));
                        else
                            properties[j].SetValue(newObject, value);
                    }
                }
            }
            CurrentObject = newObject;
            foreach (PropertyInfo info in CurrentType.GetProperties())
            {
                PropertiesListBox.Items.Add(info.Name + ": " + info.GetValue(CurrentObject));
            }
        }

        private void FillParameters_Click(object sender, EventArgs e)
        {
            ParametersListBox.Items.Clear();
            Form add = new Form();
            add.ClientSize = new Size(600, 165);
            add.MaximizeBox = false;
            add.MinimizeBox = false;
            add.FormBorderStyle = FormBorderStyle.FixedSingle;
            add.Font = new Font("Verdana", 12, FontStyle.Bold);
            int pos = 10;
            foreach (ParameterInfo info in CurrentMethod.GetParameters())
            {
                Label label = new Label { Top = pos, Left = 10, Width = 300, Height = 30 };
                label.MaximumSize = new Size(300, 90);
                label.AutoSize = true;
                label.Text = info.Name;
                TextBox textBox = new TextBox { Top = pos, Left = label.Width + 15, Width = label.Width - 40, Height = 20 };
                textBox.Text = "0";
                add.Controls.Add(label);
                add.Controls.Add(textBox);
                pos += label.Height + 15;
            }
            add.Controls.Add(new Button() { Top = pos + 20, Left = 280, Width = 100, Height = 50, Text = "Ввести" });
            add.Controls[add.Controls.Count - 1].Click += new EventHandler((object sender1, EventArgs e1) => { add.DialogResult = DialogResult.OK; add.Close(); });
            if (add.ShowDialog() == DialogResult.OK)
            {
                List<object> currentParameters = new List<object>();
                for (int i = 1; i < add.Controls.Count - 1; i += 2)
                {
                    try
                    {
                        string value = add.Controls[i].Text;
                        currentParameters.Add(int.Parse(value));
                        ParametersListBox.Items.Add(add.Controls[i - 1].Text + ": " + value);
                        Perform.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Повторите ввод!");
                        ParametersListBox.Items.Add(add.Controls[i - 1].Text);
                        Perform.Enabled = false;
                    }
                }
                MethodParameters = currentParameters.ToArray();
            }
        }

        private void Perform_Click(object sender, EventArgs e)
        {
            if (ParametersListBox.Text.Length == 0 || ParametersListBox.SelectedIndex != -1)
            {
                if (CurrentMethod.GetParameters().Length != 0 && MethodParameters == null)
                    MessageBox.Show("Введите параметры!");
                else
                {
                    if (CurrentMethod.ReturnType == typeof(void))
                        CurrentMethod.Invoke(CurrentObject, MethodParameters);
                    else
                        MessageBox.Show(CurrentMethod.Invoke(CurrentObject, MethodParameters).ToString());
                    PropertiesListBox.Items.Clear();
                    foreach (PropertyInfo info in CurrentType.GetProperties())
                    {
                        PropertiesListBox.Items.Add(info.Name + ": " + info.GetValue(CurrentObject));
                    }
                }
            }
        }
    }
}
