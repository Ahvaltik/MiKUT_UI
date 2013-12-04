using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiKUT_UI
{
    public partial class MainForm : Form, iView
    {

        public MainPresenter mainPresenter;

        public MainForm()
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this);
        }

        public void showResult()
        {
            throw new NotImplementedException();
        }

        public void showNewTarrifForm()
        {
            throw new NotImplementedException();
        }

        public void showTarrifsForm()
        {
            throw new NotImplementedException();
        }

        public void showBillingFileBrowser()
        {
            throw new NotImplementedException();
        }

        private void bestTarrifButton_Click(object sender, EventArgs e)
        {

        }

        private void readBillingButton_Click(object sender, EventArgs e)
        {
            mainPresenter.loadBilling();
        }
        

        private void tarrifsButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
