using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class StringReplacer
    {
        public string ReplaceOccurence(string destination, Dictionary<string,string> targets)
        {
            var updatedText = string.Empty;

            #region Validation
            
            if (destination == null)
            {
                throw new ArgumentNullException("The destination string cannot be empty");
            }

            if (destination == string.Empty && targets.Count == 0)
            {
                return updatedText;
            }

            CheckHasTargetCharacters(destination);

            #endregion

            updatedText = destination;

            foreach (var dict in targets)
            {
                updatedText = InsertTargetsIntoDestination(updatedText, dict.Key, dict.Value);
            }

            return updatedText;
        }

        private static void CheckHasTargetCharacters(string destination)
        {
            var hasTargetCharacters = false;
            var numberOfTargetCharacters = 0;
            var targetCharacter = '$';

            foreach (var character in destination.ToArray())
            {
                if (character == targetCharacter)
                {
                    numberOfTargetCharacters++;
                }
            }

            if (numberOfTargetCharacters == 0 || numberOfTargetCharacters % 2 != 0)
            {
                throw new ArgumentException(string.Format("The destination string''s targets are not clear. Are you missing a {0}", targetCharacter));
            }
        }

        private string InsertTargetsIntoDestination(string destination, string target, string value)
        {
            var result = destination.Replace("$"+target+"$",value);

            return result;
        }
    }
}
