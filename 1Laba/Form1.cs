using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _1Laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 5;        
        }

            

            private void button1_Click(object sender, EventArgs e)
        {
            Founder founder = new Founder();
            founder.Matr();
            for (int i = 0; i < founder.N; ++i)
            {
                for (int j = 0; j < founder.M; ++j)
                {
                    dataGridView1.Rows[i].Cells[j].Value = founder.array[i, j];
                }
                Console.WriteLine();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class Founder
    {
     
    public double N = 3;
        public double M = 5;
        public double[,] array = new double[3, 5];

public void Matr() {
    var rand = new Random();

        for (int i = 0; i < N; ++i)
        {
            for (int j = 0; j < M; ++j)
            {
                array[i, j] = rand.Next(2, 10);
                double max = array[0, 0];
                if (max < array[i, j])
                {
                    max = array[i, j];
                }
            }
        }
           

            }
        public void Max()
        {
            double x = 1;
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; i < M; ++i)
                {

                   
                }
            }
        }


        }
           
    }
   