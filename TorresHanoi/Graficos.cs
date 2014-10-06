using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresHanoi
{
    public class Graficos
    {
        public  static GraphicsPath FormaBoton(Point puntoIncial, Size TamCirculo)
        {
            GraphicsPath objGrafico = new GraphicsPath();
            Rectangle objRectangulo = new Rectangle(puntoIncial, TamCirculo);
            objGrafico.AddEllipse(objRectangulo);
            return objGrafico;


        }

    }
}
