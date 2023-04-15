using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_juego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_persona_Click(object sender, EventArgs e)
        {

        }
        public int op = 0;
        private void btn_piedra_Click(object sender, EventArgs e)
        {
            pb_persona.Image = Image.FromFile("C:/Users/victo/source/repos/PPT juego/img/piedra.jpg");
            op = 1;
            fjuego();

        }

        private void btn_papel_Click(object sender, EventArgs e)
        {
            op= 2;
            pb_persona.Image = Image.FromFile("C:/Users/victo/source/repos/PPT juego/img/papel.jpg");
            fjuego();
        }

        private void btn_tijera_Click(object sender, EventArgs e)
        {
            pb_persona.Image = Image.FromFile("C:/Users/victo/source/repos/PPT juego/img/tijera.jpg");
            op= 3;
            fjuego();

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            pb_persona.Image = Image.FromFile("C:/Users/victo/source/repos/PPT juego/img/incio.jpg");
            pb_computadora.Image = Image.FromFile("C:/Users/victo/source/repos/PPT juego/img/incio.jpg");
            lb_mensaje.Visible = false;
        }
        void fjuego()
        {
            int min = 1;
            int max = 3;
            //lb_mensaje = new Label();
            Random rnd = new Random();
            int juego = rnd.Next(min, max + 1);//randon genera hasta n-1 por eso se le suma un digito
            //MessageBox.Show(juego.ToString());// muestra que numero estamos geneando

            switch (juego)
            {
                case 1:
                    pb_computadora.Image = Image.FromFile("C:/Users/victo/source/repos/PPT juego/img/piedra.jpg");
                    break;
                case 2:
                    pb_computadora.Image = Image.FromFile("C:/Users/victo/source/repos/PPT juego/img/papel.jpg");
                    break;
                case 3:
                    pb_computadora.Image = Image.FromFile("C:/Users/victo/source/repos/PPT juego/img/tijera.jpg");
                    break;
            }
            if ((op == 1 && juego == 3) || (op == 2 && juego == 1) || (op == 3 && juego == 2))
            {
                lb_mensaje.Text = juego.ToString("GANASTES");
                lb_mensaje.Visible=true;
                //MessageBox.Show("GANASTE");
                
            }
            else if ((op == 1 && juego == 2) || (op == 2 && juego == 3) || (op == 3 && juego == 1))
            {
                lb_mensaje.Text = juego.ToString("PERDISTES");
                lb_mensaje.Visible = true;
                //MessageBox.Show("PERDISTE");
            }
            else
            {
                lb_mensaje.Text = juego.ToString("EMPATES");
                lb_mensaje.Visible = true;
                //MessageBox.Show("EMPATE");
            }
        }

        private void lb_mensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
