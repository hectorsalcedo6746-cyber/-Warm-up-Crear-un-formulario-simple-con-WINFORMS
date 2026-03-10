using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword1.Text) || string.IsNullOrEmpty(txtPassword2.Text))
            {
                MessageBox.Show("Ambos campos deben contener texto para validar");
                return;
            }

            string contrasena1 = txtPassword1.Text;
            string contrasena2 = txtPassword2.Text;

            if (!contrasena1.Equals(contrasena2))
            {
                MessageBox.Show("Las contraseñas no coinciden, deber ser iguales");
                return;
            }

            if (ValidatePasswordComplexity(contrasena1))
            {
                MessageBox.Show("CONTRASEÑA VALIDA");
            }
            else
            {
                MessageBox.Show("LA CONTRASEÑA NO SE CUMPLE CON LAS ESPECIFICACIONES");
            }
        }
        public bool ValidatePasswordComplexity(string password)

        {

            // Regex:
            // (?[a-z]): Al menos una minúscula
            // (?.[A-Z]): Al menos una mayúscula
            // (?=.*\d): Al menos un número
            // (?.*[^\da-zA-Z]): Al menos un simbolo (no alfanumérico)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).+$";
            return Regex.IsMatch(password, pattern);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
