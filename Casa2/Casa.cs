using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

using System.Drawing;

namespace Casa2
{
    class Casa
    {

        public Casa()
        {

        }

        public void dibujar()
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.Aqua);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(10, 0, 0);
            GL.Vertex3(10, 10, 0);
            GL.Vertex3(5, 15, 0);
            GL.Vertex3(0, 10, 0);
            GL.End();


            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.Bisque);
            GL.Vertex3(10, 0, 0);
            GL.Vertex3(10, 10, 0);
            GL.Vertex3(5, 15, 0);
            GL.Vertex3(20, 15, 0);
            GL.Vertex3(25, 10, 0);
            GL.Vertex3(25, 0, 0);
            GL.End();
        }

    }
}
