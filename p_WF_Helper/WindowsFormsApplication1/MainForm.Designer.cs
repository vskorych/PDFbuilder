namespace WFHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.divBox = new System.Windows.Forms.ComboBox();
            this.xmlBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xslBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.companyIDcontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCompaniesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PdfCreate = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.Menu2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.companyIDcontextMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu2
            // 
            this.Menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.Menu2.Location = new System.Drawing.Point(0, 0);
            this.Menu2.Name = "Menu2";
            this.Menu2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu2.Size = new System.Drawing.Size(982, 24);
            this.Menu2.TabIndex = 6;
            this.Menu2.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.preferencesToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.divBox);
            this.panel1.Controls.Add(this.xmlBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.xslBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CompanyNameComboBox);
            this.panel1.Location = new System.Drawing.Point(10, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 84);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Division";
            // 
            // divBox
            // 
            this.divBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.divBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.divBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divBox.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBox.FormattingEnabled = true;
            this.divBox.Location = new System.Drawing.Point(475, 17);
            this.divBox.Name = "divBox";
            this.divBox.Size = new System.Drawing.Size(194, 25);
            this.divBox.TabIndex = 20;
            this.divBox.TextChanged += new System.EventHandler(this.divBox_TextChanged_1);
            // 
            // xmlBox
            // 
            this.xmlBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xmlBox.Font = new System.Drawing.Font("Garamond", 11.25F);
            this.xmlBox.FormattingEnabled = true;
            this.xmlBox.Location = new System.Drawing.Point(475, 45);
            this.xmlBox.Name = "xmlBox";
            this.xmlBox.Size = new System.Drawing.Size(194, 25);
            this.xmlBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Test xml";
            // 
            // xslBox
            // 
            this.xslBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.xslBox.Font = new System.Drawing.Font("Garamond", 11.25F);
            this.xslBox.FormattingEnabled = true;
            this.xslBox.Location = new System.Drawing.Point(108, 49);
            this.xslBox.Name = "xslBox";
            this.xslBox.Size = new System.Drawing.Size(194, 25);
            this.xslBox.TabIndex = 13;
            this.xslBox.SelectedIndexChanged += new System.EventHandler(this.xslBox_SelectedIndexChanged);
            this.xslBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.subDivisionComboBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "XSL";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(308, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.companyIDcontextMenu;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Company ID";
            this.label1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDoubleClick);
            // 
            // companyIDcontextMenu
            // 
            this.companyIDcontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCompaniesListToolStripMenuItem});
            this.companyIDcontextMenu.Name = "companyIDcontextMenu";
            this.companyIDcontextMenu.Size = new System.Drawing.Size(179, 26);
            // 
            // editCompaniesListToolStripMenuItem
            // 
            this.editCompaniesListToolStripMenuItem.Name = "editCompaniesListToolStripMenuItem";
            this.editCompaniesListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.editCompaniesListToolStripMenuItem.Text = "Edit Companies List";
            // 
            // CompanyNameComboBox
            // 
            this.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompanyNameComboBox.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameComboBox.FormattingEnabled = true;
            this.CompanyNameComboBox.Location = new System.Drawing.Point(108, 18);
            this.CompanyNameComboBox.Name = "CompanyNameComboBox";
            this.CompanyNameComboBox.Size = new System.Drawing.Size(194, 25);
            this.CompanyNameComboBox.TabIndex = 8;
            this.CompanyNameComboBox.SelectedIndexChanged += new System.EventHandler(this.CompanyNameComboBox_SelectedIndexChanged);
            this.CompanyNameComboBox.TextChanged += new System.EventHandler(this.comboBox1_TextChanged_1);
            this.CompanyNameComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PdfCreate);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(10, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 56);
            this.panel2.TabIndex = 9;
            // 
            // PdfCreate
            // 
            this.PdfCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PdfCreate.Enabled = false;
            this.PdfCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PdfCreate.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdfCreate.Location = new System.Drawing.Point(13, 13);
            this.PdfCreate.Name = "PdfCreate";
            this.PdfCreate.Size = new System.Drawing.Size(104, 28);
            this.PdfCreate.TabIndex = 6;
            this.PdfCreate.Text = "Create PDF";
            this.PdfCreate.UseVisualStyleBackColor = true;
            this.PdfCreate.Click += new System.EventHandler(this.CleanBuildDeploy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(149, 16);
            this.progressBar1.Maximum = 3;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(153, 25);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // Notify
            // 
            this.Notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notify.BalloonTipText = "WF Helper";
            this.Notify.BalloonTipTitle = "WF Helper";
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "WF Helper";
            this.Notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyMouseDoubleClick);
            this.Notify.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // ContextMenu2
            // 
            this.ContextMenu2.Name = "contextMenuStrip1";
            this.ContextMenu2.Size = new System.Drawing.Size(61, 4);
            // 
            // searchTypeCheckBox
            // 
            this.searchTypeCheckBox.AutoSize = true;
            this.searchTypeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTypeCheckBox.Location = new System.Drawing.Point(244, 8);
            this.searchTypeCheckBox.Name = "searchTypeCheckBox";
            this.searchTypeCheckBox.Size = new System.Drawing.Size(112, 16);
            this.searchTypeCheckBox.TabIndex = 17;
            this.searchTypeCheckBox.Text = "Search on Hard Drive";
            this.searchTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(982, 459);
            this.Controls.Add(this.searchTypeCheckBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.Menu2;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Web Forms Helper";
            this.Deactivate += new System.EventHandler(this.MainFormDeactivate);
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.companyIDcontextMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CompanyNameComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PdfCreate;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ContextMenuStrip ContextMenu2;
        private System.Windows.Forms.Button button5;        
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox xslBox;
        private System.Windows.Forms.ContextMenuStrip companyIDcontextMenu;
        private System.Windows.Forms.ToolStripMenuItem editCompaniesListToolStripMenuItem;
        private System.Windows.Forms.CheckBox searchTypeCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox xmlBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox divBox;
    }
}

