using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    //This is the additional class required to save and load the data in xml format
    public static class XML
    {

        /* xmlSerialize method is used to save record by taking different type of List as parameter,
         * hence method overloading is used here */

        public static void xmlSerialize(object obj, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            TextWriter textWriter = new StreamWriter(filename);
            serializer.Serialize(textWriter, obj);
            textWriter.Close();
        }
  
        /* xmlDeserilize method to return the List saved in xml back to the program,
         * method overloading is also used */
        public static List<Patient> xmlDeserialize(Patient p)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Patient>));
            TextReader textreader = new StreamReader("Patients.xml");
            List<Patient> patientList;
            patientList = (List<Patient>)deserializer.Deserialize(textreader);
            textreader.Close();
            return patientList;
        }

        public static List<Critical_patient> xmlDeserialize(Critical_patient cp)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Critical_patient>));
            TextReader textreader = new StreamReader("Critical_patients.xml");
            List<Critical_patient> c_patientList;
            c_patientList = (List<Critical_patient>)deserializer.Deserialize(textreader);
            textreader.Close();
            return c_patientList;
        }

        public static List<Nurse> xmlDeserialize(Nurse n)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Nurse>));
            TextReader textreader = new StreamReader("Nurses.xml");
            List<Nurse> nurseList;
            nurseList = (List<Nurse>)deserializer.Deserialize(textreader);
            textreader.Close();
            return nurseList;
        }
    }
}
