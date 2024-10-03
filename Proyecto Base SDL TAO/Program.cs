using System;
using System.Media;
using Tao.Sdl;

namespace MyGame
{
    
    class Program
    {
        
        static Image image = Engine.LoadImage("assets/fondo.png");
        
        
        static void Main(string[] args)
        {
            Engine.Initialize();
            
            
            while (true)
            {
                
                CheckInputs();
                Update();
                Render();
                Sdl.SDL_Delay(20);  
            }
        }

        static void CheckInputs()
        {
            if (Engine.KeyPress(Engine.KEY_LEFT))
            {

            }

            if (Engine.KeyPress(Engine.KEY_LEFT))
            {

            }

            if (Engine.KeyPress(Engine.KEY_LEFT))
            {

            }

            if (Engine.KeyPress(Engine.KEY_LEFT))
            {

            }

            if (Engine.KeyPress(Engine.KEY_ESC))
            {
                Environment.Exit(0);
            }
        }

        static void Update()
        {
        
        }

        static void Render()
        {
            Engine.Clear();
            Engine.Draw(image, 0, 0);
            Engine.Show();
        }
    }
}