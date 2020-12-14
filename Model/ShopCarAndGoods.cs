using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// 购物车  商品  用户
    /// </summary>
    public class ShopCarAndGoods
    {
        /// <summary>
        /// 购物车主键
        /// </summary>
        public int GoodsCarInfoId { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsInfoIdOut { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int GoodsNumber { get; set; }
        /// <summary>
        /// 商品主键
        /// </summary>
        public int GoodsInfoId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsInfoName { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string GoodsInfoImage { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public string GoodsInfoPrice { get; set; }
        /// <summary>
        /// 商品售出数量
        /// </summary>
        public int GoodsInfoCount { get; set; }
        /// <summary>
        /// 商品是否上架
        /// </summary>
        public int GoodsInfoState { get; set; }
        /// <summary>
        /// 商品出产地
        /// </summary>
        public string GoodsInfoPlace { get; set; }
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string GoodsInfoColor { get; set; }
        /// <summary>
        /// 商品规格
        /// </summary>
        public string GoodsInfoSize { get; set; }
        /// <summary>
        /// 所属店铺
        /// </summary>
        public int ShopIdOut { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public string GoodsTypes { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsInfoDesc { get; set; }
        /// <summary>
        /// 用户主键
        /// </summary>
        public int UserInfoId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserInfoName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserInfoPass { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string UserInfoSex { get; set; }
        /// <summary>
        /// 密保
        /// </summary>
        public string UserInfoLetter { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string UserInfoTake { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string UserInfoPhone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string UserInfoEmil { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string UserInfoHead { get; set; }
    }
}
