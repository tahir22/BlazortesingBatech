using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIngWebApp.Shared
{
    public class SelectListItem
    {
        public SelectListItem()
        {

        }
        public SelectListItem(int value, string text)
        {
            IntValue = value;
            Text = text;
        }

        public SelectListItem(int value, string text1, string text2, string symbol)
        {
            IntValue = value;
            Text = $"{text1}{symbol}{text2}";
        }

        public SelectListItem(int value, string text, string AdditionalValue)
        {
            IntValue = value;
            Text = text;
            this.AdditionalValue = AdditionalValue;
        }
        public SelectListItem(string value, string text)
        {
            Value = value;
            Text = text;
        }

        public int? IntValue
        {
            get
            {
                if (int.TryParse(Value, out int value))
                {
                    return value;
                }
                return null;
            }
            set
            {
                Value = value?.ToString();
            }
        }
        public string AdditionalValue { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }

    }
}
