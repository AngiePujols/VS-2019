using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi
{
    public partial class Form8 : Form
    {
        int i;
        bool busqueda;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = "1";
            dataGridView1.Rows[i].Cells[1].Value = "12/03/2021";
            dataGridView1.Rows[i].Cells[2].Value = "Lia Yaport";
            dataGridView1.Rows[i].Cells[3].Value = "Galleta de chocolate";
            dataGridView1.Rows[i].Cells[4].Value = "80";
            dataGridView1.Rows[i].Cells[5].Value = "6";
            dataGridView1.Rows[i].Cells[6].Value = "480";
            i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = "2";
            dataGridView1.Rows[i].Cells[1].Value = "12/03/2021";
            dataGridView1.Rows[i].Cells[2].Value = "Luis Ferenandez";
            dataGridView1.Rows[i].Cells[3].Value = "Bizcocho fresa";
            dataGridView1.Rows[i].Cells[4].Value = "500";
            dataGridView1.Rows[i].Cells[5].Value = "1";
            dataGridView1.Rows[i].Cells[6].Value = "500";
            i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = "3";
            dataGridView1.Rows[i].Cells[1].Value = "12/03/2021";
            dataGridView1.Rows[i].Cells[2].Value = "Maria Perez";
            dataGridView1.Rows[i].Cells[3].Value = "Bizcocho fresa";
            dataGridView1.Rows[i].Cells[4].Value = "500";
            dataGridView1.Rows[i].Cells[5].Value = "3";
            dataGridView1.Rows[i].Cells[6].Value = "1500";
            i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = "4";
            dataGridView1.Rows[i].Cells[1].Value = "20/03/2021";
            dataGridView1.Rows[i].Cells[2].Value = "Camila Mendez";
            dataGridView1.Rows[i].Cells[3].Value = "Brownies";
            dataGridView1.Rows[i].Cells[4].Value = "100";
            dataGridView1.Rows[i].Cells[5].Value = "1";
            dataGridView1.Rows[i].Cells[6].Value = "100";
            i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = "5";
            dataGridView1.Rows[i].Cells[1].Value = "12/03/2021";
            dataGridView1.Rows[i].Cells[2].Value = "Angie Carrasco";
            dataGridView1.Rows[i].Cells[3].Value = "galleta de chocolate";
            dataGridView1.Rows[i].Cells[4].Value = "80";
            dataGridView1.Rows[i].Cells[5].Value = "20";
            dataGridView1.Rows[i].Cells[6].Value = "1600";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            int rowIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridView1.ClearSelection();
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                        dataGridView1.Focus();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay información que concuerde con ese ID.");
            }

        }
    }
    }
    

