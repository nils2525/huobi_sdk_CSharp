﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.TriggerOrder
{
    /// <summary>
    /// The response for his order request
    /// </summary>
    public class GetTrackHisOrderResponse
    {
        public string status { get; set; }

        [JsonProperty("err_code", NullValueHandling = NullValueHandling.Ignore)]
        public string errorCode { get; set; }

        [JsonProperty("err_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string errorMessage { get; set; }

        public long ts { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Data data { get; set; }

        public class Data
        {
            public List<Order> orders { get; set; }

            public class Order
            {
                public string symbol { get; set; }

                [JsonProperty("contract_code")]
                public string contractCode { get; set; }

                [JsonProperty("triggered_price", NullValueHandling = NullValueHandling.Ignore)]
                public string triggeredPrice { get; set; }

                public double volume { get; set; }

                [JsonProperty("order_type")]
                public int orderType { get; set; }

                public string direction { get; set; }

                public string offset { get; set; }

                [JsonProperty("lever_rate")]
                public int leverRate { get; set; }

                [JsonProperty("order_id")]
                public long orderId { get; set; }

                [JsonProperty("order_id_str")]
                public string orderIdStr { get; set; }

                [JsonProperty("order_source")]
                public string orderSource { get; set; }

                [JsonProperty("created_at")]
                public long createdAt { get; set; }

                [JsonProperty("update_time")]
                public long updateTime { get; set; }

                [JsonProperty("order_price_type")]
                public string orderPriceType { get; set; }

                public int status { get; set; }

                [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
                public long canceledAt { get; set; }

                [JsonProperty("fail_code", NullValueHandling = NullValueHandling.Ignore)]
                public int failCode { get; set; }

                [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
                public string failReason { get; set; }

                [JsonProperty("callback_rate")]
                public double callbackRate { get; set; }

                [JsonProperty("active_price")]
                public double activePrice { get; set; }

                [JsonProperty("is_active")]
                public int isActive { get; set; }

                [JsonProperty("market_limit_price", NullValueHandling = NullValueHandling.Ignore)]
                public double marketLimitPrice { get; set; }

                [JsonProperty("formula_price", NullValueHandling = NullValueHandling.Ignore)]
                public double formulaPrice { get; set; }

                [JsonProperty("real_volume")]
                public double realVolume { get; set; }

                [JsonProperty("relation_order_id", NullValueHandling = NullValueHandling.Ignore)]
                public string relationOrderId { get; set; }

                [JsonProperty("margin_mode")]
                public string marginMode { get; set; }

                [JsonProperty("margin_account")]
                public string marginAccount { get; set; }

                [JsonProperty("contract_type", NullValueHandling = NullValueHandling.Ignore)]
                public string contractType { get; set; }

                [JsonProperty("pair", NullValueHandling = NullValueHandling.Ignore)]
                public string pair { get; set; }

                [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
                public string businessType { get; set; }
            }

            [JsonProperty("total_page")]
            public int totalPage { get; set; }

            [JsonProperty("current_page")]
            public int currentPage { get; set; }

            [JsonProperty("total_size")]
            public int totalSize { get; set; }
        }
    }
}
