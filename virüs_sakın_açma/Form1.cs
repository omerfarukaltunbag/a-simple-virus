using System;


using System.Windows.Forms;


namespace virüs_sakın_açma
{
    
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vrs1.vrsp1();
           vrs2.vrsp2();


         }


    

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("koruma için bu uygulama açık kalmalıdır");
        }
    }
}
