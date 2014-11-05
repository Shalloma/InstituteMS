using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace InstituteMS
{
    class Teachers
    {
        public int teaID;
        private string teaFName;
        private string teaLName;
        private string teaNIC;
        private string teaContact;
        private string teaAdd1;
        private string teaAdd2;
        private string teaAdd3;
        private string teaEmail;
        private string teaSubject;
        int checkStatus;
        
        DBConnect db = new DBConnect();
        
        public void setTeacherValues(int teaID,string teaFName,string teaLName,string teaNIC, string teaContact,string teaAdd1,string teaAdd2,string teaAdd3,string teaEmail,string teaSubject) {
            this.teaID = teaID;
            this.teaFName = teaFName;
            this.teaLName = teaLName;
            this.teaNIC = teaNIC;
            this.teaContact = teaContact;
            this.teaAdd1 = teaAdd1;
            this.teaAdd2 = teaAdd2;
            this.teaAdd3 = teaAdd3;
            this.teaEmail = teaEmail;
            this.teaSubject = teaSubject;
        }
        public void RegisterTeacher() {
            db.cmd.CommandText = "INSERT INTO "+db.dbName+".Teachers(teaID,fname,lname,nic,contact,address1,address2,address3,mail,subName) VALUES('" + this.teaID + "','" + this.teaFName + "','" + this.teaLName + "','" + this.teaNIC + "','" + this.teaContact + "','" + this.teaAdd1 + "','" + this.teaAdd2 + "','" + this.teaAdd3 + "','" + this.teaEmail + "','" + this.teaSubject + "')";
            db.checkConn();
            checkStatus= db.cmd.ExecuteNonQuery();
            db.checkConn();
            if (checkStatus == 1)
            {
                MessageBox.Show("Save");
            }
            else {
                MessageBox.Show("Error");
            }
        }
        public void ModifyTeacher() {
            db.cmd.CommandText = "UPDATE " + db.dbName + ".Teachers SET teaID='"+this.teaID+"',fname='" + this.teaFName + "',lname='" + this.teaLName + "',nic='" + this.teaNIC + "',contact='" + this.teaContact + "',address1='" + this.teaAdd1 + "',address2='" + this.teaAdd2 + "',address3='" + this.teaAdd3 + "',mail='" + this.teaEmail + "',subName='" + this.teaSubject + "' WHERE teaID='"+this.teaID+"'";
            db.checkConn();
            checkStatus = db.cmd.ExecuteNonQuery();
            db.checkConn();
            if (checkStatus == 1)
            {
                MessageBox.Show("Updated");
            }
            else
                MessageBox.Show("not Updated");
        }
        public void DeleteTeacher() { 
        
        
        }
        public void SearchTeacher() {
            Teacher teaFor=new Teacher ();
            db.cmd.CommandText = "SELECT *FROM "+db.dbName+".Teachers WHERE teaID='"+this.teaID+"'";
            db.checkConn();
            MySqlDataReader read = db.cmd.ExecuteReader();
            read.Read();
                teaFor.teaID.Text = read["teaID"].ToString();
                teaFor.teaLName.Text = read["lname"].ToString();
                teaFor.teaContact.Text = read["contact"].ToString();
            db.checkConn();
        
        }
        public Tuple <string , string, string>SearchTeacher2() {
            Teacher teaFor = new Teacher();
            db.cmd.CommandText = "SELECT *FROM " + db.dbName + ".Teachers WHERE teaID='" + this.teaID + "'";
            db.checkConn();
            MySqlDataReader read = db.cmd.ExecuteReader();
            read.Read();
            string a = read["teaID"].ToString();
            string b = read["lname"].ToString();
            string c = read["contact"].ToString();
            db.checkConn();
            return new Tuple<string, string, string>(a, b, c);
        }
       
    }
}
