using AutoHotkey.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Dota2Scripts
{
    public class InvokerScript : IScript
    {
        public InvokerButtons Buttons;

        public InvokerScript(){
            Buttons = new InvokerButtons();
        }
        Thread combo;
        public void Loop(){
            while (true){
                if (DotaControls.GetKeyState(((int)Buttons.ss)) < 0){
                    SS();
                    if (Buttons.castss)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.ss);
                }if (DotaControls.GetKeyState((int)Buttons.cold) < 0){
                    coldsnap();
                    if (Buttons.castcold)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.cold);
                }if (DotaControls.GetKeyState((int)Buttons.walk) < 0){
                    invis();
                    if (Buttons.castwalk)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.walk);
                }if (DotaControls.GetKeyState((int)Buttons.wall) < 0){
                    wall();
                    if (Buttons.castwall)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.wall);
                }if (DotaControls.GetKeyState((int)Buttons.meteor) < 0){
                    meteor();
                    if (Buttons.castmeteor)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.meteor);
                }if (DotaControls.GetKeyState((int)Buttons.tornado) < 0){
                    tornado();
                    if (Buttons.casttornado)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.tornado);
                }if (DotaControls.GetKeyState((int)Buttons.spirits) < 0){
                    spirit();
                    if (Buttons.castspirits)


                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.spirits);
                } if (DotaControls.GetKeyState((int)Buttons.def) < 0)
                {
                    def();
                    if (Buttons.castdef)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.def);
                } if (DotaControls.GetKeyState((int)Buttons.emp) < 0)
                {
                    empblast();
                    if (Buttons.castemp)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.emp);
                }if (DotaControls.GetKeyState((int)Buttons.altracity) < 0){
                    alacrity();
                    if (Buttons.castaltracity)
                        DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.altracity);
                }
                if (DotaControls.GetKeyState((int)Buttons.EulCombo) < 0){
                    if (combo==null||(combo.ThreadState != ThreadState.Running&&combo.ThreadState!=ThreadState.WaitSleepJoin))
                    {
                        combo = new Thread(new ThreadStart(eul));
                        combo.Start();
                    }
                }
                if (DotaControls.GetKeyState((int)Keys.Left) < 0)
                {     
                    if(combo!=null)
                    combo.Abort();
                }
                if (DotaControls.GetKeyState((int)Buttons.SsMeteorDef) < 0){
                    if (combo == null || (combo.ThreadState != ThreadState.Running && combo.ThreadState != ThreadState.WaitSleepJoin))
                    {
                        combo = new Thread(new ThreadStart(ssmetdef));
                        combo.Start();
                    }                 
                }
                if (DotaControls.GetKeyState((int)Buttons.invokeD) < 0){
                    DotaControls.d();
                    DotaControls.WhilePressedStop(Buttons.invokeD);
                }
                if (DotaControls.GetKeyState((int)Buttons.invokeF) < 0){
                    DotaControls.f();
                    DotaControls.WhilePressedStop(Buttons.invokeF);
                }
                if (DotaControls.GetKeyState((int)Buttons.q3) < 0){
                    q3();
                    DotaControls.WhilePressedStop(Buttons.q3);
                }
                if (DotaControls.GetKeyState((int)Buttons.w3) < 0){
                    w3();
                    DotaControls.WhilePressedStop(Buttons.w3);
                }
                if (DotaControls.GetKeyState((int)Buttons.e3) < 0){
                    e3();
                    DotaControls.WhilePressedStop(Buttons.e3);
                }
                Thread.Sleep(10);
            }
        }



        private void ssmetdef()
        {
            SsDefMeteor();
            while (DotaControls.GetKeyState((int)Buttons.SsMeteorDef) < 0)
            {
                Thread.Sleep(10);
            }
        }

        private void eul()
        {
            EulSsDefMeteorCombo();
            while (DotaControls.GetKeyState((int)Buttons.EulCombo) < 0)
            {
                Thread.Sleep(10);
            }
        }

        #region skills     
        public void SS(){
            e3();
            DotaControls.r();
        }      
        public void coldsnap(){
            q3();
            DotaControls.r();
        }
        public void wall(){
            DotaControls.q();
            DotaControls.q();
            DotaControls.e();
            DotaControls.r();
        }

        public void invis(){
            DotaControls.q();
            DotaControls.q();
            DotaControls.w();
            DotaControls.r();
        }
        public void invisCast(){
            DotaControls.q();
            DotaControls.q();
            DotaControls.w();
            DotaControls.r();
            DotaControls.d();
        }        
        public void alacrity(){
            DotaControls.w();
            DotaControls.w();
            DotaControls.e();
            DotaControls.r();
        }        

        public void spirit(){
            DotaControls.e();
            DotaControls.e();
            DotaControls.q();
            DotaControls.r();
        }        
//        public void asd(){
//            
//        }
        public void empblast(){
            w3();
            DotaControls.r();
        }
        public void tornado(){
            DotaControls.w();
            DotaControls.w();
            DotaControls.q();
            DotaControls.r();
        }
        public void meteor(){
            DotaControls.w();
            DotaControls.e();
            DotaControls.e();
            DotaControls.r();
        }
        public void def(){
            DotaControls.q();
            DotaControls.w();
            DotaControls.e();
            DotaControls.r();
        }
#endregion
        #region controls
        public void q3(){
            DotaControls.q();DotaControls.q();DotaControls.q();          
        }        
        public void w3(){
            DotaControls.w();DotaControls.w();DotaControls.w();
        }        
        public void e3(){
            DotaControls.e();DotaControls.e();DotaControls.e();
        }


        #endregion
        #region combos
        public void EulSsDefMeteorCombo(){
            //eul 2.5sec
            //SS 1.7
            //meteor 1.3
            DotaControls.z();
            DotaControls.Click();
            Thread.Sleep(10);
            Thread.Sleep(800);
            SsDefMeteor();
        }

        public void SsDefMeteor(){
            DotaControls.d();
            Thread.Sleep(400);
            DotaControls.f();
            def();
            e3();
            Thread.Sleep(1300);
            DotaControls.d();
        }
        #endregion
    }

}
