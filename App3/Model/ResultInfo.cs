using System;

namespace App3.Model
{
    [Serializable]
    public class ResultInfo
    {
        /// <summary>
        /// 0 操作失败,1操作成功,2操作异常
        /// </summary>
        public int ResultCode { get; set; }
        /// <summary>
        ///操作的结果提示
        /// </summary>
        public string ResultMess { get; set; }
        /// <summary>
        /// 返回总数
        /// </summary>
        public int count { get; set; }
    }
}