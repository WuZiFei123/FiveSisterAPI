using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class RemarkInfoAndUserInfoAndGoodsInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int RemarkInfoId { get; set; }
        /// <summary>
        /// 评价内容
        /// </summary>
        public string RemarkInfoDesc { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UserInfoIdOut { get; set; }
        /// <summary>
        /// 商品外键
        /// </summary>
        public int GoodsLookIdOut { get; set; }
        /// <summary>
        /// 评价时间
        /// </summary>
        public string RemarkTime { get; set; }
        /// <summary>
        /// 评价图片
        /// </summary>
        public string RemarkImg { get; set; }
        /// <summary>
        /// 好评  中评  差评
        /// </summary>
        public int RemarkStare { get; set; }
        /// <summary>
        /// 商品主键
        /// </summary>
        public int GoodsLookId { get; set; }
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string GoodsColor { get; set; }
        /// <summary>
        /// 商品大小
        /// </summary>
        public string GoodsSize { get; set; }
        /// <summary>
        /// 商品库存
        /// </summary>
        public int GoodsKc { get; set; }
        /// <summary>
        /// 关联商品
        /// </summary>
        public int GoodsIdOut { get; set; }


        /// <summary>
        /// 主键
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
