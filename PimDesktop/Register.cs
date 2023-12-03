using PimDesktop.Employee;
using PuppeteerSharp.Media;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PimDesktop
{
    public partial class Register : Form
    {
        bool sidebarExpand = true;
        public Register()
        {
            InitializeComponent();
            employeeCreateBindingSource.DataSource = new EmployeeCreate();
        }

        private void Register_Load(object sender, EventArgs e)
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

        private async void button1_Click_1(object sender, EventArgs e)
        {
            employeeCreateBindingSource.EndEdit();
            EmployeeCreate employee = employeeCreateBindingSource.Current as EmployeeCreate;

            if (employee != null)
            {

                ValidationContext context = new ValidationContext(employee, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(employee, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:5001/");

                try
                {
                    var readData = await client.PostAsJsonAsync("employee", employee);

                    if (readData.IsSuccessStatusCode)
                    {
                        var menu = new Menu();
                        menu.Show();

                        this.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro!",
                            ex.Message,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();

            this.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var menu = new Menu();
            menu.Show();

            this.Visible = false;
        }
    }
}
