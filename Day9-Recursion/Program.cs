using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using Day9_Recursion;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Abc
{



    class Solution
    {

        // Complete the factorial function below.
        static int factorial(int n)
        {
            if (n <= 2)
                return n;
            return n * factorial(n - 1);
        }

        static void Main(string[] args)
        {

            string json = @"{
    'country': 'ru',
    'created_at': '2018-07-16 17:13:27 UTC',
    'id': '15308972074964102',
    'project': 'pwru15',
    'provider': 'tele2',
    'service': 'mobile_subscription_order',
    'status': 'successful',
    'mobile_subscription_order': {
        'action': 'payment',
        'id': '15308971931103228',
        'mode': 'click',
        'msisdn': '79041871620',
        'has_resubscriptions': false,
        'ip': '176.59.113.219',
        'native_id': '2130467'
    },
    'price_point': 30.0,
    'price_point_currency': 'rub'
}";


            var notification = JsonConvert.DeserializeObject<MegasystTele2Notification>(json, new JavaScriptDateTimeConverter());
            Console.ReadLine();
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    enum Status
    {
        [EnumMember(Value = "waiting")]
        Waiting,
        [EnumMember(Value = "successful")]
        Successful,
        [EnumMember(Value = "rejected")]
        Rejected,
        [EnumMember(Value = "complaint")]
        Complaint,
        [EnumMember(Value = "credit")]
        Credit,
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "overlimit")]
        Overlimit,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    enum Mode
    {
        [EnumMember(Value = "click")]
        Click,
        [EnumMember(Value = "pin")]
        Pin,
        [EnumMember(Value = "sms")]
        Sms
    }

    [JsonConverter(typeof(StringEnumConverter))]
    enum Action
    {
        [EnumMember(Value = "payment")]
        Payment,
        [EnumMember(Value = "subscription")]
        Subscription,
        [EnumMember(Value = "unsubscription")]
        Unsubscription
    }

    class MegasystTele2Notification
    {
        public long Id { get; set; }
        [JsonProperty("price_point")]
        public decimal PricePoint { get; set; }
        public string Country { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("price_point_currency")]
        public string Currency { get; set; }
        public string Project { get; set; }
        public string Provider { get; set; }
        public int Quantity { get; set; }
        public string Service { get; set; }
        public Status Status { get; set; }
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("mobile_subscription_order")]
        public MobileSubscriptionOrder MobileSubscriptionOrder { get; set; }
    }

    class MobileSubscriptionOrder
    {
        public long Id { get; set; }
        public Action Action { get; set; }
        public Mode Mode { get; set; }
        public string Msisdn { get; set; }
        [JsonProperty("has_resubscriptions")]
        public bool HasResubscriptions { get; set; }
        public string Ip { get; set; }
        [JsonProperty("native_id")]
        public long VisitId { get; set; }
    }


}
