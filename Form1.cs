namespace HDD_Interface_Animal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Call_Click(object sender, EventArgs e)
        {
            Animal[] animalAray = new Animal[3];
            animalAray[0] = new Cat();
            animalAray[1] = new Dog();
            animalAray[2] = new Bird();
            foreach (Animal a in animalAray)
            {
                ILiveAnimal b = a as ILiveAnimal;
                if (b != null)
                    MessageBox.Show(b.BabyCall());
            }
        }
    }
}
