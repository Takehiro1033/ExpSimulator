using System;
using System.Collections.Generic;

namespace ExpSimulator.Models
{
    /// <summary>
    /// 機種基盤データクラス
    /// </summary>
    internal class ClassModelBaseData
    {
        /// <summary>
        /// 機種名
        /// </summary>
        internal string ModelName { get; set; }

        /// <summary>
        /// メーカー
        /// </summary>
        internal string MakerName { get; set; }

        /// <summary>
        /// 導入開始日
        /// </summary>
        internal DateTime IntroductStartDate { get; set; }

        /// <summary>
        /// 機種性能データ
        /// </summary>
        internal ClassModelSpecData ModelSpecData = new ClassModelSpecData();

        /// <summary>
        /// 機種補足データ
        /// </summary>
        internal ClassModelSuppleData ModelSuppleData = new ClassModelSuppleData();
    }

    /// <summary>
    /// 機種性能データクラス
    /// </summary>
    internal class ClassModelSpecData
    {
        /// <summary>
        /// 初当り確率 [1/n]
        /// </summary>
        internal double FirstHitProb { get; set; }

        /// <summary>
        /// 確変当り確率 [1/n]
        /// </summary>
        internal double RandVarHitProb { get; set; }

        /// <summary>
        /// 確変突入率 [%]
        /// </summary>
        internal double RandVarHitEntryRate { get; set; }

        /// <summary>
        /// 確変継続率 [%]
        /// </summary>
        internal double RandVarHitContinueRate { get; set; }

        /// <summary>
        /// ST [回]
        /// </summary>
        internal int SpecialTime { get; set; }

        /// <summary>
        /// 時短回数 [回]
        /// </summary>
        internal int SavingTime { get; set; }

        /// <summary>
        /// CT [回]
        /// </summary>
        internal int Ctime { get; set; }
    }

    /// <summary>
    /// 機種補足データクラス
    /// </summary>
    internal class ClassModelSuppleData
    {
        /// <summary>
        /// ボーダー回転数 [回]
        /// </summary>
        internal double BorderRotateCount { get; set; }

        /// <summary>
        /// ランキング
        /// </summary>
        internal int Ranking { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        internal string Note { get; set; }
    }
}
