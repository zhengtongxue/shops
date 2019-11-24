﻿using NUnit.Framework;
 using Shops;

 namespace ShopTests
{
    [TestFixture()]
    public class ProgramTests
    {
        [Test()]
        public void GetStatementTest()
        {
            var result= @"租借人：张三
攀登者:6
哪吒之魔童降世:1.5
昆虫总动员:3
战狼:2
让子弹飞:5
本次费用合计： 17.5
累计获得6 积分。
";
            Assert.AreEqual(result, Program.GetStatement());
        }
    }
}