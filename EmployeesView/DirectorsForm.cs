using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeesModel;

namespace EmployeesView
{
    public partial class DirectorsForm : Form
    {
        private List<IEmployee> DirectorsList;
        public DirectorsForm()
        {
            InitializeComponent();
            DirectorsList = new List<IEmployee>();
        }

        private void ListOfDirectors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedDirector = ListOfDirectors.SelectedIndex;
            if (selectedDirector != -1)
            {
                FillDirector editForm = new FillDirector();
                if (editForm.ShowDialog() != DialogResult.OK)
                    MessageBox.Show("Руководитель не был изменён!", "Внимание", MessageBoxButtons.OK);
                else
                {
                    DirectorsList.RemoveAt(selectedDirector);
                    DirectorsList.Insert(selectedDirector, editForm.DirectorTmp);
                    ListOfDirectors.Items.RemoveAt(selectedDirector);
                    ListOfDirectors.Items.Insert(selectedDirector, editForm.DirectorTmp);
                    MessageBox.Show("Руководитель успешно изменён!", "Успех", MessageBoxButtons.OK);
                }
            }
        }

        private void AddDirector_Click(object sender, EventArgs e)
        {
            FillDirector addForm = new FillDirector();
            if (addForm.ShowDialog() != DialogResult.OK)
                MessageBox.Show("Руководитель не был добавлен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DirectorsList.Add(addForm.DirectorTmp);
                ListOfDirectors.Items.Add(addForm.DirectorTmp);
                MessageBox.Show("Руководитель успешно добавлен!", "Успех", MessageBoxButtons.OK);
            }
        }

        private void DeleteDirector_Click(object sender, EventArgs e)
        {
            int selectedDirector = ListOfDirectors.SelectedIndex;
            if (selectedDirector == -1)
                MessageBox.Show("Руководитель не был удалён!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DirectorsList.RemoveAt(selectedDirector);
                ListOfDirectors.Items.RemoveAt(selectedDirector);
                MessageBox.Show("Руководитель был успешно удалён!", "Успех", MessageBoxButtons.OK);
            }
        }

        private void СhangeDepartment_Click(object sender, EventArgs e)
        {
            int selectedDirector = ListOfDirectors.SelectedIndex;
            if (selectedDirector == -1)
                MessageBox.Show("Руководитель не был выбран!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                СhangeDepartment сhangeDepartmentForm = new СhangeDepartment();
                if (сhangeDepartmentForm.ShowDialog() != DialogResult.OK)
                    MessageBox.Show("Отдел руководителя не был изменён!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Director DirectorTmp;
                    if (DirectorsList[selectedDirector] is Director == false)
                        throw new InvalidOperationException("Ошибка преобразования типов!");
                    else
                    {
                        DirectorTmp = DirectorsList[selectedDirector] as Director;
                        DirectorTmp.ChangeDepartment(сhangeDepartmentForm.NewDepartment, сhangeDepartmentForm.NewNumberOfSubordinate);
                        DirectorsList.RemoveAt(selectedDirector);
                        DirectorsList.Insert(selectedDirector, DirectorTmp);
                        ListOfDirectors.Items.RemoveAt(selectedDirector);
                        ListOfDirectors.Items.Insert(selectedDirector, DirectorsList[selectedDirector]);
                        MessageBox.Show("Отдел руководителя успешно изменён!", "Успех", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void GetFinalSalary_Click(object sender, EventArgs e)
        {
            int selectedDirector = ListOfDirectors.SelectedIndex;
            if (selectedDirector == -1)
                MessageBox.Show("Руководитель не был выбран!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Director DirectorTmp;
                if (DirectorsList[selectedDirector] is Director == false)
                    throw new InvalidOperationException("Ошибка преобразования типов!");
                else
                {
                    DirectorTmp = DirectorsList[selectedDirector] as Director;
                    MessageBox.Show(DirectorTmp.GetFinalSalary());
                }
            }
        }

        private void EvaluateWorkExperience_Click(object sender, EventArgs e)
        {
            int selectedDirector = ListOfDirectors.SelectedIndex;
            if (selectedDirector == -1)
                MessageBox.Show("Руководитель не был выбран!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Director DirectorTmp;
                if (DirectorsList[selectedDirector] is Director == false)
                    throw new InvalidOperationException("Ошибка преобразования типов!");
                else
                {
                    DirectorTmp = DirectorsList[selectedDirector] as Director;
                    MessageBox.Show(DirectorTmp.QualityOfExperience(), "Информация", MessageBoxButtons.OK);
                }
            }
        }

        private void TryGetBonus_Click(object sender, EventArgs e)
        {
            int selectedDirector = ListOfDirectors.SelectedIndex;
            if (selectedDirector == -1)
                MessageBox.Show("Руководитель не был выбран!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Director DirectorTmp;
                if (DirectorsList[selectedDirector] is Director == false)
                    throw new InvalidOperationException("Ошибка преобразования типов!");
                else
                {
                    DirectorTmp = DirectorsList[selectedDirector] as Director;
                    if (!DirectorTmp.GetBonusForLargeNumberOfEmployees())
                        MessageBox.Show("Бонус не был получен, сотрудников недостаточно!", "Провал", MessageBoxButtons.OK);
                    else
                    {
                        DirectorsList.RemoveAt(selectedDirector);
                        DirectorsList.Insert(selectedDirector, DirectorTmp);
                        ListOfDirectors.Items.RemoveAt(selectedDirector);
                        ListOfDirectors.Items.Insert(selectedDirector, DirectorsList[selectedDirector]);
                        MessageBox.Show("Бонус был успешно получен, оклад обновлён!", "Успех", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void GetInfo_Click(object sender, EventArgs e)
        {
            int selectedDirector = ListOfDirectors.SelectedIndex;
            if (selectedDirector == -1)
                MessageBox.Show("Руководитель не был выбран!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Director DirectorTmp;
                if (DirectorsList[selectedDirector] is Director == false)
                    throw new InvalidOperationException("Ошибка преобразования типов!");
                else
                {
                    DirectorTmp = DirectorsList[selectedDirector] as Director;
                    MessageBox.Show(DirectorTmp.ShowInformation());
                }
            }
        }
    }
}
