using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            //
            // Insert code here.
            //
            //
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
            //throw new NotImplementedException($"PrintValues() has not been implemented");
            switch (Type.GetTypeCode(obj.GetType()))
            {
                case TypeCode.Byte:
                    return "Data type => byte";
                case TypeCode.Int32:
                    return "Data type => int";
                case TypeCode.Int16:
                    return "Data type => short";
                case TypeCode.Int64:
                    return "Data type => long";
                case TypeCode.Single:
                    return "Data type => float";
                case TypeCode.Double:
                    return "Data type => double";
                case TypeCode.Char:
                    return "Data type => char";
                case TypeCode.Boolean:
                    return "Data type => boolean";
                case TypeCode.Object:
                    return "Data type => object";
                case TypeCode.String:
                    return "Data type => string";
                case TypeCode.Decimal:
                    return "Data type => decimal";
                case TypeCode.SByte:
                    return "Data type => sbyte";
                case TypeCode.UInt32:
                    return "Data type => uint";
                case TypeCode.UInt16:
                    return "Data type => ushort";
                case TypeCode.UInt64:
                    return "Data type => ulong";
                default:
                    return "";
            }
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            //throw new NotImplementedException($"StringToInt() has not been implemented");
            int i;
            bool myBool = Int32.TryParse(numString, out i);
            if (myBool)
            {
                return i;
            }
            else 
            {
                return null;
            }
        }
    }// end of class
}// End of Namespace
