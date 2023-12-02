using PimDesktop.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimDesktop
{
    public partial class Menu : Form
    {
        bool sidebarExpand = true;
        public Menu()
        {
            InitializeComponent();
            refreshData();
        }

        private async void refreshData()
        {
            IEnumerable<EmployeeInfo> employees = null;
            IEnumerable<EmployeeDataTable> employeesData = null;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");

            var readData = await client.GetAsync("employee");

            if (readData.IsSuccessStatusCode)
            {
                var displayData = await readData.Content.ReadAsAsync<IList<EmployeeInfo>>();

                employees = displayData;

                employeesData = employees.Select(info =>
    new EmployeeDataTable
    {
        Id = info.id,
        Nome = $"{info.name} {info.surname}",
        Endereço = info.address,
        Cpf = info.cpf,
        Cargo = info.responsability,
        Departamento = info.departament,
        Salário = info.salary,
    });

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = employeesData.ToList();
                dataGridView1.Refresh();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.Fill(this.pagamentoRHDataSet.Funcionario);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pagamentoRHDataSet);

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
            DataGridViewRow linhaDesejada = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    linhaDesejada = row;
                    break;
                }
            }

            if (linhaDesejada != null)
            {
                var readData = await client.DeleteAsync($"employee/${linhaDesejada.Cells[0].Value}");

                if (readData.IsSuccessStatusCode)
                {
                    this.refreshData();
                }
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");
            DataGridViewRow linhaDesejada = null;
            EmployeeHistoric request = new EmployeeHistoric();
            DateTime actualDate = DateTime.Now;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    linhaDesejada = row;
                    break;
                }
            }

            request.idEmployee = Convert.ToInt32(linhaDesejada.Cells["Id"].Value);
            request.date = $"{actualDate.Year}-{actualDate.Month + 1}";
            request.dateRegister = $"{actualDate.Year}-{actualDate.Month + 1}-{actualDate.Day}";
            request.salary = linhaDesejada.Cells["Salary"].Value.ToString();
            request.information = linhaDesejada.Cells["Information"].Value.ToString();

            if (linhaDesejada != null)
            {
                try
                {
                    var readData = await client.PostAsJsonAsync($"employee/historic", linhaDesejada);

                    if (readData.IsSuccessStatusCode)
                    {
                        this.refreshData();
                    }
                } catch (Exception ex) {
                    MessageBox.Show("A folha de pagamento deste mês já foi criada para este usuário!",
                            ex.Message,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }
    }
}
