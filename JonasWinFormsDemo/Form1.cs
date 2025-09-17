namespace JonasWinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string myText = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            // Hier steht was ausgef�hrt werden soll, wenn Button Click eintritt

            if (eingabeBox.Text.Length > 0)
            {
                myText = eingabeBox.Text;
                MessageBox.Show("Der Text lautet: " + myText);

            }
            else { MessageBox.Show("Es wurde keine Eingabe gemacht!"); }
        }
    }

}
