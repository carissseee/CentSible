using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentSible.Models;
using System.Windows.Forms;

namespace CentSible.Forms
{
    public partial class TransactionForm
    {
        private void DeleteTransaction(int rowIndex)
        {
            var row = dgvTransaction.Rows[rowIndex];
            int transactionID = Convert.ToInt32(row.Cells["colTransactionID"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this transaction?", "Delete Transaction", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                transactionLogic.DeleteTransaction(transactionID);
                LoadTransactions();
            }
        }
        private void CancelTransaction(int rowIndex)
        {
            var row = dgvTransaction.Rows[rowIndex];
            var idValue = row.Cells["colTransactionID"].Value;
            int transactionID = (idValue != null && idValue.ToString() != "") ? Convert.ToInt32(idValue) : -1;

            if (transactionID == -1)
            {
                dgvTransaction.Rows.RemoveAt(rowIndex);
                _isAddingNew = false;
            }
            else
            {
                _isEditing = false;
                _editingRowIndex = -1;
                LoadTransactions();
            }

            SetFilterButtons(true);
        }
    }
}
