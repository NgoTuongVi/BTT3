using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTTH3
{
    class XL_BANG: DataTable()
    {
  //danh sach bien cuc bo
        #region Bien cuc bo
            public static String Chuoi_lien_ket;
            private SqlDataAdapter mBo_doc_ghi = new SqlDataAdapter();
            private SqlConnection mKet_noi;
            public string chuoi_csdl;
            private string mChuoi_sql;
            private string mTen_bang;
        #endregion

    
//danh sach thuoc tinh
        #region Cac thuoc tinh
            public String Chuoi_SQL
            {
                get { return mChuoi_sql; }
                set { mChuoi_sql = value;}
             }
             public String Ten_bang
            {
                get { return mTen_bang; }
                set { mTen_bang = value;}
             }
             public int So_dong
            {
                get { return this.DefaultView.Count; }
              
             }
          #endregion
    }

  //cac phuong thuc khoi tao
        #region Cac phuong thuc khoi tao
                public XL_BANG (): base(){}
            //tao moi bang
        public XL_BANG(String pTen_bang)

}
