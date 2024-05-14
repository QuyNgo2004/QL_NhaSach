using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;


namespace QLNS_DAL
{
    public class DAL_DATA
    {
        string serveName = "" ;
        string conection = "";
        QLNhaSachDataContext data = new QLNhaSachDataContext() ;
        public DAL_DATA()
        {
            
        }
        public void ThemDataBase(string serve ,string path)
        {
            XDocument xDocument = new XDocument(
                new XDeclaration("1.0","utf-8", "yes"),
                new XElement("Root",new XElement("ServeName", serve))
                );
            xDocument.Save(path +@"\Conection.xml");
        }
        public bool LoadData(string path)
        {
            XElement ConectionXML;
            IEnumerable<XElement> nullable;
            try
            {
                ConectionXML = XElement.Load(path + @"\Conection.xml");
                nullable = from el in ConectionXML.Elements("ServeName")
                           select el;
                foreach (XElement e in nullable)
                {
                    ServeName = e.Value;
                }

                Conection = @"Data Source=" + ServeName + ";Initial Catalog=QLNhaSach;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection sqlConnection = new SqlConnection(conection);
                data = new QLNhaSachDataContext(sqlConnection) ;
                sqlConnection.Open();

               
                }
            catch (Exception ex)
            {

                return false;
            }


            return true;
                 
        }
       

        public QLNhaSachDataContext Data { get => data; set => data = value; }
        public string ServeName { get => serveName; set => serveName = value; }
        public string Conection { get => conection; set => conection = value; }
    }
}
