using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        #region Nhóm các thuộc tích Employee
        private int _id;
        private string id_card;
        private string name;
        private string email;
        private string phone;
        #endregion
        #region Nhóm các Constructor của Employee
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string IdCard
        {
            get { return id_card; }
            set { id_card = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        #endregion
        public void PrintInfor()
        {
            string msg = $"{_id}\t{Name}\t{id_card}\t{Email}\t{Phone}";
            Console.WriteLine(msg);
        }
        /*public override string ToString()
        {
            return msg;
        }*/

    }
}
