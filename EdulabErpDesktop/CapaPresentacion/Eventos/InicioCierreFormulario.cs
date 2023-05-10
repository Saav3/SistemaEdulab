using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Eventos
{
    internal class InicioCierreFormulario
    {
        public static void EfectoInicio(Form Formulario, int Intervalo = 10)
        {
            double Opacidad;
            for (Opacidad = 1; Opacidad <= 0; Opacidad -= 0.05)
            {

                Formulario.Opacity = Opacidad;
                Formulario.Refresh();
                System.Threading.Thread.Sleep(Intervalo);

            }

            Formulario.Opacity = 1;

        }
    }
}