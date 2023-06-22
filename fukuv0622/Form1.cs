namespace fukuv0622
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] date = new int[10];
            int avg = 0;
            for (int i = 0; i < 10; i++)
            {
                date[i]=rand.Next(101);
                avg = avg + date[i];
            }
            label1.Text = $"{date[0]},{date[1]},{date[2]},{date[3]},{date[4]},{date[5]},{date[6]},{date[7]},{date[8]},{date[9]}";
            MessageBox.Show($"{avg / 10}");
        }
    }
}