using System;
using System.Collections.Generic;
using System.Text;
using Top.Api.Request;

namespace OrderPullService.LaZaDaService.Dto
{
  
    public class Trade
    {
        public string voucher { get; set; }
        public AddressShipping address_shipping { get; set; }
        public string customer_last_name { get; set; }
        public int gift_option { get; set; }
        public string voucher_code { get; set; }

        public string updated_at { get; set; }
        public string delivery_info { get; set; }
        public string gift_message { get; set; }
        public string branch_number { get; set; }
        public string tax_code { get; set; }
        public string extra_attributes { get; set; }
        public string shipping_fee { get; set; }
        public string customer_first_name { get; set; }
        public string payment_method { get; set; }
        public string statuses { get; set; }
        public string remarks { get; set; }
        public string order_number { get; set; }

        public string order_id { get; set; }
        public string national_registration_number { get; set; }
        public string promised_shipping_times { get; set; }
        public long items_count { get; set; }
        public string created_at { get; set; }
        public string price { get; set; }
        public string warehouse_code { get; set; }
        public string shipping_fee_original { get; set; }
        public string shipping_fee_discount_seller { get; set; }
        public string shipping_fee_discount_platform { get; set; }
        public AddressBilling address_billing { get; set; }
    }
    public class AddressBilling
    {
        public string address3 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string address1 { get; set; }
        public string phone2 { get; set; }
        public string first_name { get; set; }
        public string phone { get; set; }
        public string address5 { get; set; }
        public string post_code { get; set; }
        public string address4 { get; set; }
        public string last_name { get; set; }
        public string country { get; set; }
    }
    public class AddressShipping
    {
        public string address5 { get; set; }

        public string post_code { get; set; }
        public string address4 { get; set; }
        public string last_name { get; set; }

        public string country { get; set; }
        public string address3 { get; set; }
        public string address2 { get; set; }
        public string address1 { get; set; }
        public string city { get; set; }

        public string phone2 { get; set; }
        public string first_name { get; set; }

        public string phone { get; set; }
    }
}
