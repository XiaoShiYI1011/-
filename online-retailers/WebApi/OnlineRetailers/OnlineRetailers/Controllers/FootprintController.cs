using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using OnlineRetailers.Models;

namespace OnlineRetailers.Controllers
{
    public class FootprintController : ApiController
    {
        /// <summary>
        /// ��ȡ�û��㼣
        /// </summary>
        /// <param name="userID">�û�ID</param>
        /// <returns>�����ʷ�б�</returns>
        [HttpGet]
        public HttpResponseMessage GetFootprint(string userID)
        {
            string JSON = "";
            using (OnlineRetailersDBEntities db = new OnlineRetailersDBEntities())
            {
                string sql = string.Format(@"select RecordsID, BrowseRecords.GoodsID, GoodsTitle, GoodsPrice, GoodsImg from BrowseRecords left join Goods on BrowseRecords.GoodsID = Goods.GoodsID where BrowseRecords.UserID = {0} order by Recordsttate desc", userID);
                List<GetFootprintItem> list = db.Database.SqlQuery<GetFootprintItem>(sql).ToList();
                if (list.Count > 0)
                {
                    JSON = new JavaScriptSerializer().Serialize(list);
                }
                else
                {
                    JSON = new JavaScriptSerializer().Serialize(false);
                }
            }
            return new HttpResponseMessage { Content = new StringContent(JSON, Encoding.UTF8, "application/json") };
        }

        /// <summary>
        /// ɾ��������ʷ��¼
        /// </summary>
        /// <param name="para.userID">�û�ID</param>
        /// <param name="para.recordsID">��¼��ID</param>
        /// <returns>�ɹ���true��|| ʧ�ܣ�false��</returns>
        [HttpPost]
        public HttpResponseMessage DeleteFootprintItem(dynamic para)
        {
            string JSON = "";
            using (OnlineRetailersDBEntities db = new OnlineRetailersDBEntities())
            {
                string sql = string.Format(@"delete BrowseRecords where UserID = {0} and RecordsID = {1}", para.userID, para.recordsID);
                if (db.Database.ExecuteSqlCommand(sql) > 0)
                {
                    JSON = new JavaScriptSerializer().Serialize(true);
                }
                else
                {
                    JSON = new JavaScriptSerializer().Serialize(false);
                }
            }
            return new HttpResponseMessage { Content = new StringContent(JSON, Encoding.UTF8, "application/json") };
        }

        /// <summary>
        /// ɾ��ȫ����ʷ��¼
        /// </summary>
        /// <param name="userID">�û�ID</param>
        /// <returns>�ɹ���true��|| ʧ�ܣ�false��</returns>
        [HttpGet]
        public HttpResponseMessage DeleteFootprintAll(string userID)
        {
            string JSON = "";
            using (OnlineRetailersDBEntities db = new OnlineRetailersDBEntities())
            {
                string sql = string.Format(@"delete BrowseRecords where UserID = {0}", userID);
                if (db.Database.ExecuteSqlCommand(sql) > 0)
                {
                    JSON = new JavaScriptSerializer().Serialize(true);
                }
                else
                {
                    JSON = new JavaScriptSerializer().Serialize(false);
                }
            }
            return new HttpResponseMessage { Content = new StringContent(JSON, Encoding.UTF8, "application/json") };
        }
    }
}