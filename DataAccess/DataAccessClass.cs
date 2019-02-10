using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class DataAccessClass
    {
        SqlConnection con;
        public DataAccessClass()
        {
            con = new SqlConnection(@"Data Source=desktop-tmo7lmp\sqlexpress;Initial Catalog=ParkingManagementSystem;Integrated Security=True");
            con.Open();
        }
        
        public void InsertUser(string name, string pass, string confirmpass, string gender, string mail, string phone, string carno, string Bacc, string curraddress, string date)
        {
            SqlCommand str = new SqlCommand("insert into UserRegistrationTable values('" + name + "','"+pass+ "','"+ confirmpass +"','"+gender+ "','"+mail+ "','"+phone+ "','"+carno+ "','"+Bacc+ "','"+curraddress+ "','"+date+"')", con);
            str.ExecuteNonQuery();
        }
        public void InsertAdmin(string id,string name, string pass, string confirmpass, string gender, string mail, string phone, string curraddress, string parmanentadress, string shift, string joindate,string salary,string dob,string bloodgroup)
        {
            SqlCommand str = new SqlCommand("insert into AdminRegistrationTable values ('" + id + "','" + name + "','" + pass + "','" + confirmpass + "','" + gender + "','" + mail + "','" + phone + "','" + curraddress + "','" + parmanentadress + "','" + shift + "','" + joindate + "','" + salary + "','" + dob + "','" + bloodgroup + "')", con);
            str.ExecuteNonQuery();
        }
        public void InsertEmployee(string id, string name, string pass, string confirmpass, string gender, string mail, string phone, string curraddress, string parmanentadress, string shift, string joindate, string salary, string dob, string bloodgroup)
        {
            SqlCommand str = new SqlCommand("insert into EmployeeRegistrationTable values('" + id + "','" + name + "','" + pass + "','" + confirmpass + "','" + gender + "','" + mail + "','" + phone + "','" + curraddress + "','" + parmanentadress + "','" + shift + "','" + joindate + "','" + salary + "','" + dob + "','" + bloodgroup + "')", con);
            str.ExecuteNonQuery();
        }
        public DataTable UpdateEmployee(string id)
        {
            SqlCommand str = new SqlCommand("Select * from EmployeeRegistrationTable where id='" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable UpdateAdmin(string id)
        {
            SqlCommand str = new SqlCommand("Select  * from AdminRegistrationTable where id='" + id+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable UpdateUser(string carno)
        {
            SqlCommand str = new SqlCommand("Select  * from UserRegistrationTable where carnumber='" + carno + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void UpdateAEmployee(string id, string name, string pass, string confirmpass, string gender, string mail, string phone, string curraddress, string parmanentadress, string shift, string joindate, string salary, string dob, string bloodgroup)
        {
            SqlCommand str = new SqlCommand("Update EmployeeRegistrationTable Set id='"+id+"',name='" + name + "',password='" + pass + "',confirmpassword='" + confirmpass + "',gender='" + gender + "',mail='" + mail + "',phonenumber='" + phone + "',currentaddress='" + curraddress + "',parmanentaddress='" + parmanentadress + "',shift='" + shift + "',joindate='" + joindate + "',salary='" + salary + "',dob='" + dob + "',bloodgroup='" + bloodgroup + "' where id='"+id+"'", con);
            str.ExecuteNonQuery();
        }
        public void UpdateAdmin(string id, string name, string pass, string confirmpass, string gender, string mail, string phone, string curraddress, string parmanentadress, string shift, string joindate, string salary, string dob, string bloodgroup)
        {
            SqlCommand str = new SqlCommand("Update AdminRegistrationTable Set id='" + id + "',name='" + name + "',password='" + pass + "',confirmpassword='" + confirmpass + "',gender='" + gender + "',mail='" + mail + "',phonenumber='" + phone + "',currentaddress='" + curraddress + "',parmanentaddress='" + parmanentadress + "',shift='" + shift + "',joindate='" + joindate + "',salary='" + salary + "',dob='" + dob + "',bloodgroup='" + bloodgroup + "' where id='" + id + "'", con);
            str.ExecuteNonQuery();
        }
        public void UpdateAUser(string name, string pass, string confirmpass, string gender, string mail, string phone, string carno, string Bacc, string curraddress, string date)
        {
            SqlCommand str = new SqlCommand("Update UserRegistrationTable Set name='" + name + "',password='" + pass + "',confirmpassword='" + confirmpass + "',gender='" + gender + "',mail='" + mail + "',phonenumber='" + phone + "',carnumber='" + carno + "',bankaccountnumber='" + Bacc + "',currentaddress='" + curraddress + "',registrationdate='" + date + "' where carnumber='"+carno+"'", con);
            str.ExecuteNonQuery();
        }
        public void DeleteUser(string carno)
        {
            SqlCommand str = new SqlCommand("Delete from UserRegistrationTable where carnumber='" + carno+"'", con);
            str.ExecuteNonQuery();
        }
        public void DeleteEmployee(string id)
        {
            SqlCommand str = new SqlCommand("Delete from EmployeeRegistrationTable where id='" + id+"'", con);
            str.ExecuteNonQuery();
        }
        public void DeleteAdmin(string id)
        {
            SqlCommand str = new SqlCommand("Delete from AdminRegistrationTable where id='" + id+"'", con);
            str.ExecuteNonQuery();
        }
        public DataTable GetAllAdmin()
        {
            SqlCommand str = new SqlCommand("Select * from AdminRegistrationTable", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetAllEmployee()
        {
            SqlCommand str = new SqlCommand("Select * from EmployeeRegistrationTable", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetAllUser()
        {
            SqlCommand str = new SqlCommand("Select * from UserRegistrationTable", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchUser(string carno)
        {
            SqlCommand str = new SqlCommand("Select * from UserRegistrationTable where carnumber = '"+carno+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchAdmin(string id)
        {
            SqlCommand str = new SqlCommand("Select * from AdminRegistrationTable where id = '" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchEmployee(string id)
        {
            SqlCommand str = new SqlCommand("Select * from EmployeeRegistrationTable where id = '" + id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Login(string idorcarno)
        {
            DataTable dt = new DataTable();
            char chr = Helpchr(idorcarno);           //only first char from the input
            string ss = idorcarno.Remove(0, 1);                //without first char string from the input
            if(chr.Equals('A'))
            {
                SqlCommand str = new SqlCommand("select * from AdminRegistrationTable where id ='" + ss + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(str);
                da.Fill(dt);
                return dt;
            }
            if (chr.Equals('E'))
            {
                SqlCommand str = new SqlCommand("select * from EmployeeRegistrationTable where id ='" + ss + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(str);
                da.Fill(dt);
                return dt;
            }
            if (chr.Equals('U'))
            {
                SqlCommand str = new SqlCommand("select * from UserRegistrationTable where carnumber ='" + ss + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(str);
                da.Fill(dt);
                return dt;
            }
            else
            {
                dt = null;
                return dt;
            }
        }
        public char Helpchr(string idorcarno)
        {
            char chr = idorcarno.ToCharArray()[0];           //only first char from the input
            return chr;
        }
        public void InsertLoginTable(string idorcatno)
        {
            SqlCommand str = new SqlCommand("insert into LoginTable values('" + idorcatno +  "')", con);
            str.ExecuteNonQuery();
        }
        public void InsertBooking(string carnumber,string sloatnumber,string phonemumber,string entrydate,string entrytime)
        {
            SqlCommand str = new SqlCommand("insert into BookingTable values('" + carnumber + "','" + sloatnumber + "','" + phonemumber + "','" + entrydate + "','" + entrytime + "')", con);
            str.ExecuteNonQuery();
        }
        public DataTable BookingFinder()
        {
            SqlCommand str = new SqlCommand("select sloatnumber from BookingTable", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void InsertAssignCar(string carnumber,string sloatnumber,string phonenumber,string entrydate,string entrytime,string name,string gmail,string curraddress)
        {
            SqlCommand str = new SqlCommand("insert into AssignCarTable values('" + carnumber + "','" + sloatnumber + "','" + phonenumber + "','" + entrydate + "','" + entrytime + "','" +name+ "','" +gmail+ "','" +curraddress+ "')", con);
            SqlCommand str2 = new SqlCommand("insert into History values('" + carnumber + "','" + entrydate + "','" + entrytime + "')", con);

            str.ExecuteNonQuery();
            str2.ExecuteNonQuery();
        }
        public string SearchCarIntoBooking(string carno)
        {
            string carnnumber;
            SqlCommand str = new SqlCommand("select carnumber from BookingTable where carnumber ='"+carno+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            carnnumber = dt.Rows[0]["carnumber"].ToString().Trim();
            return carnnumber;
        }
        public void DeleteCarFromBooking(string carno)
        {
            SqlCommand str = new SqlCommand("Delete from BookingTable where carnumber='" + carno + "'", con);
            str.ExecuteNonQuery();
        }
        public void InsertHistory(string carno, string date, string time)
        {
            SqlCommand str = new SqlCommand("insert into History values('" + carno + "','" + date + "','" + time + "')", con);
            str.ExecuteNonQuery();
        }
        public DataTable GetAllHistoryTable()
        {
            SqlCommand str = new SqlCommand("Select * from History", con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
