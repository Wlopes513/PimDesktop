namespace PimDesktop
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label baseSalaryLabel;
            System.Windows.Forms.Label benefitsSalaryLabel;
            System.Windows.Forms.Label bonusSalaryLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label departamentLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label otherDiscountLabel;
            System.Windows.Forms.Label responsabilityLabel;
            System.Windows.Forms.Label secureDiscountLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label taxesDiscountLabel;
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pagamentoRHDataSet = new PimDesktop.PagamentoRHDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new PimDesktop.PagamentoRHDataSetTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new PimDesktop.PagamentoRHDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.benefitsSalaryTextBox = new System.Windows.Forms.TextBox();
            this.bonusSalaryTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.departamentTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.otherDiscountTextBox = new System.Windows.Forms.TextBox();
            this.responsabilityTextBox = new System.Windows.Forms.TextBox();
            this.secureDiscountTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.taxesDiscountTextBox = new System.Windows.Forms.TextBox();
            this.employeeCreateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            addressLabel = new System.Windows.Forms.Label();
            baseSalaryLabel = new System.Windows.Forms.Label();
            benefitsSalaryLabel = new System.Windows.Forms.Label();
            bonusSalaryLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            departamentLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            otherDiscountLabel = new System.Windows.Forms.Label();
            responsabilityLabel = new System.Windows.Forms.Label();
            secureDiscountLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            taxesDiscountLabel = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoRHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeCreateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Name = "sidebar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::PimDesktop.Properties.Resources._1024px_Hamburger_icon_white_svg;
            resources.ApplyResources(this.menuButton, "menuButton");
            this.menuButton.Name = "menuButton";
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.button2);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Name = "panel3";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PimDesktop.Properties.Resources.user_24;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pagamentoRHDataSet
            // 
            this.pagamentoRHDataSet.DataSetName = "PagamentoRHDataSet";
            this.pagamentoRHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.pagamentoRHDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.DescontosTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.HistoricoPagamentoTableAdapter = null;
            this.tableAdapterManager.SalarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PimDesktop.PagamentoRHDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addressLabel
            // 
            resources.ApplyResources(addressLabel, "addressLabel");
            addressLabel.Name = "addressLabel";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "Address", true));
            resources.ApplyResources(this.addressTextBox, "addressTextBox");
            this.addressTextBox.Name = "addressTextBox";
            // 
            // baseSalaryLabel
            // 
            resources.ApplyResources(baseSalaryLabel, "baseSalaryLabel");
            baseSalaryLabel.Name = "baseSalaryLabel";
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "BaseSalary", true));
            resources.ApplyResources(this.baseSalaryTextBox, "baseSalaryTextBox");
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            // 
            // benefitsSalaryLabel
            // 
            resources.ApplyResources(benefitsSalaryLabel, "benefitsSalaryLabel");
            benefitsSalaryLabel.Name = "benefitsSalaryLabel";
            // 
            // benefitsSalaryTextBox
            // 
            this.benefitsSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "BenefitsSalary", true));
            resources.ApplyResources(this.benefitsSalaryTextBox, "benefitsSalaryTextBox");
            this.benefitsSalaryTextBox.Name = "benefitsSalaryTextBox";
            // 
            // bonusSalaryLabel
            // 
            resources.ApplyResources(bonusSalaryLabel, "bonusSalaryLabel");
            bonusSalaryLabel.Name = "bonusSalaryLabel";
            // 
            // bonusSalaryTextBox
            // 
            this.bonusSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "BonusSalary", true));
            resources.ApplyResources(this.bonusSalaryTextBox, "bonusSalaryTextBox");
            this.bonusSalaryTextBox.Name = "bonusSalaryTextBox";
            // 
            // cpfLabel
            // 
            resources.ApplyResources(cpfLabel, "cpfLabel");
            cpfLabel.Name = "cpfLabel";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "Cpf", true));
            resources.ApplyResources(this.cpfTextBox, "cpfTextBox");
            this.cpfTextBox.Name = "cpfTextBox";
            // 
            // departamentLabel
            // 
            resources.ApplyResources(departamentLabel, "departamentLabel");
            departamentLabel.Name = "departamentLabel";
            // 
            // departamentTextBox
            // 
            this.departamentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "Departament", true));
            resources.ApplyResources(this.departamentTextBox, "departamentTextBox");
            this.departamentTextBox.Name = "departamentTextBox";
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "Name", true));
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            // 
            // otherDiscountLabel
            // 
            resources.ApplyResources(otherDiscountLabel, "otherDiscountLabel");
            otherDiscountLabel.Name = "otherDiscountLabel";
            // 
            // otherDiscountTextBox
            // 
            this.otherDiscountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "OtherDiscount", true));
            resources.ApplyResources(this.otherDiscountTextBox, "otherDiscountTextBox");
            this.otherDiscountTextBox.Name = "otherDiscountTextBox";
            // 
            // responsabilityLabel
            // 
            resources.ApplyResources(responsabilityLabel, "responsabilityLabel");
            responsabilityLabel.Name = "responsabilityLabel";
            // 
            // responsabilityTextBox
            // 
            this.responsabilityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "Responsability", true));
            resources.ApplyResources(this.responsabilityTextBox, "responsabilityTextBox");
            this.responsabilityTextBox.Name = "responsabilityTextBox";
            // 
            // secureDiscountLabel
            // 
            resources.ApplyResources(secureDiscountLabel, "secureDiscountLabel");
            secureDiscountLabel.Name = "secureDiscountLabel";
            // 
            // secureDiscountTextBox
            // 
            this.secureDiscountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "SecureDiscount", true));
            resources.ApplyResources(this.secureDiscountTextBox, "secureDiscountTextBox");
            this.secureDiscountTextBox.Name = "secureDiscountTextBox";
            // 
            // surnameLabel
            // 
            resources.ApplyResources(surnameLabel, "surnameLabel");
            surnameLabel.Name = "surnameLabel";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "Surname", true));
            resources.ApplyResources(this.surnameTextBox, "surnameTextBox");
            this.surnameTextBox.Name = "surnameTextBox";
            // 
            // taxesDiscountLabel
            // 
            resources.ApplyResources(taxesDiscountLabel, "taxesDiscountLabel");
            taxesDiscountLabel.Name = "taxesDiscountLabel";
            // 
            // taxesDiscountTextBox
            // 
            this.taxesDiscountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeCreateBindingSource, "TaxesDiscount", true));
            resources.ApplyResources(this.taxesDiscountTextBox, "taxesDiscountTextBox");
            this.taxesDiscountTextBox.Name = "taxesDiscountTextBox";
            // 
            // employeeCreateBindingSource
            // 
            this.employeeCreateBindingSource.DataSource = typeof(PimDesktop.Employee.EmployeeCreate);
            // 
            // Register
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(baseSalaryLabel);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(benefitsSalaryLabel);
            this.Controls.Add(this.benefitsSalaryTextBox);
            this.Controls.Add(bonusSalaryLabel);
            this.Controls.Add(this.bonusSalaryTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(departamentLabel);
            this.Controls.Add(this.departamentTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(otherDiscountLabel);
            this.Controls.Add(this.otherDiscountTextBox);
            this.Controls.Add(responsabilityLabel);
            this.Controls.Add(this.responsabilityTextBox);
            this.Controls.Add(secureDiscountLabel);
            this.Controls.Add(this.secureDiscountTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(taxesDiscountLabel);
            this.Controls.Add(this.taxesDiscountTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Register_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoRHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeCreateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private PagamentoRHDataSet pagamentoRHDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private PagamentoRHDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private PagamentoRHDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource employeeCreateBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.TextBox benefitsSalaryTextBox;
        private System.Windows.Forms.TextBox bonusSalaryTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox departamentTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox otherDiscountTextBox;
        private System.Windows.Forms.TextBox responsabilityTextBox;
        private System.Windows.Forms.TextBox secureDiscountTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox taxesDiscountTextBox;
    }
}