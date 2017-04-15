using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turing
{
    public partial class Form1 : Form
    {

        const int ROWSIZE = 27;


        public Form1()
        {
            InitializeComponent();
        }

        public void LentaPrint()
        {
            lenta.RowHeadersVisible = false;
            lenta.ColumnHeadersVisible = false;
            lenta.AllowUserToAddRows = false;
            lenta.AllowUserToDeleteRows = false;
            lenta.AllowUserToResizeColumns = false;
            lenta.AllowUserToResizeRows = false;
            lenta.ColumnCount = lenta.Width / ROWSIZE;
            lenta.RowCount = 3;
            for (int i = 0; i < lenta.Columns.Count; i++)
            {
                int number = -(lenta.Columns.Count / 2) + i;                
                lenta.Columns[i].Width = ROWSIZE;
                lenta.Rows[0].Cells[i].ReadOnly = true;
                lenta.Rows[1].Cells[i].ReadOnly = true;              
                if (number == 0) lenta.Rows[0].Cells[i].Value = "\\/";
                    else lenta.Rows[0].Cells[i].Value = "";
                lenta.Rows[1].Cells[i].Value = number;
                lenta.Rows[2].Cells[i].Value = "";
            }

            for (int i = 0; i < lenta.Rows.Count; i++)
                lenta.Rows[i].Height = lenta.Height / 3 - 1;

        }

        public void ProgGridPrint(int col, int row)
        {
            progGrid.ColumnCount = col;
            progGrid.RowCount = row;

            int colSize = (progGrid.Width - progGrid.ColumnHeadersHeight - 2) / col;
            int rowSize = (progGrid.Height - progGrid.RowHeadersWidth - 2) / row;

            for (int i = 0; i < progGrid.Columns.Count; i++)
            {
                progGrid.Columns[i].HeaderText = "Q" + (i+1);
                progGrid.Columns[i].Width = colSize;
                
            }

            for (int i = 0; i < progGrid.Rows.Count; i++)
            {
                progGrid.Rows[i].HeaderCell.Value = i;
                progGrid.Rows[i].Height = rowSize;

            }
                


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgGridPrint(4,4);
            LentaPrint();

        }

        private void lenta_Resize(object sender, EventArgs e)
        {
            LentaPrint();
        }

        private void progGrid_Resize(object sender, EventArgs e)
        {
            ProgGridPrint(4, 4);
        }
    }
}
