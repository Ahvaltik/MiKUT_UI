using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiKUT_UI
{
    public class MainPresenter
    {
        public iView mainView;

        public MainPresenter(iView mainView)
        {
            this.mainView = mainView;
        }

        public void findBestTarrif()
        {

        }

        public void loadBilling()
        {            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK){
                MessageBox.Show(openFileDialog1.FileName);
            }
            
        }
    }
}
