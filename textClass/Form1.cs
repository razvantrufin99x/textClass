namespace textClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text txt = new text();
            txt.addNewLine(new lineOfText("alfabetul limbii romane"));
            txt.printAllText(ref this.textBox1);
        }
    }
}