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
    class Game : GameWindow
    {

        Casa casa;

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color4.Black);
            casa = new Casa();
            base.OnLoad(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();

            casa.dibujar();

            Context.SwapBuffers();
            base.OnRenderFrame(e);

        }


        protected override void OnResize(EventArgs e)
        {
            float d = 30;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-80, 80, -80, 80, 4, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }



    }
}
