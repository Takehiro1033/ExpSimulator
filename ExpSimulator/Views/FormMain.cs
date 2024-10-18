using ExpSimulator.Controller;
using ExpSimulator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpSimulator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //デバッグ用
            ClassRegistModelBaseData RegistModelBaseData = new ClassRegistModelBaseData();

            RegistModelBaseData.RegistModelBaseData();
        }
    }
}
