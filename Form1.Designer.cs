
namespace Aula11_Exemplo01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.txtMskData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbCandidatos = new System.Windows.Forms.GroupBox();
            this.lstCandidatos = new System.Windows.Forms.ListBox();
            this.lblCO1 = new System.Windows.Forms.Label();
            this.lblCO2 = new System.Windows.Forms.Label();
            this.lblCO3 = new System.Windows.Forms.Label();
            this.gbVotos = new System.Windows.Forms.GroupBox();
            this.txtCO1 = new System.Windows.Forms.TextBox();
            this.txtCO2 = new System.Windows.Forms.TextBox();
            this.txtCO3 = new System.Windows.Forms.TextBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbCandidatos.SuspendLayout();
            this.gbVotos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.listBox2);
            this.tabPage.Controls.Add(this.listBox1);
            this.tabPage.Controls.Add(this.txtEvento);
            this.tabPage.Controls.Add(this.txtMskData);
            this.tabPage.Controls.Add(this.lblData);
            this.tabPage.Controls.Add(this.lblEvento);
            this.tabPage.Location = new System.Drawing.Point(4, 4);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(387, 400);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Datas";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(200, 69);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 316);
            this.listBox2.TabIndex = 5;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 316);
            this.listBox1.TabIndex = 4;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(58, 7);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(100, 20);
            this.txtEvento.TabIndex = 3;
            this.txtEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvento_KeyPress);
            // 
            // txtMskData
            // 
            this.txtMskData.Location = new System.Drawing.Point(58, 30);
            this.txtMskData.Mask = "00/00/0000";
            this.txtMskData.Name = "txtMskData";
            this.txtMskData.Size = new System.Drawing.Size(67, 20);
            this.txtMskData.TabIndex = 2;
            this.txtMskData.ValidatingType = typeof(System.DateTime);
            this.txtMskData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMskData_KeyPress);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(18, 30);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(7, 7);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(44, 13);
            this.lblEvento.TabIndex = 0;
            this.lblEvento.Text = "Evento:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnVotar);
            this.tabPage2.Controls.Add(this.gbVotos);
            this.tabPage2.Controls.Add(this.gbCandidatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Votação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbCandidatos
            // 
            this.gbCandidatos.Controls.Add(this.lstCandidatos);
            this.gbCandidatos.Location = new System.Drawing.Point(6, 7);
            this.gbCandidatos.Name = "gbCandidatos";
            this.gbCandidatos.Size = new System.Drawing.Size(375, 135);
            this.gbCandidatos.TabIndex = 0;
            this.gbCandidatos.TabStop = false;
            this.gbCandidatos.Text = "Candidatos";
            // 
            // lstCandidatos
            // 
            this.lstCandidatos.FormattingEnabled = true;
            this.lstCandidatos.Items.AddRange(new object[] {
            "C01",
            "C02",
            "C03"});
            this.lstCandidatos.Location = new System.Drawing.Point(7, 20);
            this.lstCandidatos.Name = "lstCandidatos";
            this.lstCandidatos.Size = new System.Drawing.Size(362, 95);
            this.lstCandidatos.TabIndex = 0;
            // 
            // lblCO1
            // 
            this.lblCO1.AutoSize = true;
            this.lblCO1.Location = new System.Drawing.Point(6, 16);
            this.lblCO1.Name = "lblCO1";
            this.lblCO1.Size = new System.Drawing.Size(26, 13);
            this.lblCO1.TabIndex = 1;
            this.lblCO1.Text = "C01";
            // 
            // lblCO2
            // 
            this.lblCO2.AutoSize = true;
            this.lblCO2.Location = new System.Drawing.Point(6, 44);
            this.lblCO2.Name = "lblCO2";
            this.lblCO2.Size = new System.Drawing.Size(28, 13);
            this.lblCO2.TabIndex = 2;
            this.lblCO2.Text = "CO2";
            // 
            // lblCO3
            // 
            this.lblCO3.AutoSize = true;
            this.lblCO3.Location = new System.Drawing.Point(6, 74);
            this.lblCO3.Name = "lblCO3";
            this.lblCO3.Size = new System.Drawing.Size(26, 13);
            this.lblCO3.TabIndex = 3;
            this.lblCO3.Text = "C03";
            // 
            // gbVotos
            // 
            this.gbVotos.Controls.Add(this.txtCO3);
            this.gbVotos.Controls.Add(this.txtCO2);
            this.gbVotos.Controls.Add(this.txtCO1);
            this.gbVotos.Controls.Add(this.lblCO1);
            this.gbVotos.Controls.Add(this.lblCO3);
            this.gbVotos.Controls.Add(this.lblCO2);
            this.gbVotos.Location = new System.Drawing.Point(13, 219);
            this.gbVotos.Name = "gbVotos";
            this.gbVotos.Size = new System.Drawing.Size(362, 100);
            this.gbVotos.TabIndex = 4;
            this.gbVotos.TabStop = false;
            // 
            // txtCO1
            // 
            this.txtCO1.Location = new System.Drawing.Point(47, 13);
            this.txtCO1.Name = "txtCO1";
            this.txtCO1.Size = new System.Drawing.Size(100, 20);
            this.txtCO1.TabIndex = 4;
            this.txtCO1.Text = "0";
            // 
            // txtCO2
            // 
            this.txtCO2.Location = new System.Drawing.Point(47, 41);
            this.txtCO2.Name = "txtCO2";
            this.txtCO2.Size = new System.Drawing.Size(100, 20);
            this.txtCO2.TabIndex = 5;
            this.txtCO2.Text = "0";
            // 
            // txtCO3
            // 
            this.txtCO3.Location = new System.Drawing.Point(47, 71);
            this.txtCO3.Name = "txtCO3";
            this.txtCO3.Size = new System.Drawing.Size(100, 20);
            this.txtCO3.TabIndex = 6;
            this.txtCO3.Text = "0";
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(22, 148);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(341, 23);
            this.btnVotar.TabIndex = 5;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbCandidatos.ResumeLayout(false);
            this.gbVotos.ResumeLayout(false);
            this.gbVotos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.MaskedTextBox txtMskData;
        private System.Windows.Forms.GroupBox gbCandidatos;
        private System.Windows.Forms.ListBox lstCandidatos;
        private System.Windows.Forms.GroupBox gbVotos;
        private System.Windows.Forms.TextBox txtCO3;
        private System.Windows.Forms.TextBox txtCO2;
        private System.Windows.Forms.TextBox txtCO1;
        private System.Windows.Forms.Label lblCO1;
        private System.Windows.Forms.Label lblCO3;
        private System.Windows.Forms.Label lblCO2;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button button1;
    }
}

