using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Dota2Scripts
{
    public class ES : IScript
    {
        private Stopwatch timer = new Stopwatch();
        public void Loop(){
            while (true){
                if (DotaControls.GetKeyState((int) Keys.B) < 0){
                    PullRoll();
                    DotaControls.WhilePressedStop(Keys.B);
                }                
                if (DotaControls.GetKeyState((int) Keys.G) < 0){
                    PullRollWithStone();
                    DotaControls.WhilePressedStop(Keys.G);
                }                
                if (DotaControls.GetKeyState((int) Keys.V) < 0){
                    UltRefresh();
                    DotaControls.WhilePressedStop(Keys.V);
                }
                if (timer.IsRunning && timer.ElapsedMilliseconds > 6000){
                    timer.Stop();
                }
            }
    }

        private void UltRefresh(){
            if (!timer.IsRunning || timer.ElapsedMilliseconds >= 5500){
                timer.Restart();            
                DotaControls.d();
            }

        }

        private static void PullRoll(){
            DotaControls.e();
            DotaControls.w();
        }
        private static void PullRollWithStone(){
            DotaControls.d();
            Thread.Sleep(20);
            DotaControls.e();
            DotaControls.w();
        }
    }
}
