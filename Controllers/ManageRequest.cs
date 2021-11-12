using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculation.Controllers
{
    public static class ManageRequest
    {
        private static Dictionary<Tuple<int, string, int>, string> dict;

        public static string runProcess(PostRequest request)
        {
            string retVal ;
            Tuple<int, string, int> top = new Tuple<int, string, int>(request.left, request._operator, request.right);
            getDict();
            if(dict.TryGetValue(top, out retVal))
            {
                return retVal;
            }
            int leftNum = request.left;
            int rightNum = request.right;
            switch (request._operator)
            {
                case "plus":
                    retVal = Calculate.add(leftNum, rightNum);
                    break;
                case "minus":
                    retVal = Calculate.Subtraction(leftNum, rightNum);
                    break;
                case "multiply":
                    retVal = Calculate.multiple(leftNum, rightNum);
                    break;
                case "divide":
                    if(rightNum == 0)
                    {
                        return "The input is not leagal -  Divide-by-Zero";
                    }
                    retVal = Calculate.Division(leftNum, rightNum);
                    break;
                default:
                    return "The input is not leagal - operator missing";
            }
            addToDictionary(top, retVal);
            return retVal;
        }

        private static void getDict()
        {
            if(dict == null)
            {
                dict = new Dictionary<Tuple<int, string, int>, string>();
            }
        }

        private static void addToDictionary(Tuple<int, string, int> top, string result)
        {
            dict.Add(top, result);
        }

      
    }
}
