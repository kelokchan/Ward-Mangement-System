using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    // The first derived class which inherits Person class 
    public class Patient:Person
    {
        //Discharged boolean property to indicate whether the patient is discharged or not
        public bool Discharged { get; set; }

        /*The getID method is used to retrieve the latest ID in the datagrid, 
         * and then increment 1 to generate a new ID. If exception happens, return P0001 as the ID*/

        [DisplayName("Days to be hospitalized")]
        public int dayHospitalized { get; set; }
        public virtual int getID(DataGridView dgv)
        {
            try
            {
                int rowIndex = dgv.Rows.Count - 1;
                string lastID = dgv.Rows[rowIndex].Cells[4].Value.ToString();
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
