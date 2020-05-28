using System;
using System.Windows.Forms;

namespace CsCourseTask
{
    public partial class CourseTask : Form
    {
        PatientDataBase dataBase;
        String incomingPass = "";

        public CourseTask()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataBase == null)
            {
                MessageBox.Show("Инофрмация отсутствует");
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = saveFileDialog1.FileName;
            dataBase.Save(path);
            MessageBox.Show("Файлы сохранены");
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataBase != null)
            {
                DialogResult result = MessageBox.Show("При загрузке базы данных текущая информация будет утеряна", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            PassCheckGroupBox.Visible = true;
            PassCheckGroupBox.Enabled = true;

            FIleStripMenu.Enabled = false;
            EditToolStripMenuItem.Enabled = false;
            searchBox.Enabled = false;
            createNote.Enabled = false;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
                patientsTextBox.Text = dataBase.ToString();
            else
                patientsTextBox.Text = dataBase.Search(searchBox.Text);
        }

        private void CreateStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataBase != null)
            {
                DialogResult result = MessageBox.Show("При создании новой базы данных текущая информация будет утеряна",
                    "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            formBox.Enabled = false;
            formBox.Visible = false;
            PassCheckGroupBox.Visible = true;
            PassCheckGroupBox.Enabled = true;
            acceptButton.Enabled = false;
            acceptButton.Visible = false;
            SavePass.Enabled = true;
            SavePass.Visible = true;

            FIleStripMenu.Enabled = false;
            EditToolStripMenuItem.Enabled = false;
            searchBox.Enabled = false;
            createNote.Enabled = false;

            patientsTextBox.Text = "";
            EditToolStripMenuItem.Enabled = true;
            createNote.Enabled = true;
            searchBox.Enabled = true;
            // MessageBox.Show("База данных создана");
        }

        private void CreateNote_Click(object sender, EventArgs e)
        {
            formBox.Visible = true;
            formBox.Enabled = true;
        }

        private void SaveInfButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataBase.AddElement(fullNameTextBox.Text, workTypeTextBox.Text, cardNumberTextBox.Text,
                UInt32.Parse(serviceCostTextBox.Text), PayedBox.Checked))
                {
                    formBox.Visible = false;
                    formBox.Enabled = false;

                    patientsTextBox.Text = dataBase.ToString();
                    //patientsTextBox.Text += dataBase.Patients[dataBase.Patients.Count - 1];

                    fullNameTextBox.Text = "";
                    workTypeTextBox.Text = "";
                    cardNumberTextBox.Text = "";
                    serviceCostTextBox.Text = "";
                    PayedBox.CheckState = CheckState.Unchecked;
                    debtAmountTextBox.Text = "";
                }
                else MessageBox.Show("Все поля должны быть заполнены!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            formBox.Visible = false;
            formBox.Enabled = false;

            fullNameTextBox.Text = "";
            workTypeTextBox.Text = "";
            cardNumberTextBox.Text = "";
            serviceCostTextBox.Text = "";
            PayedBox.CheckState = CheckState.Unchecked;
            debtAmountTextBox.Text = "";

            EditButton.Visible = false;
            EditButton.Enabled = false;
            NumToEditUpDown.Visible = false;
            NumToEditUpDown.Enabled = false;

            saveInfButton.Visible = true;
            saveInfButton.Enabled = true;

            FIleStripMenu.Enabled = true;
            EditToolStripMenuItem.Enabled = true;
            searchBox.Enabled = true;
            createNote.Enabled = true;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string path = openFileDialog1.FileName;
            incomingPass = PassBox.Text;
            try
            {
                if (PatientDataBase.ReadPass(path) == incomingPass)
                {
                    if (dataBase == null)
                        dataBase = new PatientDataBase();
                    dataBase.Load(path);

                    PassCheckGroupBox.Visible = false;
                    PassCheckGroupBox.Enabled = false;
                    PassBox.Text = "";
                    patientsTextBox.Text = dataBase.ToString();
                    FIleStripMenu.Enabled = true;
                    EditToolStripMenuItem.Enabled = true;
                    searchBox.Enabled = true;
                    createNote.Enabled = true;
                }
                else MessageBox.Show("Пароль введен неверно!", "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message); 
            }
        }

        private void SavePass_Click(object sender, EventArgs e)
        {
            dataBase = new PatientDataBase(PassBox.Text);

            PassBox.Text = "";
            PassCheckGroupBox.Visible = false;
            PassCheckGroupBox.Enabled = false;

            FIleStripMenu.Enabled = true;
            EditToolStripMenuItem.Enabled = true;
            searchBox.Enabled = true;
            createNote.Enabled = true;

            acceptButton.Enabled = true;
            acceptButton.Visible = true;
            SavePass.Enabled = false;
            SavePass.Visible = false;
            MessageBox.Show("База данных создана");
            patientsTextBox.Text = "Список пуст...";
        }

        private void CancelAllowButton_Click(object sender, EventArgs e)
        {
            PassBox.Text = "";
            PassCheckGroupBox.Visible = false;
            PassCheckGroupBox.Enabled = false;

            acceptButton.Enabled = true;
            acceptButton.Visible = true;
            SavePass.Enabled = false;
            SavePass.Visible = false;

            FIleStripMenu.Enabled = true;
            if (dataBase != null)
            {
                EditToolStripMenuItem.Enabled = true;
                searchBox.Enabled = true;
                createNote.Enabled = true;
            }
        }

        private void formBox_Leave(object sender, EventArgs e)
        {
            formBox.Visible = false;
            formBox.Enabled = false;
        }

        private void WorkTypeSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientsTextBox.Text = dataBase.WorkTypeSearch();
        }

        private void ShowFullListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientsTextBox.Text = dataBase.ToString();
        }

        private void DebtSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patientsTextBox.Text = dataBase.DebtSearch();
        }

        private void DeleteByNumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(NumToDelTextBox.Text) > 0 && Int32.Parse(NumToDelTextBox.Text) <= dataBase.Patients.Count)
                {
                    dataBase.DeleteElement(Int32.Parse(NumToDelTextBox.Text));
                    MessageBox.Show("Запись удалена");
                    patientsTextBox.Text = dataBase.ToString();
                }
                else MessageBox.Show("Неверный номер");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void RemoveNonDebtorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBase.RemoveNonDebtors();
            patientsTextBox.Text = dataBase.ToString();
            MessageBox.Show("Записи не имеющие задолженностей были удалены");
        }

        private void EditByNumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumToEditUpDown.Maximum = dataBase.Patients.Count;
            NumToEditUpDown.Value = NumToEditUpDown.Minimum;

            EditButton.Visible = true;
            EditButton.Enabled = true;
            NumToEditUpDown.Visible = true;
            NumToEditUpDown.Enabled = true;

            FIleStripMenu.Enabled = false;
            EditToolStripMenuItem.Enabled = false;
            searchBox.Enabled = false;
            createNote.Enabled = false;

            saveInfButton.Visible = false;
            saveInfButton.Enabled = false;

            formBox.Visible = true;
            formBox.Enabled = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NumToEditUpDown.Value <= dataBase.Patients.Count && NumToEditUpDown.Value > 0)
            {
                try
                {
                    if (dataBase.AddElement(fullNameTextBox.Text, workTypeTextBox.Text, cardNumberTextBox.Text,
                    UInt32.Parse(serviceCostTextBox.Text), PayedBox.Checked, (int)NumToEditUpDown.Value - 1))
                    {
                        formBox.Visible = false;
                        formBox.Enabled = false;

                        FIleStripMenu.Enabled = true;
                        EditToolStripMenuItem.Enabled = true;
                        searchBox.Enabled = true;
                        createNote.Enabled = true;

                        saveInfButton.Visible = true;
                        saveInfButton.Enabled = true;

                        EditButton.Visible = false;
                        EditButton.Enabled = false;
                        NumToEditUpDown.Visible = false;
                        NumToEditUpDown.Enabled = false;

                        patientsTextBox.Text = dataBase.ToString();

                        fullNameTextBox.Text = "";
                        workTypeTextBox.Text = "";
                        cardNumberTextBox.Text = "";
                        serviceCostTextBox.Text = "";
                        PayedBox.CheckState = CheckState.Unchecked;
                        debtAmountTextBox.Text = "";
                    }
                    else MessageBox.Show("Все поля должны быть заполнены!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void serviceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!PayedBox.Checked)
                debtAmountTextBox.Text = serviceCostTextBox.Text;
        }

        private void PayedBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PayedBox.Checked)
                debtAmountTextBox.Text = "0";
            else debtAmountTextBox.Text = serviceCostTextBox.Text;
        }

        private void NumToEditUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (NumToEditUpDown.Value <= dataBase.Patients.Count && NumToEditUpDown.Value > 0)
            {
                fullNameTextBox.Text = dataBase.Patients[(int)NumToEditUpDown.Value - 1].Fullname;
                workTypeTextBox.Text = dataBase.Patients[(int)NumToEditUpDown.Value - 1].WorkType;
                cardNumberTextBox.Text = dataBase.Patients[(int)NumToEditUpDown.Value - 1].RecordCardNumber;
                serviceCostTextBox.Text = dataBase.Patients[(int)NumToEditUpDown.Value - 1].ServiceCost.ToString();
                if (dataBase.Patients[(int)NumToEditUpDown.Value - 1].IsPayed)
                    PayedBox.CheckState = CheckState.Checked;
                else PayedBox.CheckState = CheckState.Unchecked;
                debtAmountTextBox.Text = dataBase.Patients[(int)NumToEditUpDown.Value - 1].DebtAmount.ToString();
            }
            else
            {
                fullNameTextBox.Text = "";
                workTypeTextBox.Text = "";
                cardNumberTextBox.Text = "";
                serviceCostTextBox.Text = "";
                PayedBox.CheckState = CheckState.Unchecked;
                debtAmountTextBox.Text = "";
            }
        }

        private void NumToDelTextBox_Leave(object sender, EventArgs e)
        {
            NumToDelTextBox.Text = "0";
        }

        private void CourseTask_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}