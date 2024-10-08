using System;
using System.Collections.Generic;

namespace ExpSimulator.Models
{
    /// <summary>
    /// ホールデータクラス
    /// </summary>
    internal class ClassHallData
    {
        /// <summary>
        /// ホール名
        /// </summary>
        internal string HallName { get; set; }

        /// <summary>
        /// 機種データリスト
        /// </summary>
        internal List<ClassModelData> ModelDataList = new List<ClassModelData>();
    }

    /// <summary>
    /// 機種データクラス
    /// </summary>
    internal class ClassModelData
    {
        /// <summary>
        /// 機種名
        /// </summary>
        internal string ModelName { get; set; }

        /// <summary>
        /// 設置台数 [台]
        /// </summary>
        internal int InstallNum { get; set; }

        /// <summary>
        /// 台データリスト
        /// </summary>
        internal List<ClassUnitData> UnitDataList = new List<ClassUnitData>();
    }

    /// <summary>
    /// 台データクラス
    /// </summary>
    internal class ClassUnitData
    {
        /// <summary>
        /// 台番号
        /// </summary>
        internal string UnitNum { get; set; }

        /// <summary>
        /// デイリーデータリスト
        /// </summary>
        internal List<ClassDailyData> DailyDataList = new List<ClassDailyData>();
    }

    /// <summary>
    /// デイリーデータクラス
    /// </summary>
    internal class ClassDailyData
    {
        /// <summary>
        /// 日付
        /// </summary>
        internal DateTime DateTime { get; set; }

        /// <summary>
        /// 履歴データリスト
        /// </summary>
        internal List<ClassHistoryData> HistoryData = new List<ClassHistoryData>();
    }

    /// <summary>
    /// 履歴データクラス
    /// </summary>
    internal class ClassHistoryData
    {
        /// <summary>
        /// 回転数 [回]
        /// </summary>
        internal int RotateCount { get; set; }

        /// <summary>
        /// 大当り種別
        /// </summary>
        internal int HitStatus { get; set; }
    }
}
