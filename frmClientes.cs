using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void cLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRUDDataSet);

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRUDDataSet.CLIENTES' table. You can move, or remove it, as needed.
            this.cLIENTESTableAdapter.Fill(this.cRUDDataSet.CLIENTES);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nOMETextBox.Focus();
        }
    }
}
