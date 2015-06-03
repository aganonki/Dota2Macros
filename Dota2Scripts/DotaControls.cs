using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoHotkey.Interop;

namespace Dota2Scripts
{
    public static class DotaControls{
        public static AutoHotkeyEngine ahk;

        public static void Click()
        {
            ahk.ExecRaw("MouseClick, left");
        }
        #region skills
        public static void q()
        {
            ahk.ExecRaw("Send {Q}");
        }
        public static void w()
        {
            ahk.ExecRaw("Send {W}");
        }
        public static void e()
        {
            ahk.ExecRaw("Send {E}");
        }
        public static void s()
        {
            ahk.ExecRaw("Send {S}");
        }
        public static void d()
        {
            Thread.Sleep(10);
            ahk.ExecRaw("Send {D}");
        }
        public static void f()
        {
            Thread.Sleep(10);
            ahk.ExecRaw("Send {F}");
        }       
        public static void r()
        {
            Thread.Sleep(10);
            ahk.ExecRaw("Send {R}");
        }
        #endregion
        #region items
        public static void numb1()
        {
            ahk.ExecRaw("Send {1}");
        }
        public static void numb2()
        {
            ahk.ExecRaw("Send {2}");
        }
        public static void numb3()
        {
            ahk.ExecRaw("Send {3}");
        }
        public static void z()
        {
            ahk.ExecRaw("Send {Z}");
        }
        public static void x()
        {
            ahk.ExecRaw("Send {X}");
        }
        public static void c()
        {
            ahk.ExecRaw("Send {C}");
        }
        public static void space()
        {
            ahk.ExecRaw("Send {Space}");
        }

        #endregion
        #region meepo
        public static void numb4()
        {
            ahk.ExecRaw("Send {4}");
        }
        public static void numb5()
        {
            ahk.ExecRaw("Send {5}");
        }
        public static void numb6()
        {
            ahk.ExecRaw("Send {6}");
        } 
        public static void numb7()
        {
            ahk.ExecRaw("Send {7}");
        }
        public static void numb8()
        {
            ahk.ExecRaw("Send {8}");
        }
        public static void numb9()
        {
            ahk.ExecRaw("Send {9}");
        }
        #endregion
        [DllImport("user32.dll")]
        internal static extern short GetKeyState(int keyCode);
        internal static void WhilePressedStop(Keys button)
        {
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            while (GetKeyState((int)button) < 0)
            {
                Thread.Sleep(10);
            }
        }
    }
}
