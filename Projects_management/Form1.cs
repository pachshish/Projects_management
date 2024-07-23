using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Projects_management
{
    public partial class Form1 : Form
    {
        //יצירת משתנה מטייפ אקסמל שיהיה גלובלי
        XmlDocument XmlDocument;

        //יצירת כתובת לשמירת הקבצים באיכסון
        string pathName = Directory.GetCurrentDirectory() + "\\ProjectsManagement.xml";
        public Form1()
        {
            InitializeComponent();
            XmlDocument = new XmlDocument();
            clearAll();
            loudAllProjects();
            showAll();
        }

        //פונקציית הרצת הקבצים
        private void loudAllProjects()
        {
            if (File.Exists(pathName))
            {
                try
                {
                XmlDocument.Load(pathName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                XmlNode root = XmlDocument.CreateElement("projects");
                XmlDocument.AppendChild(root);
                XmlDocument.Save(pathName);
            }
            
        }

        //פונקציית יצירת פרויקט
        private void btnAddProjact_Click(object sender, EventArgs e)
        {
            //הגדרת תג ביניים
            XmlNode project = XmlDocument.CreateElement("project");

            //הכנסת הערכים לתג הביניים
            project.AppendChild(XmlDocument.CreateElement("name")).InnerText = txtName.Text;
            project.AppendChild(XmlDocument.CreateElement("date")).InnerText = dtpDate.Text;
            project.AppendChild(XmlDocument.CreateElement("language")).InnerText = txtLanguage.Text;

            //הכנסת תג הביניים לתג הראשי
            XmlDocument.FirstChild.AppendChild(project);

            //שמירת הקובץ
            XmlDocument.Save(pathName);
            loudAllProjects();
            showAll();
        }
        //פונקציית ניקוי הנתונים מהלוח
        private void clearAll()
        {
            txtLanguage.Text = "";
            txtName.Text = "";
            
        }
        //פונקציית הצגת הפרויקטים בדאטא גריד
        private void showAll()
        {
            dgvProjact.Rows.Clear();
           foreach (XmlNode project in XmlDocument.FirstChild.ChildNodes)
            {
                string name = "", language = "", date = "";
                foreach (XmlNode node in project.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "name":
                            name = node.InnerText;
                            break;
                        case "date":
                            date = node.InnerText;
                            break;
                        case "language":
                            language = node.InnerText;
                            break;
                    }
                }
                dgvProjact.Rows.Add(name, language, date);
            }
            
        }
    }
}
