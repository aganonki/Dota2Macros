using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota2Scripts
{
    public class InvokerButtons{
        public Keys walk      = Keys.NumPad0;
        public Keys q3 = Keys.NumPad1;
        public Keys w3 = Keys.NumPad2;
        public Keys e3 = Keys.NumPad3;
        public Keys cold = Keys.NumPad4;
        public Keys spirits = Keys.NumPad5;
        public Keys ss = Keys.NumPad6;
        public Keys meteor = Keys.NumPad7;
        public Keys def = Keys.NumPad8;
        public Keys wall = Keys.NumPad9;
        public Keys emp = Keys.Multiply;
        public Keys tornado = Keys.Divide;
        public Keys altracity = Keys.Subtract;
        public Keys EulCombo = Keys.Decimal;
        public Keys SsMeteorDef = Keys.Right;
        public Keys invokeD = Keys.Add;
        public Keys invokeF = Keys.Enter;

        public bool castcold = false;
        public bool castmeteor  =false;
        public bool casttornado =false;
        public bool castwall = false;
        public bool castemp     =false;
        public bool castss      =false;
        public bool castdef     =false;
        public bool castspirits = false;
        public bool castaltracity =false;
        public bool castwalk = false;
    }
}
