using System;
using System.Drawing;
using System.Windows.Forms;

namespace Encrypt_and_Decrypt_with_pass__UI_
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
            setLang(0);
        }

        private void setLang(int id)
        {
            switch (id)
            {
                case 0:
                    {
                        lbl_Title.Text = "About developer";
                        lbl_Decription.Text = "My name is Carlos Ulises, I am student of software engineering career, \n I love everything related to technology and especially the development \n area. I am constantly learning more about the web development \n technologies for improve my skills in that area. \n\n If you want to modify this project, please keep my credits. Thank you!";
                        lbl_Copy.Text = "All rings reserved ® copyright © 2010 - " + DateTime.Now.Year;
                        lbl_ENG.ForeColor = Color.Black;
                        lbl_ES.ForeColor = SystemColors.Highlight;
                        break;
                    }
                case 1:
                    {
                        lbl_Title.Text = "Acerca del desarrollador";
                        lbl_Decription.Text = "Mi nombre es Carlos Ulises, soy estudiante de la carrera de ingeniería \n en sistemas computacionales, me encanta todo lo relacionado con la \n tecnología, especialmente el area del desarrollo web. \n\n Constantemente estoy intentando aprender nuevas tecnologías para \n poder mejorar mis habilidades en esa y otras areas. \n\n Si quieres modificar este proyecto, solo te pido conserves mis créditos, \n¡ gracias !";
                        lbl_Copy.Text = "Todos los derechos reservados® Copyright © 2010 - " + DateTime.Now.Year;
                        lbl_ES.ForeColor = Color.Black;
                        lbl_ENG.ForeColor = SystemColors.Highlight;
                        break;
                    }
            }
        }

        private void lbl_ENG_Click(object sender, EventArgs e)
        {
            setLang(0);
        }

        private void lbl_ES_Click(object sender, EventArgs e)
        {
            setLang(1);
        }
    }
}
