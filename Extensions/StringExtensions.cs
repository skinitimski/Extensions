using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Atmosphere.Extensions
{
    public static class StringExtensions
    {  
        public static bool EqualsAny(this string input, params string[] values)
        {
            return input.EqualsAny((ICollection<String>)values);
        }

        public static bool EqualsAny(this string input, ICollection<String> values)
        {
            if (input == null)
                throw new ArgumentNullException("input");

            bool equalsAny = false;

            if (values != null)
            {
                equalsAny = values.Any((string value) => input.Equals(value));
            }

            return equalsAny;
        }

        public static bool StartsWithAny(this string input, params string[] values)
        {
            return input.StartsWithAny((ICollection<String>)values);
        }
        
        public static bool StartsWithAny(this string input, ICollection<String> values)
        {
            if (input == null) throw new ArgumentNullException("input");

            bool startsWithAny = false;
            
            if (values != null)
            {
                startsWithAny = values.Any((string value) => input.StartsWith(value));
            }
            
            return startsWithAny;
        }
        
        public static bool StartsWithAny(this string input, params char[] values)
        {
            return input.StartsWithAny((ICollection<char>)values);
        }
        
        public static bool StartsWithAny(this string input, ICollection<char> values)
        {
            if (input == null) throw new ArgumentNullException("input");
            
            bool startsWithAny = false;
            
            if (values != null && input.Length > 0)
            {
                startsWithAny = values.Any((char value) => input[0] == value);
            }
            
            return startsWithAny;
        }







        public static bool EndsWithAny(this string input, params string[] values)
        {
            return input.EndsWithAny((ICollection<String>)values);
        }


        public static bool EndsWithAny(this string input, ICollection<String> values)
        {
            if (input == null) throw new ArgumentNullException("input");

            bool endsWithAny = false;

            if (values != null)
            {
                endsWithAny = values.Any((string value) => input.EndsWith(value));
            }

            return endsWithAny;
        }
        
        public static bool EndsWithAny(this string input, params char[] values)
        {
            return input.EndsWithAny((ICollection<char>)values);
        }
        
        public static bool EndsWithAny(this string input, ICollection<char> values)
        {
            if (input == null) throw new ArgumentNullException("input");
            
            bool endsWithAny = false;
            
            if (values != null && input.Length > 0)
            {
                endsWithAny = values.Any((char value) => input[input.Length - 1] == value);
            }
            
            return endsWithAny;
        }
    }
}

