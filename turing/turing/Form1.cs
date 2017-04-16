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

        public struct cell
        {
            public string value;
            public int index;

            public cell(string value, int index)
            {
                this.value = value;
                this.index = index;
            }
        }


        const int COLSIZE = 30;

        const int PROG_Y = 4;
        const int LENT_BEG = -7;


        public List<cell> item = new List<cell>();
        protected int head = 0;
        protected int begn = LENT_BEG;
        protected string ABC = "_";



        public Form1()
        {
            InitializeComponent();
        }

        public void LentaPrint(int nach, int head)
        {
            lenta.ColumnCount = lenta.Width / COLSIZE;
            lenta.RowCount = 3;
            int konc = nach + lenta.ColumnCount;
            for (int i = 0; i < lenta.ColumnCount; i++)
            {                               
                lenta.Columns[i].Width = COLSIZE;
                lenta.Rows[0].Cells[i].ReadOnly = true;
                lenta.Rows[1].Cells[i].ReadOnly = true;              
                if ((nach + i) == head) lenta.Rows[0].Cells[i].Value = "\\/";
                    else lenta.Rows[0].Cells[i].Value = "";
                lenta.Rows[1].Cells[i].Value = nach + i;
                lenta.Rows[1].Cells[i].Style.BackColor = Color.MintCream;
                lenta.Rows[2].Cells[i].Value = GetValue(nach + i);
            }

            for (int i = 0; i < lenta.Rows.Count; i++)
                lenta.Rows[i].Height = lenta.Height / 3 - 1;

        }

        public void ProgGridPrint(int row)
        {
            progGrid.ColumnCount = alphabet.Text.Length;
            var col = progGrid.ColumnCount;
            progGrid.RowCount = row;

            int colSize = (progGrid.Width - progGrid.ColumnHeadersHeight - 2) / col;
            int rowSize = (progGrid.Height - progGrid.RowHeadersWidth - 2) / row;

            for (int i = 0; i < progGrid.Columns.Count; i++)
            {
                progGrid.Columns[i].HeaderText = alphabet.Text[i].ToString();
                progGrid.Columns[i].Width = colSize;
                progGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;


            }

            for (int i = 0; i < progGrid.Rows.Count; i++)
            {
                progGrid.Rows[i].HeaderCell.Value = i;
                progGrid.Rows[i].Height = rowSize;

            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgGridPrint(PROG_Y);
            LentaPrint(begn, head);
            ABC = alphabet.Text;
        }

        private void lenta_Resize(object sender, EventArgs e)
        {
            LentaPrint(begn, head);
        }

        private void progGrid_Resize(object sender, EventArgs e)
        {
            ProgGridPrint(PROG_Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            head++;
            begn++;
            LentaPrint(begn, head);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            head--;
            begn--;
            LentaPrint(begn, head);
        }

        private void progGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = progGrid.CurrentCell.RowIndex;
            int y = progGrid.CurrentCell.ColumnIndex;

            var cell = progGrid.Rows[x].Cells[y];                
            var cValue = (string)cell.Value;
                if (cValue == null) return;
            
            if (!(cValue.Length == 0 || cValue.Length == 4))
                { cell.Value = ""; return; }
            // if ()    

        }

        private void lenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = lenta.CurrentCell.RowIndex;
            int y = lenta.CurrentCell.ColumnIndex;

            var cell = lenta.Rows[x].Cells[y];
            var cValue = (string)cell.Value;

            if (cValue.Length > 1) cell.Value = "";
                else
                if (!ABC.Contains(cValue)) cell.Value = "";

            AddData (cValue, begn+y);
        }

        public void AddData(string value, int index)
        {

            int memInd = -1;
            for (int i = 0; i < item.Count - 1; i++)
                if (item[i].index == index)
                {
                    memInd = i;
                    break;
                }

            if (memInd > -1) item[memInd] = new cell(value, index);
            else
                item.Add(new cell(value, index));
        }

        public string GetValue(int index)
        {
            foreach (var i in item)
             if (i.index == index)
               return i.value;

            AddData("", index);
            return "";
        }

        private void alphabet_TextChanged(object sender, EventArgs e)
        {
            var text = alphabet.Text;
                if (text == "") { alphabet.Text = "_"; return; }                                 
            var sim = text[text.Length-1];

            bool flag = false;
            foreach (var s in text)
                if (s == '_') { flag = true; break; }
            if (!flag) { text = "_" + text; alphabet.Text = text; }    
                
            for (int i = 0; i < text.Length-1; i++)
              for (int j = i+1; j < text.Length; j++)
                if (text[i] == text[j])
                    {
                        alphabet.Text = ABC;
                        return;
                    }
                    
            ABC = alphabet.Text;
            ProgGridPrint(PROG_Y);         
        }

        
    }
}
