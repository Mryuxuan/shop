using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modal
{
    public class News
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string desn;

        public string Desn
        {
            get { return desn; }
            set { desn = value; }
        }
        string body;

        public string Body
        {
            get { return body; }
            set { body = value; }
        }
        int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

    }
}
