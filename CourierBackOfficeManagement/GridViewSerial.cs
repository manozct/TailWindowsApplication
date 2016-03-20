using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierBackOfficeManagement
{
    public class GridViewSerial
    {
        public void LoadSerial(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                grid.Rows[row.Index].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
                row.Height = 27;
            }
        }
    }
}
