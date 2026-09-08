namespace ComboBox_PictureBox
{
    public partial class Form1 : Form
    {
        //Ruta donde se encuentran las imagenes
        private readonly string rutarRecursos =
            Path.Combine(Application.StartupPath, "Resources");

        public Form1()
        {
            InitializeComponent();
            //Crear la funcion cargar en donde se cargaran las distribuciones al iniciar
            CargarDistribuciones();

            //Configurar el picturebox
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CargarDistribuciones()
        {
            combodistro.Items.Clear();

            combodistro.Items.Add("Puppy Linux");
            combodistro.Items.Add("Slax");
            combodistro.Items.Add("antiX");
            combodistro.Items.Add("Debian");
            combodistro.Items.Add("Tiny Core Linux");

        }

        private void combodistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Revisar el combobox tenga información
            if(combodistro.SelectedIndex == -1)
            {
                return;
            }
            string distroSelecionada =
                combodistro.SelectedItem.ToString();
            switch(distroSelecionada)
            {
                case "Puppy Linux":
                    MostrarDistro("Puppy Linux", "Puppy Linux es una distribucion ligera" + "Diseñada para funcionar correctamente en" + "equipos de pocos recursos \r\n\r\n" 
                        + "Requisitos aproximados: \r\n" + "· Procesador X86 o compatible \r\n" + " · 1 Giga de Ram recomendado\r\n" + "·Espacio reducido en diso","Puppy.png",
                        "https://puppylinux-woof-ce.github.io/");
                    break;
                case "Slax":
                    MostrarDistro(
                        "Slax", "Slax es una distribucion pequeña y" + "Portable que puede ejecutarse desde una" + "memoria USB.\r\n\r\n"
                        + "Requisitos aproximados:\r\n" + "· Procesador X86_64 o compatible\r\n" + "· 512 Mega de RAM o más\r\n" + "· Espacio reducido en disco" , "slax.png",
                        "https://www.slax.org/");
                    break;
            }

                       
        }
        

    }
}

                    
