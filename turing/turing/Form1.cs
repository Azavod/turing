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

        const int KOL_SOST = 4;
        const int LENT_BEG = -7;


        public List<cell> item = new List<cell>();
        protected int head = 0;
        protected int begn = LENT_BEG;
        protected string ABC = "_";
        protected int globalSost = 1;


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

                var sim = GetValue(nach + i);
                if (sim != null)
                    lenta.Rows[2].Cells[i].Value = sim;
                else
                {
                    AddData (" ", nach + i);
                    lenta.Rows[2].Cells[i].Value = " ";
                }
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
            ProgGridPrint(KOL_SOST);
            LentaPrint(begn, head);
            ABC = alphabet.Text;
        }

        private void lenta_Resize(object sender, EventArgs e)
        {
            LentaPrint(begn, head);
        }

        private void progGrid_Resize(object sender, EventArgs e)
        {
            ProgGridPrint(KOL_SOST);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            head++;
            begn++;
            lenta.ClearSelection();
            LentaPrint(begn, head);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            head--;
            begn--;
            lenta.ClearSelection();
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
            int x = e.RowIndex;
            if (x != 2) return;
            int y = e.ColumnIndex;

            var cell = lenta.Rows[x].Cells[y];
            var cValue = (string)cell.Value;

            if (cValue.Length > 1) cell.Value = " ";
                else
                if (!ABC.Contains(cValue)) cell.Value = " ";

            AddData (cValue, begn + y);
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

            if (memInd > -1 && item[memInd].value != value)
                item[memInd] = new cell(value, index); 
            else
                item.Add(new cell(value, index));
        }

        public string GetValue(int index)
        {
            foreach (var i in item)
             if (i.index == index)
               return i.value;

            return null;
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
            ProgGridPrint(KOL_SOST);         
        }

        private void oneStep_Click(object sender, EventArgs e)
        {
            oneCmd ();
            PrintLog();
        }

        public void PrintLog()
        {
            String text = numCmd.Value + ") " + head + " " + globalSost;
            log.Items.Add (text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            log.Items.Clear();
        }

        public bool oneCmd()
        {
            var cVl = GetValue(head)[0];
            if (cVl == ' ') cVl = '_';
            int indSim = alphabet.Text.IndexOf(cVl);

            var comand = (string)progGrid[indSim, globalSost-1].Value;

            if (comand == null)
                { MessageBox.Show("Отсутствует команда!"); return false; }

            int sost;
            string simv;
            string move;
            if  (!parseComand(comand, out sost, out simv, out move))
            {
                { MessageBox.Show("Неизвестная команда!"); return false; }
            }
            else
            {
                AddData(simv,head);
                if (move == "R") button2_Click(null, null);
                if (move == "L") button1_Click(null, null);
                globalSost = sost;
            }

            return true;
        }

        public bool parseComand(string comand, out int sost, out string simv, out string move)
        {
            sost = 0; simv = ""; move = "";

            if (comand.Length != 4) return false;

            if (comand[0] != 'Q') return false;

            var sostString = comand[1].ToString();
                if (!int.TryParse(sostString, out sost) || sost > KOL_SOST)
                    return false;

            simv = comand[2].ToString();
                if (!ABC.Contains(simv))
                    return false;
            
            move = "RCL";
                if (!move.Contains(comand[3]))
                    return false;
                else move = comand[3].ToString();

            return true;       
        }

        private void allCmd_Click(object sender, EventArgs e)
        {
            numCmd.Value = 0;
            bool check;
            do
            {
                numCmd.Value += 1;
                check = oneCmd();
                PrintLog();
            } while (numCmd.Value < 10000 && check && globalSost != 0);
            
            if (numCmd.Value == 10000)
                MessageBox.Show("Скорее всего программа не применима к данному слову !");
            else
            if (!check)
                MessageBox.Show("Некорректная команда!");
            else
                MessageBox.Show("---Программа завершена (Q0)---");


        }
    }
}
