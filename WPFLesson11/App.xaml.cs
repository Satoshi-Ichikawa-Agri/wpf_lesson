using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFLesson11
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        // DB名
        static string databaseName = "Shop.db";

        // フォルダパスの指定
        static string folderPath = "C://Users//daiko//WpfProject//WPFLesson11";

        // DBのパス
        public static string DatabasePath = System.IO.Path.Combine(folderPath, databaseName);
    }
}
