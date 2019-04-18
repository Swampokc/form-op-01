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
            CreateTabels();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox7.Text = "00934801";
            else
                textBox7.Text = "09261762";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();
            dataGridView7.Rows.Clear();
            dataGridView8.Rows.Clear();
            dataGridView9.Rows.Clear();

            CreateTabels();

            if (comboBox3.SelectedIndex == 0)
            {
                textBox6.Text = "0782";
                setProductsBorsh(dataGridView1);
                setProductsBorsh(dataGridView6);
                setProductsBorsh(dataGridView9);
                for (int i = 0; i < 9; i++)
                {
                    dataGridView1[i, 9].ReadOnly = true;
                    dataGridView6[i, 9].ReadOnly = true;
                    dataGridView9[i, 9].ReadOnly = true;
                }
            }
            else
            {
                textBox6.Text = "0183";
                setProductsOlivie(dataGridView1);
                setProductsOlivie(dataGridView6);
                setProductsOlivie(dataGridView9);
                for (int i = 0; i < 9; i++)
                {
                    dataGridView1[i, 9].ReadOnly = true;
                    dataGridView6[i, 9].ReadOnly = true;
                    dataGridView9[i, 9].ReadOnly = true;
                }
            }
                
        }

        private void CreateTabels()
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
            dataGridView2[3, 0].ReadOnly = true;
            dataGridView2[4, 0].Value = "X";
            dataGridView2[4, 0].ReadOnly = true;
            dataGridView2[5, 0].Value = "X";
            dataGridView2[5, 0].ReadOnly = true;
            dataGridView2[6, 0].ReadOnly = true;

            dataGridView3[0, 0].Value = "Наценка 70 %, руб., коп.";
            dataGridView3[0, 0].ReadOnly = true;
            dataGridView3[0, 1].Value = "Цена продажи блюда, руб.коп.";
            dataGridView3[0, 1].ReadOnly = true;
            dataGridView3[0, 2].Value = "Выход одного блюда в готовом виде, грамм";
            dataGridView3[0, 2].ReadOnly = true;

            dataGridView3[1, 0].ReadOnly = true;
            dataGridView3[1, 1].ReadOnly = true;
            dataGridView3[1, 2].ReadOnly = true;
            dataGridView3[2, 0].ReadOnly = true;
            dataGridView3[2, 1].ReadOnly = true;
            dataGridView3[2, 2].ReadOnly = true;

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
            dataGridView5[3, 0].ReadOnly = true;
            dataGridView5[4, 0].Value = "X";
            dataGridView5[4, 0].ReadOnly = true;
            dataGridView5[5, 0].Value = "X";
            dataGridView5[5, 0].ReadOnly = true;
            dataGridView5[6, 0].ReadOnly = true;

            dataGridView4[0, 0].Value = "Наценка 70 %, руб., коп.";
            dataGridView4[0, 0].ReadOnly = true;
            dataGridView4[0, 1].Value = "Цена продажи блюда, руб.коп.";
            dataGridView4[0, 1].ReadOnly = true;
            dataGridView4[0, 2].Value = "Выход одного блюда в готовом виде, грамм";
            dataGridView4[0, 2].ReadOnly = true;

            dataGridView4[1, 0].ReadOnly = true;
            dataGridView4[1, 1].ReadOnly = true;
            dataGridView4[1, 2].ReadOnly = true;
            dataGridView4[2, 0].ReadOnly = true;
            dataGridView4[2, 1].ReadOnly = true;
            dataGridView4[2, 2].ReadOnly = true;

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
            dataGridView8[3, 0].ReadOnly = true;
            dataGridView8[4, 0].Value = "X";
            dataGridView8[4, 0].ReadOnly = true;
            dataGridView8[5, 0].Value = "X";
            dataGridView8[5, 0].ReadOnly = true;
            dataGridView8[6, 0].ReadOnly = true;

            dataGridView7[0, 0].Value = "Наценка 70 %, руб., коп.";
            dataGridView7[0, 0].ReadOnly = true;
            dataGridView7[0, 1].Value = "Цена продажи блюда, руб.коп.";
            dataGridView7[0, 1].ReadOnly = true;
            dataGridView7[0, 2].Value = "Выход одного блюда в готовом виде, грамм";
            dataGridView7[0, 2].ReadOnly = true;

            dataGridView7[1, 0].ReadOnly = true;
            dataGridView7[1, 1].ReadOnly = true;
            dataGridView7[1, 2].ReadOnly = true;
            dataGridView7[2, 0].ReadOnly = true;
            dataGridView7[2, 1].ReadOnly = true;
            dataGridView7[2, 2].ReadOnly = true;

            dataGridView9.ClearSelection();
            dataGridView8.ClearSelection();
            dataGridView7.ClearSelection();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1[i, j].ReadOnly = true;
                    dataGridView6[i, j].ReadOnly = true;
                    dataGridView9[i, j].ReadOnly = true;
                }
            }
        }

        private void setProductsBorsh(DataGridView dgv)
        {
            dgv[0, 0].Value = "1";
            dgv[1, 0].Value = "Мясо (говядина)";
            dgv[2, 0].Value = "0314";

            dgv[0, 1].Value = "2";
            dgv[1, 1].Value = "Картофель";
            dgv[2, 1].Value = "0723";

            dgv[0, 2].Value = "3";
            dgv[1, 2].Value = "Лук репчатый";
            dgv[2, 2].Value = "0162";

            dgv[0, 3].Value = "4";
            dgv[1, 3].Value = "Морковь";
            dgv[2, 3].Value = "0034";

            dgv[0, 4].Value = "5";
            dgv[1, 4].Value = "Свекла";
            dgv[2, 4].Value = "3364";

            dgv[0, 5].Value = "6";
            dgv[1, 5].Value = "Капуста";
            dgv[2, 5].Value = "0005";

            dgv[0, 6].Value = "7";
            dgv[1, 6].Value = "Чеснок";
            dgv[2, 6].Value = "2304";

            dgv[0, 7].Value = "8";
            dgv[1, 7].Value = "томатная паста";
            dgv[2, 7].Value = "2233";

            dgv[0, 8].Value = "9";
            dgv[1, 8].Value = "Уксус";
            dgv[2, 8].Value = "0934";
        }

        private void setProductsOlivie(DataGridView dgv)
        {
            dgv[0, 0].Value = "1";
            dgv[1, 0].Value = "Картофель";
            dgv[2, 0].Value = "0723";

            dgv[0, 1].Value = "2";
            dgv[1, 1].Value = "Морковь";
            dgv[2, 1].Value = "0034";

            dgv[0, 2].Value = "3";
            dgv[1, 2].Value = "Яйца";
            dgv[2, 2].Value = "0245";

            dgv[0, 3].Value = "4";
            dgv[1, 3].Value = "Огурцы соленые";
            dgv[2, 3].Value = "0309";

            dgv[0, 4].Value = "5";
            dgv[1, 4].Value = "Колбаса вареная";
            dgv[2, 4].Value = "0126";

            dgv[0, 5].Value = "6";
            dgv[1, 5].Value = "Майонез";
            dgv[2, 5].Value = "0001";

            dgv[0, 6].Value = "7";
            dgv[1, 6].Value = "Горошек зеленый";
            dgv[2, 6].Value = "0012";

            dgv[0, 7].Value = "8";
            dgv[1, 7].Value = "Лук зеленый";
            dgv[2, 7].Value = "2387";

            dgv[0, 8].Value = "9";
            dgv[1, 8].Value = "Соль";
            dgv[2, 8].Value = "0214";
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView3.ClearSelection();
        }

        private void dataGridView6_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        private void dataGridView9_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView5.ClearSelection();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4.ClearSelection();
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView8.ClearSelection();
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView7.ClearSelection();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value = Convert.ToInt32(dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value) *
                    Convert.ToInt32(dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value);
                int cost = 0;
                for (int i = 0; i < 10; i++)
                {
                    cost += Convert.ToInt32(dataGridView1[5, i].Value);
                }
                dataGridView2[3, 0].Value = cost;
                dataGridView3[1, 0].Value = cost * 0.7;
                dataGridView3[1, 1].Value = (cost + Convert.ToInt32(dataGridView2[3, 0].Value)) / 100;
                int weight = 0;
                for (int i = 0; i < 10; i++)
                {
                    weight += Convert.ToInt32(dataGridView1[3, i].Value);
                }
                dataGridView3[1, 2].Value = weight * 10;
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 6 || dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value = Convert.ToInt32(dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value) *
                    Convert.ToInt32(dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value);
                int cost = 0;
                for (int i = 0; i < 10; i++)
                {
                    cost += Convert.ToInt32(dataGridView1[8, i].Value);
                }
                dataGridView2[6, 0].Value = cost;
                dataGridView3[2, 0].Value = cost * 0.7;
                dataGridView3[2, 1].Value = (cost + Convert.ToInt32(dataGridView2[6, 0].Value)) / 100;
                int weight = 0;
                for (int i = 0; i < 10; i++)
                {
                    weight += Convert.ToInt32(dataGridView1[6, i].Value);
                }
                dataGridView3[2, 2].Value = weight * 10;
            }
        }

        private void dataGridView6_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView6.CurrentCell.ColumnIndex == 3 || dataGridView6.CurrentCell.ColumnIndex == 4)
            {
                dataGridView6[5, dataGridView6.CurrentCell.RowIndex].Value = Convert.ToInt32(dataGridView6[3, dataGridView6.CurrentCell.RowIndex].Value) *
                    Convert.ToInt32(dataGridView6[4, dataGridView6.CurrentCell.RowIndex].Value);
                int cost = 0;
                for (int i = 0; i < 10; i++)
                {
                    cost += Convert.ToInt32(dataGridView6[5, i].Value);
                }
                dataGridView5[3, 0].Value = cost;
                dataGridView4[1, 0].Value = cost * 0.7;
                dataGridView4[1, 1].Value = (cost + Convert.ToInt32(dataGridView5[3, 0].Value)) / 100;
                int weight = 0;
                for (int i = 0; i < 10; i++)
                {
                    weight += Convert.ToInt32(dataGridView6[3, i].Value);
                }
                dataGridView4[1, 2].Value = weight * 10;
            }

            if (dataGridView6.CurrentCell.ColumnIndex == 6 || dataGridView6.CurrentCell.ColumnIndex == 7)
            {
                dataGridView6[8, dataGridView6.CurrentCell.RowIndex].Value = Convert.ToInt32(dataGridView6[6, dataGridView6.CurrentCell.RowIndex].Value) *
                    Convert.ToInt32(dataGridView6[7, dataGridView6.CurrentCell.RowIndex].Value);
                int cost = 0;
                for (int i = 0; i < 10; i++)
                {
                    cost += Convert.ToInt32(dataGridView6[8, i].Value);
                }
                dataGridView5[6, 0].Value = cost;
                dataGridView4[2, 0].Value = cost * 0.7;
                dataGridView4[2, 1].Value = (cost + Convert.ToInt32(dataGridView5[6, 0].Value)) / 100;
                int weight = 0;
                for (int i = 0; i < 10; i++)
                {
                    weight += Convert.ToInt32(dataGridView6[6, i].Value);
                }
                dataGridView4[2, 2].Value = weight * 10;
            }
        }

        private void dataGridView9_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView9.CurrentCell.ColumnIndex == 3 || dataGridView9.CurrentCell.ColumnIndex == 4)
            {
                dataGridView9[5, dataGridView9.CurrentCell.RowIndex].Value = Convert.ToInt32(dataGridView9[3, dataGridView9.CurrentCell.RowIndex].Value) *
                    Convert.ToInt32(dataGridView9[4, dataGridView9.CurrentCell.RowIndex].Value);
                int cost = 0;
                for (int i = 0; i < 10; i++)
                {
                    cost += Convert.ToInt32(dataGridView9[5, i].Value);
                }
                dataGridView8[3, 0].Value = cost;
                dataGridView7[1, 0].Value = cost * 0.7;
                dataGridView7[1, 1].Value = (cost + Convert.ToInt32(dataGridView8[3, 0].Value)) / 100;
                int weight = 0;
                for (int i = 0; i < 10; i++)
                {
                    weight += Convert.ToInt32(dataGridView9[3, i].Value);
                }
                dataGridView7[1, 2].Value = weight * 10;
            }

            if (dataGridView9.CurrentCell.ColumnIndex == 6 || dataGridView9.CurrentCell.ColumnIndex == 7)
            {
                dataGridView9[8, dataGridView9.CurrentCell.RowIndex].Value = Convert.ToInt32(dataGridView9[6, dataGridView9.CurrentCell.RowIndex].Value) *
                    Convert.ToInt32(dataGridView9[7, dataGridView9.CurrentCell.RowIndex].Value);
                int cost = 0;
                for (int i = 0; i < 10; i++)
                {
                    cost += Convert.ToInt32(dataGridView9[8, i].Value);
                }
                dataGridView8[6, 0].Value = cost;
                dataGridView7[2, 0].Value = cost * 0.7;
                dataGridView7[2, 1].Value = (cost + Convert.ToInt32(dataGridView8[6, 0].Value)) / 100;
                int weight = 0;
                for (int i = 0; i < 10; i++)
                {
                    weight += Convert.ToInt32(dataGridView9[6, i].Value);
                }
                dataGridView7[2, 2].Value = weight * 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signs s1 = new Signs();
            s1.ShowDialog();
        }
    }
}
