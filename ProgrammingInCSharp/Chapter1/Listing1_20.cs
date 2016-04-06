using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    class Listing1_20 : IExecuter
    {
        public void Execute(string[] args)
        {
            //WPF in Winforms has to run in its own STA thread
            Thread t = new Thread(ShowWPFDialog);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void ShowWPFDialog(object obj)
        {
            Listing1_20WinForm form = new Listing1_20WinForm();
            form.ShowDialog();
        }
    }
}
