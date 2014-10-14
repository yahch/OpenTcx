using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

namespace OpenTcx
{
    public class Tcx
    {
        /// <summary>
        /// 解析Tcx文件内容
        /// </summary>
        /// <param name="tckFile"></param>
        /// <param name="callback"></param>
        public void AnalyzeTckFile(string tckFile,Action<Entities.TrainingCenterDatabase_t,System.Exception> callback)
        {
            Entities.TrainingCenterDatabase_t data = null;
            System.Exception ex = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Entities.TrainingCenterDatabase_t));
                using (FileStream fs = new FileStream(tckFile, FileMode.Open))
                {
                    data = xs.Deserialize(fs) as Entities.TrainingCenterDatabase_t;
                   
                }
            }
            catch (Exception exp)
            {
                ex = exp;
            }

            callback(data, ex);
        }

        /// <summary>
        /// 验证Tcx有效性
        /// </summary>
        /// <param name="tckFile"></param>
        /// <returns></returns>
        public bool ValidateTcx(string tckFile)
        {
            try
            {
                Validator vad = new Validator();
                return vad.Validate(tckFile, false);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
