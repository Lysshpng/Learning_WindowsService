using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoService
{
    [RunInstaller(true)]
    public partial class DemoServiceInstaller : System.Configuration.Install.Installer
    {
        public DemoServiceInstaller()
        {
            InitializeComponent();
        }
    }
}
