using System;
using System.Runtime.InteropServices;
using System.Threading;
using AutoHotkey.Interop;

namespace Dota2Scripts
{
    internal class Program{

        private static void Main(string[] args){
            DotaControls.ahk = new AutoHotkeyEngine();           
            StartScript(new InvokerScript());
            //StartScript(new ES());
            StartScript(new Meepo());
            Console.ReadLine();
        }

        private static void StartScript(IScript script){
            Thread startThread = new Thread(new ThreadStart(script.Loop));
            startThread.Start();
        }

        private static void D3D(){

            
        }

        private static void InitializeScene(){
            // We load models and other stuff here later before we start the game loop
        }


    }
}