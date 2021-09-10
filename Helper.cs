using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_netframework472
{
    class Helper 
    {
        public static DataTable LINQResultConvertToDataTable<T>(IEnumerable<T> linqResult) // превращаем результат link  запроса в DataTable
        {
            DataTable dataTable = new DataTable(); // создаем пустую произвольную таблицу
            if (linqResult == null) return dataTable;
            PropertyInfo[] columns = null;
            foreach (T oneRecord in linqResult)
            {
                //init columns  - one iteration
                if (columns == null)
                {
                    columns = oneRecord.GetType().GetProperties();
                    foreach (PropertyInfo oneProp in columns)
                    {
                        dataTable.Columns.Add(oneProp.Name, oneProp.PropertyType);
                    }
                }
                //init rows
                DataRow oneRow = dataTable.NewRow();
                foreach (PropertyInfo pInfo in columns) //  pInfo = id, login, password
                {
                    oneRow[pInfo.Name] = pInfo.GetValue(oneRecord); // pseudo   id(user), login(user) ...
                }
                dataTable.Rows.Add(oneRow);
            }
            return dataTable;
        }



        public static string CreateMD5(string input) // производим шифрование
        {
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }




    }
}
