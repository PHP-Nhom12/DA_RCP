using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuPhimDAO
{
    public class DataProvider
    {
        static string strKetNoi = @"Data Source=.;Initial Catalog=QL_rap_chieu_phim;Integrated Security=True";

        public static SqlConnection TaoKetNoi()
        {
            SqlConnection con = new SqlConnection(strKetNoi);
            con.Open();
            return con;
        }
        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            return com.ExecuteReader();
        }

        public static SqlDataReader TruyVanDuLieu(string strTruyVan,SqlParameter[] param, SqlConnection conn) //trường hợp có parammeter
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            com.Parameters.AddRange(param);
            return com.ExecuteReader();
        }

        public static int CapNhatDuLieu(string strTruyVan, SqlParameter[] param, SqlConnection conn) //trường hợp có parammeter
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            com.Parameters.AddRange(param);
            //SqlDataAdapter sda = new SqlDataAdapter();
            //sda.UpdateCommand = com;
            return com.ExecuteNonQuery();
        }
        public static bool ThucThiCauLenh(string strCauLenh, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand(strCauLenh, con);
            int kq = cmd.ExecuteNonQuery();
            return kq > 0;
        }
        public static bool ThucThiCauLenh(string strCauLenh, SqlParameter[] param, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand(strCauLenh, con);
            cmd.Parameters.AddRange(param);
            int kq = cmd.ExecuteNonQuery();
            return kq > 0;
        }
    } 
}
