using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier_n_data
{
    class GetLoginStatus
    {
        public  bool Method(string LoginName, string LoginPass)
        {
            using (var db = new CashierDBEntities())
            {
                //get query for matching txtbox text and database
                IQueryable<LoginData> query = from LoginData in db.LoginDatas where LoginData.username == LoginName && LoginData.password == LoginPass select LoginData;
                return query.Any() ? true : false;
            }
        }
    }
}
