using System.Text;

namespace final_643450321_2_นายก้องภพ_ตาดี
{
    public partial class Form1 : Form
    {
        private string? strData;

        int num1, num2, num3;
        string op;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
                //this.textBox1.Text = readAllText;
                //this.dataGridView1.Rows.Add()
                addDataToGridView("book", "20");
            }
        }
        private void addDataToGridView(string List, string Price)
        {
            this.dataGridView1.Rows.Add(new string[] { List, Price });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {
                    filepath = saveFileDialog.FileName;

                    int row = this.dataGridView1.Rows.Count;
                    for (int i = 0; i <= row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for (int j = 0; j < column; j++)
                        {
                            strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            //TODO save data from dataGridview1 to variable
                        }
                    }
                    //save file
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "20";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "20";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "50";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(Display.Text);
            Display.Text = "";
            op = "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int price;
            double result, dis;

            price = Convert.ToInt32(Display.Text);
            if (price >= 0 && price <= 50)
            {
                txtDis.Text = "0 ";
                txtResult.Text = Convert.ToString(price);
            }
            else
            {
                if (price >= 51 && price <= 100)
                {
                    dis = price * 0.05;
                    txtDis.Text = Convert.ToString(dis);
                    result = price - dis;
                    txtResult.Text = Convert.ToString(result);
                }
                else
                {
                    if (price >= 101 && price <= 150)
                    {
                        dis = price * 0.10;
                        txtDis.Text = Convert.ToString(dis);
                        result = price - dis;
                        txtResult.Text = Convert.ToString(result);
                    }
                    else
                    {
                        dis = price * 0.20;
                        txtDis.Text = Convert.ToString(dis);
                        result = price - dis;
                        txtResult.Text = Convert.ToString(result);
                    }
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(Display.Text);
            if (op == "+")
            {
                num3 = num1 + num2;
                Display.Text = num3.ToString();
            }
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDis_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            float num4, num5, result;
            num4 = float.Parse(txtResult.Text);
            num5 = float.Parse(txtIncome.Text);
            result = num5 - num4;
            txtChange.Text = result.ToString("#,###");
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "10";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }
    }
}