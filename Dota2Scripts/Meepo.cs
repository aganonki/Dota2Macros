using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota2Scripts
{
    public class Meepo : IScript
    {
        public void Loop(){
            while (true){
                if (DotaControls.GetKeyState((int) Keys.V) < 0){
                    PoofAll();
                    DotaControls.WhilePressedStop(Keys.V);
                }
                if (DotaControls.GetKeyState((int)Keys.B) < 0)
                {
                    Poof4();
                    DotaControls.WhilePressedStop(Keys.B);
                }

//                if (timer.IsRunning && timer.ElapsedMilliseconds > 6000){
//                    timer.Stop();
//                }
            }
        }

        private void PoofAll(){
            DotaControls.numb5();
            poof();
            DotaControls.numb6();
            poof();
            DotaControls.numb7();
            poof();
            DotaControls.numb8();
            poof();
            DotaControls.numb9();
            poof();
            DotaControls.numb4();
        }        
        private void Poof4(){
            DotaControls.numb6();
            poof();
            DotaControls.numb7();
            poof();
            DotaControls.numb8();
            poof();
            DotaControls.numb9();
            poof();
            DotaControls.numb5();
        }

        private static void poof(){
            DotaControls.w();
        }
    }
}
