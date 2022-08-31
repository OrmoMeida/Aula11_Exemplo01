using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11_Exemplo01
{
    struct Event
    {
        public string Name { get; set; }
        public string Date { get; set; }
    }
    public partial class Form1 : Form
    {
        List<Event> lstElements;
        public Form1()
        {
            InitializeComponent();
            lstElements = new List<Event>();
        }

        public static void AddOne(TextBox txt)
        {
            txt.Text = (int.Parse(txt.Text) + 1).ToString();
        }

        private bool CheckData()
        {
            try
            {
                Convert.ToDateTime(txtMskData.Text);
                return true;
            } 
            catch
            {
                return false;
            }
        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEvento.Text == string.Empty)
            {
                txtEvento.Focus();
                return;
            }

            if (e.KeyChar == ((char)Keys.Enter))
            {
                if (txtEvento.Text != string.Empty)
                    txtMskData.Focus();
            }
        }

        private void AddEvent(Event e)
        {
            listBox1.Items.Add(e.Name);
            listBox2.Items.Add(e.Date);
        }

        private void txtMskData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ((char)Keys.Enter))
                return;

            if (!CheckData())
            {
                MessageBox.Show("Insira uma data válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMskData.Focus();
                return;
            }

            Event evento = new Event { Date = txtEvento.Text, Name = txtMskData.Text };
            lstElements.Add(evento);
            AddEvent(evento);
            txtEvento.Clear();
            txtMskData.Clear();
            txtEvento.Focus();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {

            switch (lstCandidatos.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Por favor, selecione um candidato.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lstCandidatos.Focus();
                    break;

                case 0:
                    AddOne(txtCO1);
                    break;

                case 1:
                    AddOne(txtCO2);
                    break;

                case 2:
                    AddOne(txtCO3);
                    break;
            }

            lstCandidatos.ClearSelected();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            
            RemoverPlease(listBox1.SelectedIndex);
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
                return;

            RemoverPlease(listBox2.SelectedIndex);
        }

        private void RemoverPlease(int index)
        {
            if (MessageBox.Show("Tem certeza que deseja remover o item selecionado?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Remover(index);
        }

        private void Remover(int index)
        {
            try
            {
                listBox1.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);
            }
            catch {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCO1.Text = "0";
            txtCO2.Text = "0";
            txtCO3.Text = "0";
        }
    }
}
