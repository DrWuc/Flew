using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPinyin;
namespace Flew.Util.StrHelper
{
    /// <summary>
    /// 汉字转拼音
    /// </summary>
    public class PinYin
    {
        #region 汉字转拼音     
        /// <summary>
        /// 单汉字转拼音
        /// </summary>
        /// <param name="hz"></param>
        /// <returns></returns>
        public static string GetPY(string hz)
        {
            string py = Pinyin.GetPinyin(hz);
            return py;
        }
        /// <summary>
        /// 集合转拼音
        /// </summary>
        /// <param name="hz"></param>
        /// <returns></returns>
        public static List<string> GetPY(List<string> hz)
        {
            List<string> pys = new List<string>(); 
            foreach (var item in hz)
            {
                string py = Pinyin.GetPinyin(item);
                pys.Add(py);
            }
            return pys;
        }
        #endregion
        #region 汉字转拼音简码
        /// <summary>
        /// 汉字转简码
        /// </summary>
        /// <param name="hz"></param>
        /// <returns></returns>
        public static string GetPYJM(string hz,Encoding code)
        {
            //Encoding gb2312 = Encoding.GetEncoding("GB2312");
            string jm = Pinyin.GetInitials(hz,code);
            return jm;
        }

        /// <summary>
        /// 汉字集合转拼音简码
        /// </summary>
        /// <param name="hz"></param>
        /// <returns></returns>
        public static List<string> GetPYJM(List<string> hz, Encoding code)
        {
            List<string> pys = new List<string>();
            foreach (var item in hz)
            {
                string py = Pinyin.GetInitials(item,code);
                pys.Add(py);
            }
            return pys;
        }
        #endregion
    }
}
