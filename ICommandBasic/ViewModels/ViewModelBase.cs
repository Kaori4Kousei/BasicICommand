using ICommandBasic.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICommandBasic.ViewModels
{
    public class ViewModelBase
    {
        public SimpleCommand SimpleCommand { get; set; }

        public ViewModelBase()
        {
            this.SimpleCommand = new SimpleCommand(this);
        }
        public void SimpleMethod()
        {
            Debug.WriteLine("Hello");
        }
    }
}
