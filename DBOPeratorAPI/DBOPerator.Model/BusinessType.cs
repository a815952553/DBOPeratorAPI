﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DBOPerator.Model
{
    /// <summary>
    /// 1根据数据库标号 执行整库建表 2根据数据库主键执行表分析 3 根据表主键执行建表 4根据表主键执行表分析
    /// </summary>
    public enum BusinessType
    {
        整库建表 = 1,
        整库表分析 = 2,
        表建表 = 3,
        表分析 = 4
    }
}
