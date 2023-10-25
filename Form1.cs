namespace WindowsFormsGit
{
    public partial class Form1 : Form
    {
        List<string> quotes;
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            label1.Text = quotes[rand.Next(quotes.Count)];

           

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
 try
            {
                quotes = (await File.ReadAllLinesAsync("quotes.txt")).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}