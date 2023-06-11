using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MethodMinValue
{
    public partial class Form1 : Form
    {
        private List<int> Stocks = new List<int>();
        private List<int> Needs = new List<int>();
        private bool allPlanCheckTrue = true;

        struct Element
        {
            public int valueCost;
            public int valueDelivery;
            public bool check;
        }

        private List<Element> DeliveredElement = new List<Element>();
        private Element[,] coefDelivery;

        public Form1()
        {
            InitializeComponent();
            dataGridView2.RowCount = 1;
            dataGridView2.Columns[0].Width = 60;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownRow_ValueChanged(object sender, EventArgs e)
        {
            addGridRowCol();
        }

        private void numericUpDownCol_ValueChanged(object sender, EventArgs e)
        {
            addGridRowCol();
        }

        private void addGridRowCol()
        {
            
            dataGridView2.RowCount = (int)numericUpDownRow.Value+1;
            dataGridView2.ColumnCount = (int)numericUpDownCol.Value+1;

            dataGridView2.Rows[0].DefaultCellStyle.BackColor = Color.Gray;
            dataGridView2.Columns[0].DefaultCellStyle.BackColor = Color.Gray;

            for (int j = 1; j < (dataGridView2.RowCount); j++)
            {
                for (int i = 1; i < dataGridView2.ColumnCount; i++)
                {
                    dataGridView2.Columns[i].HeaderText = string.Format("b"+i.ToString());
                    dataGridView2.Rows[j].HeaderCell.Value = string.Format("a" + (j).ToString());
                }
            }

            foreach (DataGridViewColumn column in dataGridView2.Columns)
                column.Width = 60;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            createMatrix();

            int countElementCheck = 0;
            int countElement = 0;

            while (allPlanCheckTrue) 
            {
                countElementCheck = 0;
                int min = 1000;
                int minI = 0;
                int minJ = 0;

                countElement = (coefDelivery.GetLength(0)-1) * (coefDelivery.GetLength(1)-1);

                // i = a(строка)
                // j = b(столбец)

                for (int i = 1; i < coefDelivery.GetLength(0); i++)
                {
                    for (int j = 1; j < coefDelivery.GetLength(1); j++)
                    {
                        if (!coefDelivery[i, j].check && coefDelivery[i, j].valueCost < min)
                        {
                            min = coefDelivery[i, j].valueCost;
                            minI = i;
                            minJ = j;
                        }
                    }
                }

                listBoxSteps.Items.Add($"Минимальное значение: c[a{minI}][b{minJ}] = {coefDelivery[minI, minJ].valueCost}");


                if (Stocks[minI - 1] >= Needs[minJ - 1])
                {
                    listBoxSteps.Items.Add($"Запасы a{minI}: {Stocks[minI - 1]}");
                    listBoxSteps.Items.Add($"Потребности b{minJ}: {Needs[minJ - 1]}");
                    coefDelivery[minI, minJ].valueDelivery = Needs[minJ - 1];
                    DeliveredElement.Add(coefDelivery[minI, minJ]);
                    listBoxSteps.Items.Add($"Доставлено: {Needs[minJ - 1]}");
                    Stocks[minI - 1] = Stocks[minI - 1] - Needs[minJ - 1];
                    Needs[minJ - 1] = 0;

                    listBoxSteps.Items.Add($"Осталось в запасах a{minI}: {Stocks[minI - 1]}");

                    dataGridView2.Rows[minI].Cells[0].Value = Stocks[minI - 1].ToString();
                    dataGridView2.Rows[0].Cells[minJ].Value = Needs[minJ - 1].ToString();
                    dataGridView2.Rows[minI].Cells[minJ].Value += $"({coefDelivery[minI, minJ].valueDelivery})";

                }
                else
                {
                    listBoxSteps.Items.Add($"Запасы a{minI}: {Stocks[minI - 1]}");
                    listBoxSteps.Items.Add($"Потребности b{minJ}: {Needs[minJ - 1]}");
                    Needs[minJ - 1] = Needs[minJ - 1] - Stocks[minI - 1];
                    coefDelivery[minI, minJ].valueDelivery = Stocks[minI - 1];
                    DeliveredElement.Add(coefDelivery[minI, minJ]);
                    listBoxSteps.Items.Add($"Доставлено: {Stocks[minI - 1]}");
                    Stocks[minI - 1] = 0;

                    listBoxSteps.Items.Add($"Осталось в запасах a{minI}: {Stocks[minI - 1]}");

                    dataGridView2.Rows[minI].Cells[0].Value = Stocks[minI - 1].ToString();
                    dataGridView2.Rows[0].Cells[minJ].Value = Needs[minJ - 1].ToString();
                    dataGridView2.Rows[minI].Cells[minJ].Value += $"({coefDelivery[minI, minJ].valueDelivery})";
                }

                if (Needs[minJ - 1] == 0)
                {
                    for (int i = 1; i < coefDelivery.GetLength(0); i++)
                    {
                        coefDelivery[i, minJ].check = true;
                    }
                }

                if (Stocks[minI - 1] == 0)
                {
                    for (int j = 1; j < coefDelivery.GetLength(1); j++)
                    {
                        coefDelivery[minI, j].check = true;
                    }
                }

                for (int i = 1; i < coefDelivery.GetLength(0); i++)
                {
                    for (int j = 1; j < coefDelivery.GetLength(1); j++)
                    {
                        if (coefDelivery[i, j].check)
                        {
                            countElementCheck++;
                        }
                    }
                }

                if (countElementCheck == countElement) 
                {
                    allPlanCheckTrue = false;
                }

            }

            calculateReferencePlan();

            Calculate.Enabled = false;
        }

        public void calculateReferencePlan() 
        {
            int costReferencePlan = 0;

            for (int i = 0; i < DeliveredElement.Count; i++)
            {
                costReferencePlan += DeliveredElement[i].valueCost * DeliveredElement[i].valueDelivery;
            }


            FileStream fs = new FileStream("test.txt", FileMode.Create);

            string text = "Значение целевой функции для этого опорного плана равно: " + costReferencePlan.ToString();

            StreamWriter writer = new StreamWriter(fs);

            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView2.SelectAll();
            Clipboard.SetDataObject(dataGridView2.GetClipboardContent());
            writer.WriteLine(Clipboard.GetText(TextDataFormat.Text));
            writer.WriteLine();
            writer.WriteLine(text);
            writer.Close();
            fs.Close();
        }

        private void createMatrix() 
        {
            Stocks.Clear();
            Needs.Clear();
            DeliveredElement.Clear();

            coefDelivery = null;

            for (int i = 1; i < dataGridView2.RowCount; i++)
            {
                Stocks.Add(Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value));
            }

            for (int j = 1; j < dataGridView2.ColumnCount; j++)
            {
                Needs.Add(Convert.ToInt32(dataGridView2.Rows[0].Cells[j].Value));
            }

            coefDelivery = new Element[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 1; i < dataGridView2.RowCount; i++)
            {
                for (int j = 1; j < dataGridView2.ColumnCount; j++)
                {
                    coefDelivery[i, j].valueCost = Convert.ToInt32(dataGridView2.Rows[i].Cells[j].Value);
                    coefDelivery[i, j].check = false;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClearTableButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            addGridRowCol();

            listBoxSteps.Items.Clear();

            allPlanCheckTrue = true;

            Calculate.Enabled = true;
        }
    }
}
