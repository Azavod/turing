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

        const int COLUMN_SIZE = 30;
        const int LENT_BEG = -7;        

        public List<cell> item = new List<cell>();
        protected int head = 0;
        protected int begn = LENT_BEG;
        protected string ABC = "_";
        protected int globalSost = 1;
        protected int kolSost = 4;

        public cell[] saveWord;
        protected int saveHead;
        protected int saveBegn;


        public Form1()
        {
            InitializeComponent();
        }

        public void LentaPrint(int nach, int head)
        {
            lenta.ColumnCount = lenta.Width / COLUMN_SIZE;
            lenta.RowCount = 3;
            int konc = nach + lenta.ColumnCount;
            for (int i = 0; i < lenta.ColumnCount; i++)
            {                               
                lenta.Columns[i].Width = COLUMN_SIZE;
                lenta.Rows[0].Cells[i].ReadOnly = true;
                lenta.Rows[1].Cells[i].ReadOnly = true;         
                lenta.Rows[1].Cells[i].Value = nach + i;
                lenta.Rows[0].Cells[i].Style.BackColor = Color.White;
                lenta.Rows[1].Cells[i].Style.BackColor = Color.MintCream;               
                lenta.Rows[2].Cells[i].Style.BackColor = Color.White;

                if ((nach + i) == head)
                {
                    lenta.Rows[0].Cells[i].Value = "\\/";
                    lenta.Rows[0].Cells[i].Style.BackColor = Color.LightSalmon;
                    lenta.Rows[1].Cells[i].Style.BackColor = Color.LightSalmon;
                    lenta.Rows[2].Cells[i].Style.BackColor = Color.LightSalmon;
                }
                else lenta.Rows[0].Cells[i].Value = "";

                var sim = GetValue(nach + i);
                if (sim != null)
                    lenta.Rows[2].Cells[i].Value = sim;
                else
                {
                    AddData ("_", nach + i);
                    lenta.Rows[2].Cells[i].Value = "_";
                }
            }

            for (int i = 0; i < lenta.Rows.Count; i++)
                lenta.Rows[i].Height = lenta.Height / 3 - 1;

        }

        public void ProgGridPrint()
        {
            progGrid.ColumnCount = alphabet.Text.Length;
            var col = progGrid.ColumnCount;
            progGrid.RowCount = kolSost;

            int colSize = (progGrid.Width - progGrid.RowHeadersWidth-2) / col;
            int rowSize = (progGrid.Height - progGrid.ColumnHeadersHeight-2) / kolSost;

            for (int i = 0; i < progGrid.Columns.Count; i++)
            {
                progGrid.Columns[i].HeaderText = alphabet.Text[i].ToString();
                progGrid.Columns[i].Width = colSize;
                progGrid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;


            }

            
            for (int i = 0; i < progGrid.Rows.Count; i++)
            {
                progGrid.Rows[i].HeaderCell.Value = "q" + (i+1);
                progGrid.Rows[i].Height = rowSize;
            }
                
        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            ProgGridPrint();
            LentaPrint(begn, head);
            ABC = alphabet.Text;
            clearLog_Click(null, null);
        }

        private void lenta_Resize(object sender, EventArgs e)
        {
            LentaPrint(begn, head);
        }

        private void progGrid_Resize(object sender, EventArgs e)
        {
            ProgGridPrint();
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

        }

        private void lenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            if (x != 2) return;
            int y = e.ColumnIndex;

            var cell = lenta.Rows[x].Cells[y];
            var cValue = (string)cell.Value;

            if (cValue == null) cValue = "_";
            if (cValue.Length > 1) cell.Value = "_";
                else
                if (!ABC.Contains(cValue)) cell.Value = "_";

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
            ProgGridPrint();         
        }

        private void oneStep_Click(object sender, EventArgs e)
        {
            oneCmd ();           
        }

        public void PrintLog(string comand)
        {
            String text = numCmd.Value + ") [" + comand + "] ";
            if (numCmd.Value < 10) text = " " + text;
            for (int i = head-5; i < head+5; i++)
            {
                if (i == head) text += GetValue(i) + "[Q" + globalSost + "]";
                    else text += GetValue(i);
            }        
            log.Items.Add (text);
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            log.Items.Clear();
            log.Items.Add("log :");
        }

        public bool oneCmd()
        {
            if (globalSost == 0) globalSost = 1;

            var cVl = GetValue(head)[0];
            int indSim = alphabet.Text.IndexOf(cVl);

            var comand = (string)progGrid[indSim, globalSost-1].Value;

            progGrid.CurrentCell = progGrid[indSim, globalSost - 1];

            if (comand == null)
                { log.Items.Add("Отсутствует команда!"); return false; }

            int sost;
            string simv;
            string move;
            if  (!parseComand(comand, out sost, out simv, out move))
            {
                { log.Items.Add("Неизвестная команда!"); return false; }
            }
            else
            {
                AddData(simv,head);
                if (move == "R" || move == ">") button2_Click(null, null);
                if (move == "L" || move == "<") button1_Click(null, null);
                globalSost = sost;
            }

            numCmd.Value += 1;
            PrintLog(comand);
            return true;
        }

        public bool parseComand(string comand, out int sost, out string simv, out string move)
        {
            sost = 0; simv = ""; move = "";

            if (comand.Length != 4) return false;

            if (!(comand[0] == 'q' || comand[0] == 'Q')) return false;

            var sostString = comand[1].ToString();
                if (!int.TryParse(sostString, out sost) || sost > kolSost)
                    return false;

            simv = comand[2].ToString();
                if (!ABC.Contains(simv))
                    return false;
            
            move = "RCLrcl<.>";
                if (!move.Contains(comand[3]))
                    return false;
                else move = comand[3].ToString();

            return true;       
        }

        private void allCmd_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0; 
            progressBar.Visible = true;                  
            numCmd.Value = 0;
            bool check;
            do
            {
                check = oneCmd();
                progressBar.Value = (int)((numCmd.Value / maxCmd.Value) * 100);
                                
            } while (numCmd.Value < maxCmd.Value - 1 && check && globalSost != 0);

            progressBar.Value = 100;

            if (numCmd.Value == maxCmd.Value)
                MessageBox.Show("Выполнено запланированное количество команд!");
            else
            if (check)
                log.Items.Add("---Программа завершена (Q0)---");

            numCmd.Value = 0;
            progressBar.Visible = false;
        }

        private void тест1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            alphabet.Text = "_012";
            globalSost = 1;
            head = 0;
            begn = -7;
            kolSost = 3;

            item.Clear();
            AddData("0", 0);
            AddData("0", 1);
            AddData("1", 2);
            AddData("1", 3);
            AddData("2", 4);
            AddData("2", 5);
            AddData("1", 6);
            AddData("1", 7);
            AddData("0", 8);

            Form1_Load(null, null);

            progGrid[0, 0].Value = "q01L";
            progGrid[1, 0].Value = "q31R";
            progGrid[2, 0].Value = "q12R";
            progGrid[3, 0].Value = "q30R";
            progGrid[0, 1].Value = "q02C";
            progGrid[1, 1].Value = "q22R";
            progGrid[2, 1].Value = "q10R";
            progGrid[3, 1].Value = "q21R";
            progGrid[0, 2].Value = "q00R";
            progGrid[1, 2].Value = "q22L";
            progGrid[2, 2].Value = "q32C";
            progGrid[3, 2].Value = "q12L";

        }

        private void тест2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            alphabet.Text = "_012";
            globalSost = 1;
            head = 0;
            begn = -7;
            kolSost = 3;

            item.Clear();
            AddData("0", 0);
            AddData("1", 1);
            AddData("2", 2);
            AddData("0", 3);
            AddData("1", 4);
            AddData("2", 5);
            AddData("0", 6);
            AddData("1", 7);
            AddData("2", 8);

            Form1_Load(null, null);

            progGrid[0, 0].Value = "q01L";
            progGrid[1, 0].Value = "q31R";
            progGrid[2, 0].Value = "q12R";
            progGrid[3, 0].Value = "q30R";
            progGrid[0, 1].Value = "q02C";
            progGrid[1, 1].Value = "q22R";
            progGrid[2, 1].Value = "q10R";
            progGrid[3, 1].Value = "q21R";
            progGrid[0, 2].Value = "q00R";
            progGrid[1, 2].Value = "q22L";
            progGrid[2, 2].Value = "q32C";
            progGrid[3, 2].Value = "q12L";

        }

        private void тест3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alphabet.Text = "_012";
            globalSost = 1;
            head = 0;
            begn = -7;
            kolSost = 3;

            item.Clear();
            AddData("0", 0);
            AddData("0", 1);
            AddData("1", 2);
            AddData("1", 3);
            AddData("2", 4);
            AddData("2", 5);
            AddData("1", 6);
            AddData("1", 7);
            AddData("0", 8);

            Form1_Load(null, null);

            progGrid[0, 0].Value = "q01L";
            progGrid[1, 0].Value = "q31R";
            progGrid[2, 0].Value = "q12R";
            progGrid[3, 0].Value = "q30R";
            progGrid[0, 1].Value = "q22C";
            progGrid[1, 1].Value = "q22R";
            progGrid[2, 1].Value = "q10R";
            progGrid[3, 1].Value = "q21R";
            progGrid[0, 2].Value = "q00R";
            progGrid[1, 2].Value = "q22L";
            progGrid[2, 2].Value = "q32C";
            progGrid[3, 2].Value = "q12L";
        }

        private void тест4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alphabet.Text = "_012";
            globalSost = 1;
            head = 0;
            begn = -7;
            kolSost = 3;

            item.Clear();
            AddData("0", 0);
            AddData("0", 1);
            AddData("1", 2);
            AddData("1", 3);
            AddData("2", 4);
            AddData("2", 5);
            AddData("1", 6);
            AddData("1", 7);
            AddData("0", 8);

            Form1_Load(null, null);

            progGrid[0, 0].Value = "q01L";
            progGrid[1, 0].Value = "q31R";
            progGrid[2, 0].Value = "q12R";
            progGrid[3, 0].Value = "q30R";
            progGrid[0, 1].Value = "q20L";
            progGrid[1, 1].Value = "q22R";
            progGrid[2, 1].Value = "q10R";
            progGrid[3, 1].Value = "q21R";
            progGrid[0, 2].Value = "q00R";
            progGrid[1, 2].Value = "q22L";
            progGrid[2, 2].Value = "q32C";
            progGrid[3, 2].Value = "q12L";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Show();
        }

        private void инструкцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            instructions.Show();
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;
        }

        private void очиститьLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearLog_Click(null, null);
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            this.Font = fontDialog.Font;
        }

        private void AddQ_Click(object sender, EventArgs e)
        {
            if (kolSost < 9)
            {
                this.kolSost++;
                ProgGridPrint();
            }
             
        }

        private void SubQ_Click(object sender, EventArgs e)
        {
            if (kolSost > 3)
            {
                this.kolSost--;
                ProgGridPrint();
            }               
        }

        private void loadWord_Click(object sender, EventArgs e)
        {
            if (saveWord != null)
            {
                item.Clear();
                foreach (var i in saveWord)
                {
                    item.Add(i);
                }
                log.Items.Add("Слово успешно загружено!");
                begn = saveBegn;
                head = saveHead;
                LentaPrint(begn, head);
            }
            else
            {
                log.Items.Add("Отсутствует сохраненное слово!");
            }
            
        }

        private void saveWrd_Click(object sender, EventArgs e)
        {
            saveWord = new cell[item.Count];
            item.CopyTo(saveWord);
            saveBegn = begn;
            saveHead = head;
            log.Items.Add("Слово успешно сохранено!");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveWrd_Click(null,null);
        }

        private void загрузитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loadWord_Click(null, null);
        }

        private void maxCmd_ValueChanged(object sender, EventArgs e)
        {
            if (maxCmd.Value <= numCmd.Value)
                numCmd.Value = maxCmd.Value - 1;
        }

        private void numCmd_ValueChanged(object sender, EventArgs e)
        {
            if (numCmd.Value >= maxCmd.Value)
                maxCmd.Value = numCmd.Value + 1;
        }
    }
}
