
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
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
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
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 316);
            this.listBox1.TabIndex = 4;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Votação";
            this.tabPage2.UseVisualStyleBackColor = true;
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
    }
}

