using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Utilities
{
    public delegate void SafeInvokeDelegate(Action action);
    public class SafeInvoke
    {
        private readonly Control _threadControl;

        public SafeInvoke()
        {
            _threadControl = new Control();
        }

        public void Invoke(Action action)
        {
            if (_threadControl.InvokeRequired)
            {
                _threadControl.Invoke(new SafeInvokeDelegate(Invoke), new object[] { action });
            }
            else if(action != null)
            {
                action();
            }
        }
    }
}
