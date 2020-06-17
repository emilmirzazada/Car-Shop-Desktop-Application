using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Turbo.Classes
{
    public class SqlUtils
    {
        private static SqlUtils sqlUtils;
        public string conString { get; set; }
        private SqlUtils()
        {
            conString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;
        }
        public static SqlUtils getInstance()
        {
            if (sqlUtils==null)
            {
                sqlUtils = new SqlUtils();
            }
            return sqlUtils;
        }

        public DataTable GetDataWithAdapter(string _query)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_query, sqlConnection);
            DataTable dtTable = new DataTable();
            sqlDataAdapter.Fill(dtTable);
            return dtTable;
        }


        public static byte[] imageToByteArray(Image img)
        {
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            return arr;
        }
        public static Image byteArrayToImage(byte[] byteArr)
        {
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(byteArr));
            return x;
        }
    }
}
