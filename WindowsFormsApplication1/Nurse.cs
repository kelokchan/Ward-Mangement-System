using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //Nurse class which also inherits Person class, with own property - Rank
    public class Nurse:Person
    {
        public int Rank { get; set; }

        /*The getID method is used to retrieve the latest ID in the datagrid, 
         * and then increment 1 to generate a new ID. If exception happens, return N0001 as the ID*/
        public int getID(DataGridView dgv)
        {
            try
            {
                int rowIndex = dgv.Rows.Count - 1;
                string lastID = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                int idcount = Convert.ToInt32(lastID.Remove(0, 1));
                return idcount + 1;
            }
            catch
            {
                return 1;
            }
        }

    }
}
