using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;

using System.Xml;

namespace ExpSimulator.Models
{
    internal class ClassOperatModelBaseData
    {
        /// <summary>
        /// XMLファイルの新規作成
        /// </summary>
        /// <param name="xmlFilePath">XMLファイルパス</param>
        internal void CreateNewXmlFile(string xmlFilePath)
        {
            XmlDocument XmlDoc = new XmlDocument();

            //ルート要素を作成
            XmlElement ElementRoot = XmlDoc.CreateElement("Root");
            XmlDoc.AppendChild(ElementRoot);

            //XMLファイルを保存
            XmlDoc.Save(xmlFilePath);
        }

        /// <summary>
        /// XML要素の追加
        /// </summary>
        /// <param name="XmlDoc">XmlDocumentオブジェクト</param>
        /// <param name="ElementParent">親要素</param>
        /// <param name="elementName">要素名</param>
        /// <param name="value">値</param>
        private void AddElement(XmlDocument XmlDoc, XmlElement ElementParent, string elementName, string value)
        {
            XmlElement NewElement = XmlDoc.CreateElement(elementName);
            NewElement.InnerText = value;
            ElementParent.AppendChild(NewElement);
        }

        /// <summary>
        /// 機種基盤データをXMLファイルへ出力
        /// </summary>
        internal void OutputModelBaseDataToXML(ClassModelBaseData ModelBaseData, string xmlFilePath)
        {
            XmlDocument XmlDoc = new XmlDocument();

            //XMLファイルを読み込む
            XmlDoc.Load(xmlFilePath);

            #region XML要素の作成
            //---------------------------------------------------------------------
            //機種基盤データ
            //1.機種名:ModelName
            //2.機種タイプ:ModelType
            //3.メーカー:MakerName
            //4.導入開始日:IntroductStartDate
            //---------------------------------------------------------------------
            XmlElement ElementModelBaseData = XmlDoc.CreateElement("ModelBaseData");

            AddElement(XmlDoc, ElementModelBaseData, "ModelName", Convert.ToString(ModelBaseData.ModelName));
            AddElement(XmlDoc, ElementModelBaseData, "ModelType", Convert.ToString(ModelBaseData.ModelType));
            AddElement(XmlDoc, ElementModelBaseData, "MakerName", Convert.ToString(ModelBaseData.MakerName));
            AddElement(XmlDoc, ElementModelBaseData, "IntroductStartDate", ModelBaseData.IntroductStartDate.ToString("yyyy/MM/dd"));

            //---------------------------------------------------------------------
            //機種性能データ
            //1.初当り確率:FirstHitProb
            //2.確変当り確率:RandVarHitProb
            //3.確変突入率:RandVarHitEntryRate
            //4.確変継続率:RandVarHitContinueRate
            //5.ST:SpecialTime
            //6.時短回数:SavingTime
            //7.CT:Ctime
            //---------------------------------------------------------------------
            XmlElement ElementModelSpecData = XmlDoc.CreateElement("ModelSpecData");

            AddElement(XmlDoc, ElementModelSpecData, "FirstHitProb", Convert.ToString(ModelBaseData.ModelSpecData.FirstHitProb));
            AddElement(XmlDoc, ElementModelSpecData, "RandVarHitProb", Convert.ToString(ModelBaseData.ModelSpecData.RandVarHitProb));
            AddElement(XmlDoc, ElementModelSpecData, "RandVarHitEntryRate", Convert.ToString(ModelBaseData.ModelSpecData.RandVarHitEntryRate));
            AddElement(XmlDoc, ElementModelSpecData, "RandVarHitContinueRate", Convert.ToString(ModelBaseData.ModelSpecData.RandVarHitContinueRate));
            AddElement(XmlDoc, ElementModelSpecData, "SpecialTime", Convert.ToString(ModelBaseData.ModelSpecData.SpecialTime));
            AddElement(XmlDoc, ElementModelSpecData, "SavingTime", Convert.ToString(ModelBaseData.ModelSpecData.SavingTime));
            AddElement(XmlDoc, ElementModelSpecData, "Ctime", Convert.ToString(ModelBaseData.ModelSpecData.Ctime));

            //機種性能データへ要素を紐づけ
            ElementModelBaseData.AppendChild(ElementModelSpecData);

            //---------------------------------------------------------------------
            //機種補足データ
            //1.ボーダー回転数:BorderRotateCount
            //2.ランキング:Ranking
            //3.備考:Note
            //---------------------------------------------------------------------
            XmlElement ElementModelSuppleData = XmlDoc.CreateElement("ModelSuppleData");

            AddElement(XmlDoc, ElementModelSuppleData, "BorderRotateCount", Convert.ToString(ModelBaseData.ModelSuppleData.BorderRotateCount));
            AddElement(XmlDoc, ElementModelSuppleData, "Ranking", Convert.ToString(ModelBaseData.ModelSuppleData.Ranking));
            AddElement(XmlDoc, ElementModelSuppleData, "Note", Convert.ToString(ModelBaseData.ModelSuppleData.Note));
            
            //機種補足データへ要素を紐づけ
            ElementModelBaseData.AppendChild(ElementModelSuppleData);

            //機種基盤データへ要素を紐づけ
            XmlDoc.DocumentElement.AppendChild(ElementModelBaseData);
            #endregion

            //XMLファイルを保存
            XmlDoc.Save(xmlFilePath);
        }
    }
}
