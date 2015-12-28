using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /*Ward class contains methods necessary to retrieve and load 
     the List into the listboxes in Ward page*/

    public class Ward
    {
        public void load_NurseWard(ListBox listBox, Nurse n,List<Nurse> nList)
        {
            foreach (Nurse nOb in nList)
            {
                if (nOb.Rank < 3)
                {
                    listBox.Items.Add(nOb.Name + " - " + nOb.ID + ", Rank: " + nOb.Rank);
                }
            }
        }

        public void load_HighRankNurseWard(ListBox listBox, Nurse n, List<Nurse> nList)
        {
            foreach (Nurse nOb in nList)
            {
                if (nOb.Rank >= 3)
                {
                    listBox.Items.Add(nOb.Name + " - " + nOb.ID + ", Rank: " + nOb.Rank);
                }
            }
        }

        public void load_PatientWard(ListBox listBox, Patient p, List<Patient> pList)
        {
            foreach (Patient pOb in pList)
            {
                if (pOb.Discharged == false)
                {
                    listBox.Items.Add(pOb.Name + " - " + pOb.ID);
                }
            }
        }

        public void load_CPatientWard(ListBox listBox, Critical_patient cp, List<Critical_patient> cpList)
        {
            foreach (Critical_patient cpOb in cpList)
            {
                if (cpOb.Discharged == false)
                {
                    listBox.Items.Add(cpOb.Name + " - " + cpOb.ID);
                }
            }
        }
    }
}
