using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpSimulator.Models;

namespace ExpSimulator.Controller
{
    internal class ClassRegistModelBaseData
    {
        /// <summary>
        /// 機種基盤データを登録
        /// </summary>
        internal void RegistModelBaseData()
        {
            try
            {
                #region デバッグ用テストデータ
                string xmlFilePath = @"C:\Users\TakehiroSomekawa\source\repos\ExpSimulator\ExpSimulator\bin\Debug\Roming\ModelBaseData.xml";

                List<ClassModelBaseData> ModelBaseDataList = new List<ClassModelBaseData>();

                ClassModelBaseData ModelBaseData = new ClassModelBaseData();

                ModelBaseData.ModelName = "Pアズールレーン_THE_ANIMATION_異次元トリガー";
                ModelBaseData.ModelType = "ライトミドル";
                ModelBaseData.MakerName = "京楽";
                ModelBaseData.IntroductStartDate = DateTime.Parse("2024/7/8");
                ModelBaseData.ModelSpecData.FirstHitProb = 199;
                ModelBaseData.ModelSpecData.RandVarHitProb = 82;
                ModelBaseData.ModelSpecData.RandVarHitEntryRate = 40;
                ModelBaseData.ModelSpecData.RandVarHitContinueRate = 80;
                ModelBaseData.ModelSpecData.SpecialTime = 130;
                ModelBaseData.ModelSpecData.SavingTime = 100;
                ModelBaseData.ModelSpecData.Ctime = 0;
                ModelBaseData.ModelSuppleData.BorderRotateCount = 17;
                ModelBaseData.ModelSuppleData.Ranking = 3;
                ModelBaseData.ModelSuppleData.Note = "テスト";
                ModelBaseDataList.Add(ModelBaseData);

                ModelBaseData = new ClassModelBaseData();
                ModelBaseData.ModelName = "P新世紀エヴァンゲリオン15_未来への咆哮";
                ModelBaseData.ModelType = "ミドル";
                ModelBaseData.MakerName = "ビスティ";
                ModelBaseData.IntroductStartDate = DateTime.Parse("2021/12/20");
                ModelBaseData.ModelSpecData.FirstHitProb = 319.8;
                ModelBaseData.ModelSpecData.RandVarHitProb = 99.4;
                ModelBaseData.ModelSpecData.RandVarHitEntryRate = 59;
                ModelBaseData.ModelSpecData.RandVarHitContinueRate = 81;
                ModelBaseData.ModelSpecData.SpecialTime = 163;
                ModelBaseData.ModelSpecData.SavingTime = 100;
                ModelBaseData.ModelSpecData.Ctime = 0;
                ModelBaseData.ModelSuppleData.BorderRotateCount = 17.8;
                ModelBaseData.ModelSuppleData.Ranking = 5;
                ModelBaseData.ModelSuppleData.Note = "テスト";
                ModelBaseDataList.Add(ModelBaseData);

                ModelBaseData = new ClassModelBaseData();
                ModelBaseData.ModelName = "eReゼロから始める異世界生活_season2";
                ModelBaseData.ModelType = "ミドル";
                ModelBaseData.MakerName = "大都技研";
                ModelBaseData.IntroductStartDate = DateTime.Parse("2023/11/20");
                ModelBaseData.ModelSpecData.FirstHitProb = 349.9;
                ModelBaseData.ModelSpecData.RandVarHitProb = 99.9;
                ModelBaseData.ModelSpecData.RandVarHitEntryRate = 55;
                ModelBaseData.ModelSpecData.RandVarHitContinueRate = 77;
                ModelBaseData.ModelSpecData.SpecialTime = 145;
                ModelBaseData.ModelSpecData.SavingTime = 0;
                ModelBaseData.ModelSpecData.Ctime = 0;
                ModelBaseData.ModelSuppleData.BorderRotateCount = 16.6;
                ModelBaseData.ModelSuppleData.Ranking = 7;
                ModelBaseData.ModelSuppleData.Note = "テスト";
                ModelBaseDataList.Add(ModelBaseData);
                #endregion

                ClassOperatModelBaseData OperatModelBaseData = new ClassOperatModelBaseData();

                //XMLファイルの有無を確認
                if (System.IO.File.Exists(xmlFilePath) == false)
                {
                    //XMLファイルの新規作成
                    OperatModelBaseData.CreateNewXmlFile(xmlFilePath);
                }

                foreach(ClassModelBaseData _ModelBaseData in ModelBaseDataList)
                {
                    //機種基盤データをXMLファイルへ出力
                    OperatModelBaseData.OutputModelBaseDataToXML(_ModelBaseData, xmlFilePath);
                }
            }
            catch (Exception Ex)
            {
                WinModuleLibrary.ErrorModule.ShowErrorLog(Ex);
            }
        }
    }
}
