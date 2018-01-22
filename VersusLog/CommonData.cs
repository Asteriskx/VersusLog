﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace VersusLog
{
    /// <summary>
    /// 共通データ・メソッドクラス
    /// </summary>
    public class CommonData
    {
        /// <summary>
        /// DB接続先情報
        /// </summary>
        public const string ConnectionString = @"Data Source=vslog.db";

        /// <summary>
        /// デッキ小分類取得処理
        /// </summary>
        /// <param name="MajorclassComboBox">デッキ大分類コンボボックス</param>
        /// <param name="SmallclassComboBox">デッキ小分類コンボボックス</param>
        public static void GetDeckSmallclass(ComboBox MajorclassComboBox, ComboBox SmallclassComboBox)
        {
            var DeckSmallclassDatasource = new List<string>();

            using (var con = new SQLiteConnection(CommonData.ConnectionString))
            {
                con.Open();

                using (var cmd = con.CreateCommand())
                {
                    //デッキ名取得用クエリ作成
                    cmd.CommandText = "select SMALLCLASS from DECK " +
                        "where MAJORCLASS = '" + MajorclassComboBox.Text + "'";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DeckSmallclassDatasource.Add(reader.GetString(0));
                        }
                        SmallclassComboBox.DataSource = DeckSmallclassDatasource;
                    }
                }

                con.Close();
            }
        }
    }
}