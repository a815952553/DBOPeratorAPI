﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBOPerator.Model
{
    /// <summary>
    /// 表信息
    /// </summary>
    public class TableModel
    {
        /// <summary>
        /// 表编号
        /// </summary>
        public string TabelKeyID { get; set; }

        /// <summary>
        /// 数据库连接编号
        /// </summary>
        public string ConStringKeyID { get; set; }

        /// <summary>
        /// 表描述
        /// </summary>
        public string TableDesc { get; set; }

        /// <summary>
        /// 下期创建情况 1无需创建 2 带创建 3已创建 4创建失败
        /// </summary>
        public int CreateStatus { get; set; }

        /// <summary>
        /// 下期更新情况 1无需修改 2 待更新 3已更新 4创建失败
        /// </summary>
        public int ModifyStatus { get; set; }

        /// <summary>
        /// 表检查结果 1无需检测 2待检测 3已检测通过 4检测错误
        /// </summary>
        public int CheckStatus { get; set; }

        /// <summary>
        /// 分表方式 1 按年 2 按月 3按天 4按HASH
        /// </summary>
        public int SplitType { get; set; }

        /// <summary>
        /// hash最大值，只有hash分表才有值
        /// </summary>
        public int HashCount { get; set; }

        /// <summary>
        /// 最小表名
        /// </summary>
        public string MinTableName { get; set; }

        /// <summary>
        /// 最大表名
        /// </summary>
        public string MaxTableName { get; set; }

        /// <summary>
        /// 模板状态 1启用 2禁用
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
