﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLesson9.Objects
{
    /// <summary>
    /// SQLiteのDB定義
    /// 顧客クラス
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// プライマリーキー
        /// </summary>
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone { get; set; }
    }
}
