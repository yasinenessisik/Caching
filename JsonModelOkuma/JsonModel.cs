using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonModelOkuma
{
    public class Price
    {
        public Double original { get; set; }
        public string original_str { get; set; }
        public Double whole { get; set; }
        public string whole_str { get; set; }
        public string fraction { get; set; }
        public string fraction_str { get; set; }
        public string currency { get; set; }
        public string currency_symbol { get; set; }
        public string decimal_seperator { get; set; }
        public string thousands_separator { get; set; }
    }

    public class CargoPrice
    {
        public Double original { get; set; }
        public string original_str { get; set; }
        public Double whole { get; set; }
        public string whole_str { get; set; }
        public string fraction { get; set; }
        public string fraction_str { get; set; }
        public string currency { get; set; }
        public string currency_symbol { get; set; }
        public string decimal_seperator { get; set; }
        public string thousands_separator { get; set; }
    }

    public class Units
    {
        public string title { get; set; }
        public bool is_in_basket { get; set; }
        public bool is_default { get; set; }
        public Double available_quantity { get; set; }
        public Double basket_quantity { get; set; }
        public CargoPrice basket_price { get; set; }
    }

    public class Image
    {
        public Double id { get; set; }
        public Double productid { get; set; }
        public Double product_serialid { get; set; }
        public string url { get; set; }
        public Double type { get; set; }
        public object title { get; set; }
        public Double order { get; set; }
    }

    public class Product
    {
        public Double rank { get; set; }
        public string list_view { get; set; }
        public Double categoryid { get; set; }
        public string description { get; set; }
        public Double add_basket_option { get; set; }
        public Double add_basket_size { get; set; }
        public object cashback_label { get; set; }
        public string cashback_total { get; set; }
        public Double add_basket_status { get; set; }
        public string brand { get; set; }
        public string madein { get; set; }
        public Double id { get; set; }
        public Double serial_id { get; set; }
        public string serial_title { get; set; }
        public Price price { get; set; }
        public string slug { get; set; }
        public string product_detail_link { get; set; }
        public string vat_ratio { get; set; }
        public object slogan { get; set; }
        public bool basket_update_disable { get; set; }
        public Double visit_count { get; set; }
        public Double gift_status { get; set; }
        public string product_code { get; set; }
        public Double gift_pack_status { get; set; }
        public bool exclusive { get; set; }
        public object information { get; set; }
        public DateTime created_at { get; set; }
        public Double order_add_basket_status { get; set; }
        public Double add_basket_default_option { get; set; }
        public string basket_increase_size { get; set; }
        public object product_group_identity { get; set; }
        public object product_serial_identity { get; set; }
        public string min_basket_add_amount { get; set; }
        public string max_basket_add_amount { get; set; }
        public string barcode { get; set; }
        public object kind_name { get; set; }
        public Double quantity { get; set; }
        public Double cargo_day { get; set; }
        public Double installment_status { get; set; }
        public string installment_description_mobile { get; set; }
        public Double fix_status { get; set; }
        public string title { get; set; }
        public Double discount_ratio { get; set; }
        public bool is_discounted { get; set; }
        public bool is_store_required { get; set; }
        public bool has_multiple_units { get; set; }
        public string product_name { get; set; }
        public CargoPrice cargo_price { get; set; }
        public Price old_price { get; set; }
        public string category_breadcrumb { get; set; }
        public bool is_in_favorite { get; set; }
        public Double favorite_item_id { get; set; }
        public bool is_in_wishlist { get; set; }
        public Double basket_quantity { get; set; }
        public List<Image> images { get; set; }
        public Dictionary<string, string> image_types { get; set; }
        public Units units { get; set; }
        public object campaign { get; set; }
    }

    public class Payload
    {
        public List<Product> products { get; set; }
    }

    public class Meta
    {
        public Dictionary<string, List<object>> messages { get; set; }
    }

    public class Root
    {
        public Meta meta { get; set; }
        public Payload payload { get; set; }
    }
}
