using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidPractice;
using Microsoft.Practices.Unity;

namespace SolidWinforms
{
    public partial class frmSolidWinforms : Form
    {
        public frmSolidWinforms()
        {
            InitializeComponent();
        }
        
        

        private void btnGenerateArea_Click(object sender, EventArgs e)
        {

            SolidPractice.Container.RegisterElements(Globals.container);

            IStringMessenger stringAreaEnglishMessenger = Globals.container.Resolve<IStringMessenger>("StringAreaEnglishMessenger");
            IAreaCalculator areaCalc = Globals.container.Resolve<IAreaCalculator>();
            IVolumeCalculator volumeCalc = Globals.container.Resolve<IVolumeCalculator>();
            IShapeFactory sf = Globals.container.Resolve<IShapeFactory>();

           

            MessageBox.Show(stringAreaEnglishMessenger.Message(areaCalc.CalculateArea(Globals.iArea)));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SolidPractice.Container.RegisterElements(Globals.container);
            IShapeFactory sf = Globals.container.Resolve<IShapeFactory>();
            Globals.iArea.Add((IArea)sf.CreateShape(txtShapeName.Text, 5));
        }
    }
}
