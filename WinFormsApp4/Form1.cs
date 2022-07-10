namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        int pictureNum = 1;
        List<Car>cars = new List<Car>
            {
                new Car("Maserati", "Vendor1","2019","3.5"),
                new Car("Mustang", "Vendor2","2013","2.5"),
                new Car("Lamborghini", "Vendor3","2020","2.0"),
                new Car("Porsche", "Vendor4","2022","3.0"),

            };
        public Form1()
        {
            InitializeComponent();
           
            ChangePictures(pictureNum,cars);
        }

       private void ChangePictures(int picNum,List<Car> cars)
        {
            void ChangeLabels(int picNum)
            {
                lbl_Vendorr.Text = cars[picNum-1].Vendor;
                lbl_Modell.Text = cars[picNum - 1].Model;
                lbl_Yearr.Text = cars[picNum - 1].Year;
                lbl_Enginee.Text = cars[picNum - 1].Engine;
            }
            switch (picNum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.maserati;
                    ChangeLabels(picNum);
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.mustang;
                    ChangeLabels(picNum);
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.lamborghini;
                    ChangeLabels(picNum);

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.porsche;
                    ChangeLabels(picNum);
                    break;
                default:
                    break;
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            pictureNum-=1;
            if (pictureNum < 1)
            {
                pictureNum = 4;
            }
            ChangePictures(pictureNum,cars);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            pictureNum += 1;
            if (pictureNum > 4)
            {
                pictureNum = 1;
            }
            ChangePictures(pictureNum,cars);

        }

    }
}