﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class GoodsInfo_PageList
    {
        public List<GoodsInfo> GoodsInfos { get; set; }
        public int Count { get; set; }
        public int Con { get; set; }
        public int GoodsCon { get; set; }
    }
}
