using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_op_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add();
            dataGridView5.Rows.Add();
            dataGridView8.Rows.Add();

            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView6.Rows.Add();
                dataGridView9.Rows.Add();
                if (i < 3)
                {
                    dataGridView3.Rows.Add();
                    dataGridView4.Rows.Add();
                    dataGridView7.Rows.Add();
                }
            }

            // Лист 1
            dataGridView2[0, 0].Value = "Общая стоимость сырьевого набора на 100 блюд";
            dataGridView2[0, 0].ReadOnly = true;
            dataGridView2[1, 0].Value = "X";
            dataGridView2[1, 0].ReadOnly = true;
            dataGridView2[2, 0].Value = "X";
            dataGridView2[2, 0].ReadOnly = true;
            dataGridView2[4, 0].Value = "X";
            dataGridView2[4, 0].ReadOnly = true;
            dataGridView2[5, 0].Value = "X";
            dataGridView2[5, 0].ReadOnly = true;

            dataGridView3[0, 0].Value = "Наценка 70 %, руб., коп.";
            dataGridView3[0, 0].ReadOnly = true;
            dataGridView3[0, 1].Value = "Цена продажи блюда, руб.коп.";
            dataGridView3[0, 1].ReadOnly = true;
            dataGridView3[0, 2].Value = "Выход одного блюда в готовом виде, грамм";
            dataGridView3[0, 2].ReadOnly = true;
            // dataGridView3[0, 3].Value = "Заведующий производством";
            // dataGridView3[0, 3].ReadOnly = true;
            // dataGridView3[0, 4].Value = "Калькуляцию составил";
            // dataGridView3[0, 4].ReadOnly = true;
            // dataGridView3[0, 5].Value = "УТВЕРЖДАЮ";
            // dataGridView3[0, 5].ReadOnly = true;

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();

            // Лист 2
            dataGridView5[0, 0].Value = "Общая стоимость сырьевого набора на 100 блюд";
            dataGridView5[0, 0].ReadOnly = true;
            dataGridView5[1, 0].Value = "X";
            dataGridView5[1, 0].ReadOnly = true;
            dataGridView5[2, 0].Value = "X";
            dataGridView5[2, 0].ReadOnly = true;
            dataGridView5[4, 0].Value = "X";
            dataGridView5[4, 0].ReadOnly = true;
            dataGridView5[5, 0].Value = "X";
            dataGridView5[5, 0].ReadOnly = true;

            dataGridView4[0, 0].Value = "Наценка 70 %, руб., коп.";
            dataGridView4[0, 0].ReadOnly = true;
            dataGridView4[0, 1].Value = "Цена продажи блюда, руб.коп.";
            dataGridView4[0, 1].ReadOnly = true;
            dataGridView4[0, 2].Value = "Выход одного блюда в готовом виде, грамм";
            dataGridView4[0, 2].ReadOnly = true;
            // dataGridView4[0, 3].Value = "Заведующий производством";
            // dataGridView4[0, 3].ReadOnly = true;
            // dataGridView4[0, 4].Value = "Калькуляцию составил";
            // dataGridView4[0, 4].ReadOnly = true;
            // dataGridView4[0, 5].Value = "УТВЕРЖДАЮ";
            // dataGridView4[0, 5].ReadOnly = true;

            dataGridView6.ClearSelection();
            dataGridView5.ClearSelection();
            dataGridView4.ClearSelection();

            // Лист 3
            dataGridView8[0, 0].Value = "Общая стоимость сырьевого набора на 100 блюд";
            dataGridView8[0, 0].ReadOnly = true;
            dataGridView8[1, 0].Value = "X";
            dataGridView8[1, 0].ReadOnly = true;
            dataGridView8[2, 0].Value = "X";
            dataGridView8[2, 0].ReadOnly = true;
            dataGridView8[4, 0].Value = "X";
            dataGridView8[4, 0].ReadOnly = true;
            dataGridView8[5, 0].Value = "X";
            dataGridView8[5, 0].ReadOnly = true;

            dataGridView7[0, 0].Value = "Наценка 70 %, руб., коп.";
            dataGridView7[0, 0].ReadOnly = true;
            dataGridView7[0, 1].Value = "Цена продажи блюда, руб.коп.";
            dataGridView7[0, 1].ReadOnly = true;
            dataGridView7[0, 2].Value = "Выход одного блюда в готовом виде, грамм";
            dataGridView7[0, 2].ReadOnly = true;
            // dataGridView7[0, 3].Value = "Заведующий производством";
            // dataGridView7[0, 3].ReadOnly = true;
            // dataGridView7[0, 4].Value = "Калькуляцию составил";
            // dataGridView7[0, 4].ReadOnly = true;
            // dataGridView7[0, 5].Value = "УТВЕРЖДАЮ";
            // dataGridView7[0, 5].ReadOnly = true;

            dataGridView9.ClearSelection();
            dataGridView8.ClearSelection();
            dataGridView7.ClearSelection();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            dataGridView5.ClearSelection();
            dataGridView6.ClearSelection();
            dataGridView7.ClearSelection();
            dataGridView8.ClearSelection();
            dataGridView9.ClearSelection();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.ColumnIndex == 1)
                {
                    if (dataGridView1[e.ColumnIndex - 1, e.RowIndex].ReadOnly == false)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1[e.ColumnIndex - 1, e.RowIndex].ReadOnly = true;
                        dataGridView1[e.ColumnIndex - 1, e.RowIndex].Style.BackColor = Color.Coral;
                        dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Coral;
                        dataGridView1[e.ColumnIndex + 1, e.RowIndex].ReadOnly = true;
                        dataGridView1[e.ColumnIndex + 1, e.RowIndex].Style.BackColor = Color.Coral;
                    }
                    else
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1[e.ColumnIndex - 1, e.RowIndex].ReadOnly = false;
                        dataGridView1[e.ColumnIndex - 1, e.RowIndex].Style.BackColor = Color.White;
                        dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly = false;
                        dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                        dataGridView1[e.ColumnIndex + 1, e.RowIndex].ReadOnly = false;
                        dataGridView1[e.ColumnIndex + 1, e.RowIndex].Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
