using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexTestProgram
{
    class ResultString
    {
        public string ValidValue { get; set; }
        public string InValidValue { get; set; }
        private string[] _values;
        public string[] Values
        {
            get { return this._values; }
        }

        public ResultString()
        {
            this._values = null;
        }

        public ResultString(string[] values)
        {
            this._values = values;

        }

        public ResultString(string value)
        {
            this._values = new string[1];
            this._values[0] = value;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Values :");

            foreach(string s in this.Values)
            {
                stringBuilder.Append($"{s} ");

            }
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("Valid values :");
            stringBuilder.AppendLine(this.ValidValue + "\n");
            stringBuilder.AppendLine("InValid values :");
            stringBuilder.AppendLine(this.InValidValue + " \n");

            return stringBuilder.ToString();
        }
    }
}
