using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLesson10
{
    public class Customer
    {
        /// <summary>
        /// プライマリーキー
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone { get; set; }


        public override string ToString()
        {
            return $"{Id} - {Name} - {Phone}";
        }
    }
}
