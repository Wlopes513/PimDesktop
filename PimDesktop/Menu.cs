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
using System.Globalization;

namespace PimDesktop
{
    public partial class Menu : Form
    {
        bool sidebarExpand = true;
        IEnumerable<EmployeeInfo> employees = null;
        string htmlContent = "<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Folha de Pagamento</title>\r\n    <style>\r\n        table {\r\n            width: 100%;\r\n            border-collapse: collapse;\r\n            margin-bottom: 20px;\r\n        }\r\n        table, th, td {\r\n            border: 1px solid #ddd;\r\n            text-align: left;\r\n        }\r\n        th, td {\r\n            padding: 10px;\r\n        }\r\n        th {\r\n            background-color: #f2f2f2;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n\r\n    <h2>Folha de Pagamento</h2>\r\n\r\n    <table>\r\n        <tr>\r\n            <th colspan=\"2\">Empresa: [Nome da Empresa]</th>\r\n            <th colspan=\"2\">Período de Pagamento: {_DATA}</th>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"4\">Nome do Empregado: {_NOME + _SOBRENOME}</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">Identificação do Empregado: {_ID}</td>\r\n            <td colspan=\"2\">CPF: {_CPF}</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">Cargo do Empregado: {_CARGO}</td>\r\n            <td colspan=\"2\">Departamento do Empregado: {_DEPARTAMENTO}</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <th>Proventos</th>\r\n            <th>Valores (R$)</th>\r\n            <th>Descontos</th>\r\n            <th>Valores (R$)</th>\r\n        </tr>\r\n        <tr>\r\n            <td>Salário Base</td>\r\n            <td>{_SALARIO_BASE}</td>\r\n            <td>Impostos</td>\r\n            <td>{_DESCONTOS}</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Bônus</td>\r\n            <td>{_BONUS}</td>\r\n            <td>Seguros</td>\r\n            <td>{_SEGUROS}</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Benefícios</td>\r\n            <td>{_BENEFICIOS}</td>\r\n            <td>Outros descontos</td>\r\n            <td>{_OUTROS_DESCONTOS}</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <th colspan=\"2\">Total de Proventos</th>\r\n            <td colspan=\"2\">{_TOTAL_POSITIVO}</td>\r\n        </tr>\r\n        <tr>\r\n            <th colspan=\"2\">Total de Descontos</th>\r\n            <td colspan=\"2\">{_TOTAL_NEGATIVO}</td>\r\n        </tr>\r\n        <tr>\r\n            <th colspan=\"2\">Salário Líquido a Pagar</th>\r\n            <td colspan=\"2\">{_SALARIO_TOTAL}</td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
        public Menu()
        {
            InitializeComponent();
            refreshData();
        }

        private async void refreshData()
        {
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
            var register = new Register();
            register.Show();

            this.Visible = false;
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
                var readData = await client.DeleteAsync($"employee/{linhaDesejada.Cells[0].Value}");

                if (readData.IsSuccessStatusCode)
                {
                    this.refreshData();
                }
            }
        }

        static string MoneyMask(string value)
        {
            value = value.Replace(".", "").Replace(",", "").Replace("\\D", "");

            CultureInfo culture = new CultureInfo("pt-BR");
            const int centsDivider = 100;

            decimal numericValue = decimal.Parse(value) / centsDivider;
            string result = numericValue.ToString("C", culture);

            return result;
        }

        private async Task generatePdf(DataGridViewRow rowData)
        {
            var data = employees
            .Where(emp => emp.id == Convert.ToInt32(rowData.Cells["Id"].Value)).FirstOrDefault();
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            DateTime actualDate = DateTime.Now;
            string editedHtml = htmlContent
    .Replace("{_DATA}", $"{actualDate.Month}/{actualDate.Year}")
    .Replace("{_NOME + _SOBRENOME}", $"{data.name} {data.surname}")
    .Replace("{_ID}", data.id.ToString())
    .Replace("{_CPF}", data.cpf)
    .Replace("{_CARGO}", data.responsability)
    .Replace("{_DEPARTAMENTO}", data.departament.ToString())
    .Replace("{_SALARIO_BASE}", MoneyMask(data.baseSalary.ToString("F2")))
    .Replace("{_DESCONTOS}", MoneyMask(data.taxesDiscount.ToString("F2")))
    .Replace("{_BONUS}", MoneyMask(data.bonusSalary.ToString("F2")))
    .Replace("{_SEGUROS}", MoneyMask(data.secureDiscount.ToString("F2")))
    .Replace("{_BENEFICIOS}", MoneyMask(data.benefitsSalary.ToString("F2")))
    .Replace("{_OUTROS_DESCONTOS}", MoneyMask(data.otherDiscount.ToString("F2")))
    .Replace("{_TOTAL_POSITIVO}", MoneyMask((data.baseSalary + data.bonusSalary + data.benefitsSalary).ToString("F2")))
    .Replace("{_TOTAL_NEGATIVO}", MoneyMask((data.taxesDiscount + data.secureDiscount + data.otherDiscount).ToString("F2")))
    .Replace("{_SALARIO_TOTAL}", MoneyMask(data.salary.ToString()));

            using (var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true
            }))
            using (var page = await browser.NewPageAsync())
            {
                await page.SetContentAsync(editedHtml);

                var pdfOptions = new PdfOptions
                {
                    Format = PaperFormat.A4,
                    PrintBackground = true
                };

                var pdfBytes = await page.PdfDataAsync(pdfOptions);

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "output.pdf");
                File.WriteAllBytes(filePath, pdfBytes);

                System.Diagnostics.Process.Start(filePath);
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
            request.date = actualDate.ToString("yyyy-MM");
            request.dateRegister = actualDate.ToString("yyyy-MM-dd");
            request.salary = linhaDesejada.Cells["Salário"].Value.ToString();
            request.information = "";

            if (linhaDesejada != null)
            {
                try
                {
                    var readData = await client.PostAsJsonAsync($"employee/historic", request);

                    if (readData.IsSuccessStatusCode)
                    {
                        this.generatePdf(linhaDesejada);
                    } else
                    {
                        MessageBox.Show("A folha de pagamento deste mês já foi criada para este usuário!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Ocorreu um erro!",
                            ex.Message,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }
    }
}
