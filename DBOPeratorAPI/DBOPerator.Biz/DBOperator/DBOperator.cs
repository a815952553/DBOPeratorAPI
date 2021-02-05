﻿using DBOPerator.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBOPerator.Biz
{
    /// <summary>
    /// 操作
    /// </summary>
    public class DBOperator : IDBOperator
    {
        /// <summary>
        /// 获取所有数据库
        /// </summary>
        /// <param name="connectionString">数据库连接</param>
        /// <returns>数据库列表</returns>
        public List<string> GetAllDataBase(string connectionString, ref SqlSugarClient client)
        {
            client = ConnectionHelper.GetSqlSugarClientByConString(connectionString);
            string sql = "show databases;";
            return client.Ado.SqlQuery<string>(sql);
        }

        /// <summary>
        /// 获取数据库所有表
        /// </summary>
        /// <param name="dataBaseName">数据库名字</param>
        /// <param name="client">数据库连接</param>
        /// <returns>结果</returns>
        public List<Table> GetAllTables(string dataBaseName, SqlSugarClient client)
        {
            string sql = $"select table_name,TABLE_COMMENT from information_schema.tables where table_schema='{dataBaseName}'";
            return client.Ado.SqlQuery<Table>(sql);
        }

        /// <summary>
        /// 获取表ddl
        /// </summary>
        /// <param name="tableName">表名字</param>
        /// <param name="client">客户端</param>
        /// <returns>结果</returns>
        public dynamic GetTableDDL(string tableName, SqlSugarClient client)
        {
            string sql = $"show create table {tableName};";
            return client.Ado.SqlQuerySingle<dynamic>(sql);
        }
    }
}
