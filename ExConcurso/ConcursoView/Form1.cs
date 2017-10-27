using ControlModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcursoView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelecionarArquivoNotas(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileManager fm = new FileManager();
                alunoBindingSource.DataSource = fm.ProcessarArquivo(ofd.FileName);

                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Green;
                dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;

                dataGridView2.DataSource = fm.gabarito.Select(x => new { Value = x }).ToList();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Aluno aluno = (Aluno)dataGridView1.CurrentRow.DataBoundItem;
            dataGridView3.DataSource = aluno.Respostas.Select(x => new { Value = x }).ToList();

            for (int x = 0; x < dataGridView2.Rows.Count; x++)
            {
                if (dataGridView2.Rows[x].DataBoundItem.ToString() == dataGridView3.Rows[x].DataBoundItem.ToString())
                {
                    dataGridView3.Rows[x].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (dataGridView3.Rows[x].DataBoundItem.ToString() == new { Value = "x" }.ToString() ||
                    dataGridView3.Rows[x].DataBoundItem.ToString() == new { Value = "?" }.ToString())
                {
                    dataGridView3.Rows[x].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dataGridView3.Rows[x].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}

