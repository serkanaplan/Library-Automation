using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Baglantilar
{
    public class Comboboxislemleri
    {
        Dbconnect conn = new Dbconnect();
       
        public  void combodoldur(string _DisplayMember, string _ValueMember, string _StoreProcedure, ComboBox cmb)
        {


            DataTable dtb = new DataTable();
            using (SqlConnection con = conn.baglanti())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = _StoreProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    int sonuc= conn.ackapat(cmd);
                    if (sonuc==-1)
                    {
                        using(SqlDataAdapter adap = new SqlDataAdapter(cmd))
                    {
                            adap.Fill(dtb);
                     }
                    }
                }
            }

            cmb.DataSource = dtb;
            cmb.DisplayMember = _DisplayMember;
            cmb.ValueMember = _ValueMember;


        }
    }
}
