using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //Critical patient class which inherits Patient (which inherits Person as well)
    public class Critical_patient:Patient
    {      
        [Browsable(false)] 
        public bool Critical { get; set; }

        [DisplayName("Illness level")] 
        public int IllnessLevel { get; set; }

        [DisplayName("Sharing ward")]
        public bool ShareWard { get; set; }

        /* The getID method is used to retrieve the latest ID in the datagrid, 
         * and then increment 1 to generate a new ID. If exception happens, return CP0001 as the ID */
         
         //In Critical patient, method overriding is used here, as the method name is same in Patient class 

        public override int getID(DataGridView dgv)
        {
            try
            {
                int rowIndex = dgv.Rows.Count - 1;
                string lastID = dgv.Rows[rowIndex].Cells[6].Value.ToString();
                int idcount = Convert.ToInt32(lastID.Remove(0, 2));
                return idcount + 1;
            }
            catch
            {
                return 1;
            }
        }

    }
}
